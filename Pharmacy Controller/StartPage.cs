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
using System.IO;

namespace Pharmacy_Controller
{
    public partial class StartPageForm : MetroForm
    {
        public StartPageForm()
        {
            Globals.cfg = new Config();       
            InitializeComponent();
            lLastDBFile.Text += Globals.cfg.last_bd_path;
            Globals.start_page_form = this;
            Globals.ClearLogfile();
            Globals.Log("Starting new session");
        }
        private void StartPageForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
        }

        private void OpenBase(string path)
        {
            Globals.bdpath = path;
            Globals.cfg.UpdateParam("last_bd_path", Globals.bdpath);
            Globals.cfg.last_bd_path = Globals.bdpath;
            if (!(char.IsNumber(tbSellerID.Text[0]) && (tbSellerID.Text.Length > 1) ? char.IsNumber(tbSellerID.Text[1]) : true))
            {
                MessageBox.Show("Ошибка, введённый ID Кассира не является числом");
                return;
            }
            Globals.seller_id = int.Parse(tbSellerID.Text);
            lLastDBFile.Text = "Последняя бд:" + Globals.bdpath;
            DBController controller_form = new DBController();
            if ((object)controller_form != null)
            {
                try
                {
                    controller_form.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Globals.Log(ex.Message);
                }
            }
        }


        private void StartPageForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (objects.Length > 1)
                {
                    MessageBox.Show("U can drag only one file!", "Warning!");
                    return;
                }
                if(objects.Length < 1)
                {
                    return;
                }
                if (File.Exists(objects[0]))
                {
                    OpenBase(objects[0]);
                }
            }
        }

        private void bOpenLastBase_Click(object sender, EventArgs e)
        {
            if(Globals.cfg.last_bd_path != "&0")
            {
                if (File.Exists(Globals.cfg.last_bd_path))
                {
                    OpenBase(Globals.cfg.last_bd_path);
                } else
                {
                    Globals.Log("Error opening bd, file does not exists:" + Globals.cfg.last_bd_path);
                    MessageBox.Show("Error, file does not exists!", "Error");
                }
            } else
            {
                Globals.Log("Error opening last base, cuz last_bd_path = &0");
                MessageBox.Show("Error opening last base, path = &0", "Error");
            }
        }

        private void bOpenBase_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenBase(openFileDialog1.FileName);
            }                     
        }

        private void lLastDBFile_MouseEnter(object sender, EventArgs e)
        {
            metroToolTip1.Show(lLastDBFile.Text, this.lLastDBFile);
        }

        private void lLastDBFile_MouseLeave(object sender, EventArgs e)
        {
            metroToolTip1.Hide(this.lLastDBFile);
        }

        bool changed = false;

        private void StartPageForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!changed)
            {
                metroStyleManager1.Owner = this;
                metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                metroStyleManager1.Owner = this;
                metroStyleManager1.Style = MetroFramework.MetroColorStyle.Default;
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            changed ^= true;
            this.Refresh();
        }
    }
}
