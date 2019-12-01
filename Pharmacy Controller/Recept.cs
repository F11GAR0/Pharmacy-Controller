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
    public struct ReceptData
    {
        public string family;
        public string name;
        public string patronymic;
        public string prep;
        public string date;
        public int recnumber;
    }
   
    public partial class Recept : MetroForm
    {
        public Recept()
        {
            InitializeComponent();
        }
        private ReceptData out_data;
        public Recept(string prepname, int rec_num)
        {
            InitializeComponent();
            tbPrep.Text = prepname;
            out_data = new ReceptData();
            tbRecNum.Text = rec_num.ToString();
        }
        private void pCheck_Click(object sender, EventArgs e)
        {
            Graphics pg = pCheck.CreateGraphics();
            Random r = new Random();
            pg.Clear(Color.White);
            pg.DrawString("lushinpharmacy", new Font("Consolas", 12, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.BlueViolet, new PointF(0, pCheck.Size.Height / 2));
            pg.DrawEllipse(Pens.BlueViolet, new Rectangle(0,0, pCheck.Size.Width, pCheck.Size.Height));
            for(int i = 0, f = r.Next(5,12); i < f; i++)
            {
                pg.DrawCurve(Pens.Black, new Point[] { new Point(r.Next(10, pCheck.Size.Width - 10), r.Next(10, pCheck.Size.Height - 10)), new Point(r.Next(10, pCheck.Size.Width - 10), r.Next(10, pCheck.Size.Height - 10)), new Point(r.Next(10, pCheck.Size.Width - 10), r.Next(10, pCheck.Size.Height - 10)) }, 2);
            }
            pg.Flush();
        }
        public ReceptData GetReceptData()
        {
            return out_data;
        }
        private void bConfirm_Click(object sender, EventArgs e)
        {
            if(tbPrep.Text.Length <= 0 ||
                tbRecNum.Text.Length <= 0 ||
                tbPatronymic.Text.Length <= 0 ||
                tbName.Text.Length <= 0 ||
                tbFamily.Text.Length <= 0 ||
                tbDate.Text.Length <= 0)
            {
                MessageBox.Show("Проверьте, заполнены ли все поля", "Ошибка");
                DialogResult = DialogResult.Cancel;
                return;
            }
            
            out_data.date = tbDate.Text;
            if(DateTime.Now > DateTime.Parse(out_data.date))
            {
                MessageBox.Show("Рецепт просрочен", "Ошибка");
                DialogResult = DialogResult.Cancel;
                return;
            }
            out_data.family = tbFamily.Text;
            out_data.name = tbName.Text;
            out_data.patronymic = tbPatronymic.Text;
            out_data.prep = tbPrep.Text;
            out_data.recnumber = int.Parse(tbRecNum.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
