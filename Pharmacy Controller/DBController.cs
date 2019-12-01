using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Forms;

namespace Pharmacy_Controller
{
    public partial class DBController : MetroForm
    {
        InternalSellsMaster sells_master = new InternalSellsMaster();
        public DBController()
        {
            Globals.controller = new PFBController();
            if (!Globals.controller.Connect(Globals.bdpath))
            {
                MessageBox.Show("Failed to connect. Check log.", "Error");
                this.Close();
                Globals.start_page_form.Show();
            } else
            {
                if (!Globals.controller.IsStructureValid())
                {
                    MessageBox.Show("Table struct is invalid", "Error");
                    this.Close();
                    Globals.start_page_form.Show();
                }
            }
            InitializeComponent();
            DataTable inffio = Globals.controller.GetSellerInfo(Globals.seller_id);
            Globals.seller_fio = inffio.Rows[0][1].ToString() + " " + inffio.Rows[0][2].ToString() + " " + inffio.Rows[0][3].ToString();
            dataGV.DataSource = Globals.controller.GetPreparations();
            //dataGV.DataSource = inffio;
        }

        private void DBController_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.start_page_form.Show();
        }
        Check form_check;
        private void bAddToQueue_Click(object sender, EventArgs e)
        {
            if (!Globals.form_check_inited)
            {
                Globals.form_check_inited = true;
                form_check = new Check(sells_master.GetFreeCheckNumber(), sells_master.GetFreeFD());
                form_check.StyleManager = this.StyleManager;
                form_check.Show();
            }
            if(dataGV.CurrentRow.Cells[5].Value.ToString() == "y")
            {
                Recept rec_confirm = new Recept(dataGV.CurrentRow.Cells[1].Value.ToString(), sells_master.GetFreeReceptID());
                rec_confirm.StyleManager = this.StyleManager;
                if (rec_confirm.ShowDialog() == DialogResult.OK)
                {
                    ReceptData data = rec_confirm.GetReceptData();
                    Globals.Log(data.name + " " + data.family + " " + data.patronymic);
                    form_check.AddItem(int.Parse(dataGV.CurrentRow.Cells[0].Value.ToString()), dataGV.CurrentRow.Cells[1].Value.ToString(), double.Parse(dataGV.CurrentRow.Cells[4].Value.ToString()), data.recnumber, new receptData(data.name + " " + data.family + " " + data.patronymic , data.date, data.prep), int.Parse(dataGV.CurrentRow.Cells[3].Value.ToString()));
                }
            } else
            form_check.AddItem(int.Parse(dataGV.CurrentRow.Cells[0].Value.ToString()), dataGV.CurrentRow.Cells[1].Value.ToString(), double.Parse(dataGV.CurrentRow.Cells[4].Value.ToString()), 0, new receptData(), int.Parse(dataGV.CurrentRow.Cells[3].Value.ToString()));
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            if (Globals.form_check_inited)
            {
                var list = form_check.GetSellList();
                double total_price = 0;
                foreach (var i in list)
                {
                    for (int j = 0; j < i.count; j++)
                    {
                        total_price += i.price;
                        long id_rec = 0; //for foreign key bounding
                        if(i.recept_id != 0)
                        {
                            Globals.controller.AddRecept(i.recept_id, i.recept);
                            id_rec = Globals.controller.GetReceptID(i.recept_id);
                        }
                        Globals.controller.SellPreparePart(form_check.GetCheckId(), i.id_in_table, id_rec);
                    }
                }
                Globals.controller.SellPrepareEnd(form_check.GetCheckId(), Globals.seller_id, total_price, DateTime.Now.ToShortDateString());
                dataGV.DataSource = Globals.controller.GetPreparations();
                if (MessageBox.Show("Транзакция проведена успешно. Закрыть чек?", "Успех", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    form_check.Close();
                }
            }
           // Globals.controller.SellPrepare(213, long.Parse(dataGV.CurrentRow.Cells[0].Value.ToString()));
           
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            dataGV.DataSource = Globals.controller.GetPreparations();
            if (tbSearch.Text.Length == 0)
            {
                return;
            }
            //DataTable table = (DataTable)dataGV.DataSource;
            for (int i = 0; i < dataGV.Rows.Count; i++)
            {
                if (!dataGV.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    dataGV.Rows.RemoveAt(i);
                    i--;
                }
            }
           // dataGV.DataSource = table;
        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //is tab 'history'
            if(e.TabPageIndex == 1)
            {
                dataGVHistory.DataSource = Globals.controller.GetSalesHistory(timePickerFrom.Value, timePickerTo.Value);
            }
        }

        private void dataGVHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGVHistory.CurrentRow.Index >= 0)
                dataGVSellInf.DataSource = Globals.controller.GetSaleFullInfo(long.Parse(dataGVHistory.CurrentRow.Cells[1].Value.ToString()));
        }

        private void dataGVSellInf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVSellInf.CurrentRow.Index >= 0)
                dataGVRecept.DataSource = Globals.controller.GetReceptInfo(long.Parse(dataGVSellInf.CurrentRow.Cells[3].Value.ToString()));
        }
    }
}
