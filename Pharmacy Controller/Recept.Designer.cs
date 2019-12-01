namespace Pharmacy_Controller
{
    partial class Recept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pCheck = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbFamily = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbPatronymic = new MetroFramework.Controls.MetroTextBox();
            this.tbPrep = new MetroFramework.Controls.MetroTextBox();
            this.tbDate = new MetroFramework.Controls.MetroTextBox();
            this.tbRecNum = new MetroFramework.Controls.MetroTextBox();
            this.bConfirm = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.bConfirm);
            this.metroPanel1.Controls.Add(this.tbRecNum);
            this.metroPanel1.Controls.Add(this.tbDate);
            this.metroPanel1.Controls.Add(this.tbPrep);
            this.metroPanel1.Controls.Add(this.tbPatronymic);
            this.metroPanel1.Controls.Add(this.tbName);
            this.metroPanel1.Controls.Add(this.tbFamily);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.pCheck);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(481, 227);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Фамилия:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Имя:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Отчество:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "На препарат:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(29, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "До:";
            // 
            // pCheck
            // 
            this.pCheck.Location = new System.Drawing.Point(378, 127);
            this.pCheck.Name = "pCheck";
            this.pCheck.Size = new System.Drawing.Size(100, 97);
            this.pCheck.TabIndex = 7;
            this.pCheck.TabStop = false;
            this.pCheck.Click += new System.EventHandler(this.pCheck_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(378, 10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "№ Рецепта:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(377, 105);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Печать:";
            // 
            // tbFamily
            // 
            this.tbFamily.Location = new System.Drawing.Point(115, 6);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(125, 23);
            this.tbFamily.TabIndex = 10;
            this.tbFamily.Text = "Лушин";
            this.tbFamily.UseStyleColors = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 23);
            this.tbName.TabIndex = 11;
            this.tbName.Text = "Александр";
            this.tbName.UseStyleColors = true;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(115, 64);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(125, 23);
            this.tbPatronymic.TabIndex = 12;
            this.tbPatronymic.Text = "Денисович";
            this.tbPatronymic.UseStyleColors = true;
            // 
            // tbPrep
            // 
            this.tbPrep.Location = new System.Drawing.Point(115, 167);
            this.tbPrep.Name = "tbPrep";
            this.tbPrep.Size = new System.Drawing.Size(257, 23);
            this.tbPrep.TabIndex = 13;
            this.tbPrep.UseStyleColors = true;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(115, 196);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(257, 23);
            this.tbDate.TabIndex = 14;
            this.tbDate.Text = "29.12.2020";
            this.tbDate.UseStyleColors = true;
            // 
            // tbRecNum
            // 
            this.tbRecNum.Location = new System.Drawing.Point(377, 35);
            this.tbRecNum.Name = "tbRecNum";
            this.tbRecNum.Size = new System.Drawing.Size(101, 23);
            this.tbRecNum.TabIndex = 15;
            this.tbRecNum.UseStyleColors = true;
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(377, 64);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(101, 23);
            this.bConfirm.TabIndex = 16;
            this.bConfirm.Text = "Подтвердить";
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // Recept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(527, 313);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Recept";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Рецепт";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pCheck;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbRecNum;
        private MetroFramework.Controls.MetroTextBox tbDate;
        private MetroFramework.Controls.MetroTextBox tbPrep;
        private MetroFramework.Controls.MetroTextBox tbPatronymic;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbFamily;
        private MetroFramework.Controls.MetroButton bConfirm;
    }
}