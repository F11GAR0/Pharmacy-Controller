using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Pharmacy_Controller
{
    public struct listItem
    {
        public string name;
        public int count;
        public double price;
        public long id_in_table;
        public int recept_id;
        public receptData recept;
    }
    public struct receptData
    {
        public string fio;
        public string end_date;
        public string prep_name;

        public receptData(string v, string date, string prep) : this()
        {
            this.fio = v;
            this.end_date = date;
            this.prep_name = prep;
        }
    }
    public partial class Check : MetroForm
    {
        public Check()
        {
            InitializeComponent();
        }
        public string GetSpaces(int c)
        {
            string ret = "";
            for(int i = 0; i < c; i++)
            {
                ret += " ";
            }
            return ret;
        }
        private int check_id;
        public int GetCheckId()
        {
            return check_id;
        }
        public Check(int check_num, int fd)
        {
            InitializeComponent();
            check_id = check_num;
            mlFD.Text = fd.ToString();
            mlCheckNum.Text = check_num.ToString();
            mlSellDate.Text = DateTime.Now.ToString().ToString();
            string[] sp = Globals.seller_fio.Split(' ');
            mlSeller.Text = sp[1] + " " + sp[0][0].ToString() + "." + sp[2][0].ToString() + ".";
        }
        private List<listItem> items = new List<listItem>();
        public List<listItem> GetSellList()
        {
            return items;
        }
        private int GetCountOfItem(string name)
        {
            foreach(var i in items)
            {
                if(i.name == name)
                {
                    return i.count;
                }
            }
            return -1;
        }
        private int IncItemCount(string name, double price)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    listItem item;
                    item.name = name;
                    item.price = items[i].price + price;
                    item.count = items[i].count + 1;
                    item.id_in_table = items[i].id_in_table;
                    item.recept_id = items[i].recept_id;
                    item.recept = items[i].recept;
                    items[i] = item;
                    return 1;
                }
            }
            return -1;
        }
        public void RedrawList()
        {
            mainLB.Items.Clear();
            double total = 0;
            foreach(var i in items)
            {
                total += i.price;
                mainLB.Items.Add((i.name + "....." + i.count + "x = " + i.price).ToString());
            }
            lTotalPrice.Text = total.ToString() + "р.";
        }
        public void AddItem(long id, string name, double price, int recept_number, receptData rdata, int count)
        {
            if(count <= GetCountOfItem(name) || count <= 0)
            {
                MessageBox.Show("Ошибка, товаров не осталось на складе", "Error");
                return;
            }
            if(IncItemCount(name, price) < 0)
            {
                
                listItem item;
                item.name = name;
                item.count = 1;
                item.price = price;
                item.id_in_table = id;
                item.recept_id = recept_number;
                item.recept = rdata;
                items.Add(item);
            }
            RedrawList();
        }
        //bad algorithm, sorry
        public void RemoveItem(string name)
        {
            List<listItem> new_list = new List<listItem>();
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].name != name)
                    new_list.Add(items[i]);
            }
            items = new_list;
            RedrawList();
        }
        private void metroPanel1_MouseEnter(object sender, EventArgs e)
        {
            metroToolTip1.Show("Нажмите чтобы распечатать чек.", (IWin32Window)sender);
        }

        private void metroPanel1_MouseLeave(object sender, EventArgs e)
        {
            metroToolTip1.Hide((IWin32Window)sender);
        }

        private void mainLB_DoubleClick(object sender, EventArgs e)
        {
            if (mainLB.SelectedIndex == -1) return;
            if(MessageBox.Show("Вы действительно хотите убрать этот товар?", "Warning",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                RemoveItem(items[mainLB.SelectedIndex].name);
            }
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.form_check_inited = false;
        }
    }
}
