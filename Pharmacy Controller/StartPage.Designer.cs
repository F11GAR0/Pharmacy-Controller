namespace Pharmacy_Controller
{
    partial class StartPageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bOpenBase = new MetroFramework.Controls.MetroButton();
            this.bOpenLastBase = new MetroFramework.Controls.MetroButton();
            this.lLastDBFile = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.tbSellerID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpenBase
            // 
            this.bOpenBase.Location = new System.Drawing.Point(23, 95);
            this.bOpenBase.Name = "bOpenBase";
            this.bOpenBase.Size = new System.Drawing.Size(286, 23);
            this.bOpenBase.TabIndex = 0;
            this.bOpenBase.Text = "Открыть новую базу данных";
            this.bOpenBase.Click += new System.EventHandler(this.bOpenBase_Click);
            // 
            // bOpenLastBase
            // 
            this.bOpenLastBase.Location = new System.Drawing.Point(23, 124);
            this.bOpenLastBase.Name = "bOpenLastBase";
            this.bOpenLastBase.Size = new System.Drawing.Size(286, 23);
            this.bOpenLastBase.TabIndex = 1;
            this.bOpenLastBase.Text = "Открыть последнюю базу данных";
            this.bOpenLastBase.Click += new System.EventHandler(this.bOpenLastBase_Click);
            // 
            // lLastDBFile
            // 
            this.lLastDBFile.AutoSize = true;
            this.lLastDBFile.Location = new System.Drawing.Point(23, 150);
            this.lLastDBFile.Name = "lLastDBFile";
            this.lLastDBFile.Size = new System.Drawing.Size(97, 19);
            this.lLastDBFile.TabIndex = 2;
            this.lLastDBFile.Text = "Последняя бд:";
            this.lLastDBFile.MouseEnter += new System.EventHandler(this.lLastDBFile_MouseEnter);
            this.lLastDBFile.MouseLeave += new System.EventHandler(this.lLastDBFile_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbSellerID
            // 
            this.tbSellerID.Location = new System.Drawing.Point(106, 59);
            this.tbSellerID.MaxLength = 2;
            this.tbSellerID.Name = "tbSellerID";
            this.tbSellerID.PromptText = "00";
            this.tbSellerID.Size = new System.Drawing.Size(203, 23);
            this.tbSellerID.TabIndex = 3;
            this.tbSellerID.Text = "1";
            this.tbSellerID.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ID Кассира:";
            this.metroLabel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StartPageForm_MouseClick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // StartPageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 180);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbSellerID);
            this.Controls.Add(this.lLastDBFile);
            this.Controls.Add(this.bOpenLastBase);
            this.Controls.Add(this.bOpenBase);
            this.MaximizeBox = false;
            this.Name = "StartPageForm";
            this.Resizable = false;
            this.Text = "Стартовая страница";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.StartPageForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.StartPageForm_DragEnter);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StartPageForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bOpenBase;
        private MetroFramework.Controls.MetroButton bOpenLastBase;
        private MetroFramework.Controls.MetroLabel lLastDBFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTextBox tbSellerID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

