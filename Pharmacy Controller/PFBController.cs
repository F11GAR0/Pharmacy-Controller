using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy_Controller
{
    class PFBController
    {
        ~PFBController()
        {
            Globals.connection.Close();
        }
        public bool Connect(string path)
        {
            Globals.Log("Trying to connect to db: " + Globals.bdpath);
            FileInfo file = new FileInfo(path);
            string connection_string = "";
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            cs.DataSource = "localhost";
            cs.Database = path;
            cs.UserID = "SYSDBA";
            cs.Password = "masterkey";
            cs.Dialect = 3;
            connection_string = cs.ToString();
            Globals.connection = new FbConnection(connection_string);
            try
            {
                Globals.connection.Open();
                if (Globals.connection.State == ConnectionState.Open)
                {
                    Globals.bd_connected = true;
                    Globals.Log("Connected to db: " + Globals.bdpath);
                    return true;
                }
            }
            catch (FbException ex)
            {
                Globals.bd_connected = false;
                Globals.Log(ex.Message + " | Exception" + ex.ErrorCode + ex.Source);
            }
            return false;
        }
        private DataTable SendQuery(string query_string)
        {
            if (Globals.connection.State == ConnectionState.Open)
            {
                FbTransaction transaction = Globals.connection.BeginTransaction();
                FbCommand cmd = new FbCommand(query_string, Globals.connection, transaction);
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                transaction.Commit();
                return table;
            } else
            {
                MessageBox.Show("Error, conection is closed", "Error");
                Globals.Log("connection is closed. query not sended: " + query_string);
                return new DataTable();
            }
        }
        private DataTable GetTable(string table_name)
        {
            return SendQuery("select * from " + table_name + ";");
        }
        public bool IsStructureValid()
        {
            DataTable table = SendQuery("select RDB$RELATION_NAME from RDB$RELATIONS where(RDB$SYSTEM_FLAG = 0) AND(RDB$RELATION_TYPE = 0) order by RDB$RELATION_NAME");
            if(table.Rows.Count != 9)
            {
                Globals.Log("Structure check failed. Fields count != 5");
                return false;
            } 
//#if DEBUG
            Globals.Log("table.Rows[0][0] = " + table.Rows[0 + 4][0].ToString());
            Globals.Log("table.Rows[1][0] = " + table.Rows[1 + 4][0].ToString());
            Globals.Log("table.Rows[2][0] = " + table.Rows[2 + 4][0].ToString());
            Globals.Log("table.Rows[3][0] = " + table.Rows[3 + 4][0].ToString());
            Globals.Log("table.Rows[4][0] = " + table.Rows[4 + 4][0].ToString());
            //#endif
            if (table.Rows[0 + 4][0].ToString().TrimEnd(' ') == "PREPARATIONS"
            && table.Rows[1 + 4][0].ToString().TrimEnd(' ') == "RECEPT"
            && table.Rows[2 + 4][0].ToString().TrimEnd(' ') == "SALES"
            && table.Rows[3 + 4][0].ToString().TrimEnd(' ') == "SALE_PARTITIONS"
            && table.Rows[4 + 4][0].ToString().TrimEnd(' ') == "SELLERS")
            {
                Globals.Log("Good structure. Ok.");
                return true;
            }
            return false;
        }
        public DataTable GetPreparations()
        {
            DataTable ret_table = GetTable("PREPARATIONS");
            ret_table.Columns[0].ColumnName = "ID Препарата";
            ret_table.Columns[1].ColumnName = "Название";
            ret_table.Columns[2].ColumnName = "Производитель";
            ret_table.Columns[3].ColumnName = "Оставшиеся количество (шт.)";
            ret_table.Columns[4].ColumnName = "Цена (руб.)";
            ret_table.Columns[5].ColumnName = "Нужен ли рецепт? (y - да / n - нет)";
            return ret_table;
        }
        public DataTable GetSalesHistory(DateTime from, DateTime to)
        {
            DataTable ret = SendQuery("SELECT * from SALES where (SALES.\"TIME\" >= '" + from.ToShortDateString() + "') and (SALES.\"TIME\" <= '" + to.ToShortDateString() + "');");

            DataTable nret = new DataTable();
            nret.Columns.Add("ID Продажи", typeof(long));
            nret.Columns.Add("Номер продажи (чек)", typeof(int));
            nret.Columns.Add("Кассир", typeof(string));
            nret.Columns.Add("Итоговая цена (руб.)", typeof(double));
            nret.Columns.Add("Дата", typeof(string));
            for (int i = 0; i < ret.Rows.Count; i++)
            {
                long seller_id = long.Parse(ret.Rows[i][2].ToString());
                DataTable seller_inf = GetSellerInfo(seller_id);
                string family = seller_inf.Rows[0][2].ToString();
                string name = seller_inf.Rows[0][1].ToString();
                string patr = seller_inf.Rows[0][3].ToString();
                nret.Rows.Add(new object[] { ret.Rows[i][0], ret.Rows[i][1], family + " " + name[0] + "." + patr[0] + ".", ret.Rows[i][3], ret.Rows[i][4] });
            }
            return nret;
        }
        public DataTable GetSellerInfo(long id)
        {
            DataTable ret = SendQuery("select * from SELLERS where SELLERS.ID_SELLER = " + id.ToString() + ";");
            return ret;
        }
        public DataTable DecreaseFieldValue(string table, string field, string id_field, long pk_id)
        {
            DataTable ret = SendQuery("UPDATE " + table + " set " + table + ".\"" + field + "\" = (" + table + ".\"" + field + "\" - 1) where " + table + ".\"" + id_field + "\" =" + pk_id + ";");
            return ret;
        }
        public DataTable AddRecept(int rec_num, receptData rec)
        {
            return SendQuery("INSERT INTO RECEPT VALUES(gen_id(GEN_RECEPT_ID, 1)," + rec_num.ToString() + ",'" + rec.fio + "','" + rec.end_date + "','" + rec.prep_name + "');");
        }
        public long GetReceptID(int rec_num)
        {
            DataTable table = SendQuery("SELECT * from RECEPT where RECEPT.RECEPT_NUMBER = " + rec_num.ToString() + ";");
            return long.Parse(table.Rows[0][0].ToString());
        }
        public DataTable SellPreparePart(long check_id, long id, long recept)
        {
            // DataTable ret = SendQuery("");
            SendQuery("INSERT INTO SALE_PARTITIONS VALUES(gen_id(GEN_SALE_PARTITIONS_ID, 1)," + check_id.ToString() + "," + id.ToString() + "," + recept.ToString() + ");");
            return DecreaseFieldValue("PREPARATIONS", "COUNT", "ID_PREP", id);
        }
        public DataTable SellPrepareEnd(long check_id, long seller, double total_price, string time)
        {
            return SendQuery("INSERT INTO SALES VALUES(gen_id(GEN_SALES_ID, 1 )," + check_id.ToString() + "," + seller.ToString() + "," + total_price.ToString() + ",'" + time + "');");
        }
        public int GetPrepCount(long id_prep)
        {
            DataTable tab = SendQuery("SELECT PREPARATIONS.ID_PREP, PREPARATIONS.COUNT from PREPARATIONS where PREPARATIONS.ID_PREP = " + id_prep.ToString() + ";");
            return int.Parse(tab.Rows[0][1].ToString());
        }
        public int GetPrepPrice(long id_prep)
        {
            DataTable tab = SendQuery("SELECT PREPARATIONS.ID_PREP, PREPARATIONS.PRICE from PREPARATIONS where PREPARATIONS.ID_PREP = " + id_prep.ToString() + ";");
            return int.Parse(tab.Rows[0][1].ToString());
        }
        public string GetPrepName(long id_prep)
        {
            DataTable tab = SendQuery("SELECT PREPARATIONS.ID_PREP, PREPARATIONS.NAME from PREPARATIONS where PREPARATIONS.ID_PREP = " + id_prep.ToString() + ";");
            return tab.Rows[0][1].ToString();
        }
        public int GetReceptNumber(long rec_id)
        {
            DataTable tab = SendQuery("SELECT RECEPT.ID_RECEPT, RECEPT.RECEPT_NUMBER from RECEPT where RECEPT.ID_RECEPT = " + rec_id.ToString() + ";");
            return int.Parse(tab.Rows[0][1].ToString());
        }
        public string GetSellerInfoString(long seller_id)
        {
            DataTable tab = SendQuery("SELECT * from SELLERS where SELLERS.ID_SELLER = " + seller_id.ToString() + ";");
            return tab.Rows[0][2].ToString() + " " + tab.Rows[0][1].ToString() + " " + tab.Rows[0][3].ToString() + " " + "[" + tab.Rows[0][4].ToString() + "]";
        }
        public DataTable GetSaleFullInfo(long sale_number)
        {
            DataTable ret = SendQuery(
                "SELECT * from SALE_PARTITIONS where SALE_PARTITIONS.SALE_NUMBER = " + sale_number.ToString() + ";"
                );
            DataTable nret = new DataTable();
            /*nret.Columns.Add("ID Части продажи", Type.GetType("Int64"));
            nret.Columns.Add("Номер продажи(чека)", Type.GetType("Int64"));
            nret.Columns.Add("Препарат", Type.GetType("String"));
            nret.Columns.Add("ID Рецепта", Type.GetType("Int64"));
            */
            nret.Columns.Add("ID Части продажи");
            nret.Columns.Add("Препарат");
            nret.Columns.Add("Цена(руб.)");
            nret.Columns.Add("Номер рецепта");
            for (int i = 0; i < ret.Rows.Count; i++)
            {
                long prep_id = long.Parse(ret.Rows[i][2].ToString());
                nret.Rows.Add(new object[] { ret.Rows[i][0], GetPrepName(prep_id), GetPrepPrice(prep_id), GetReceptNumber(long.Parse(ret.Rows[i][3].ToString())) });
            }
            return nret;
        }
        public DataTable GetReceptInfo(long recept_num)
        {
            DataTable ret = SendQuery("SELECT * from RECEPT where RECEPT.RECEPT_NUMBER = " + recept_num.ToString() + ";");
            ret.Columns[1].ColumnName = "Номер рецепта";
            ret.Columns[2].ColumnName = "Для пациента (ФИО)";
            ret.Columns[3].ColumnName = "Дата окончания рецепта";
            ret.Columns[4].ColumnName = "Для препарата";
            ret.Columns.RemoveAt(0);
            return ret;
        }
    }
}
