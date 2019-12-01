namespace Pharmacy_Controller
{
    partial class Check
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
            this.mainLB = new System.Windows.Forms.ListBox();
            this.lbCheckNum = new MetroFramework.Controls.MetroLabel();
            this.lSeller = new MetroFramework.Controls.MetroLabel();
            this.lDateSell = new MetroFramework.Controls.MetroLabel();
            this.lAboutSell = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mlSellDate = new MetroFramework.Controls.MetroLabel();
            this.mlFD = new MetroFramework.Controls.MetroLabel();
            this.mlCheckNum = new MetroFramework.Controls.MetroLabel();
            this.lFD = new MetroFramework.Controls.MetroLabel();
            this.lTotalPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.mlSeller = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLB
            // 
            this.mainLB.BackColor = System.Drawing.Color.White;
            this.mainLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainLB.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mainLB.FormattingEnabled = true;
            this.mainLB.ItemHeight = 15;
            this.mainLB.Location = new System.Drawing.Point(23, 179);
            this.mainLB.Name = "mainLB";
            this.mainLB.Size = new System.Drawing.Size(290, 242);
            this.mainLB.TabIndex = 0;
            this.mainLB.DoubleClick += new System.EventHandler(this.mainLB_DoubleClick);
            // 
            // lbCheckNum
            // 
            this.lbCheckNum.AutoSize = true;
            this.lbCheckNum.Location = new System.Drawing.Point(2, 2);
            this.lbCheckNum.Name = "lbCheckNum";
            this.lbCheckNum.Size = new System.Drawing.Size(84, 19);
            this.lbCheckNum.TabIndex = 1;
            this.lbCheckNum.Text = "Номер чека:";
            // 
            // lSeller
            // 
            this.lSeller.AutoSize = true;
            this.lSeller.Location = new System.Drawing.Point(2, 21);
            this.lSeller.Name = "lSeller";
            this.lSeller.Size = new System.Drawing.Size(54, 19);
            this.lSeller.TabIndex = 2;
            this.lSeller.Text = "Кассир:";
            // 
            // lDateSell
            // 
            this.lDateSell.AutoSize = true;
            this.lDateSell.Location = new System.Drawing.Point(3, 40);
            this.lDateSell.Name = "lDateSell";
            this.lDateSell.Size = new System.Drawing.Size(99, 19);
            this.lDateSell.TabIndex = 3;
            this.lDateSell.Text = "Дата продажи:";
            // 
            // lAboutSell
            // 
            this.lAboutSell.AutoSize = true;
            this.lAboutSell.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lAboutSell.Location = new System.Drawing.Point(23, 157);
            this.lAboutSell.Name = "lAboutSell";
            this.lAboutSell.Size = new System.Drawing.Size(113, 19);
            this.lAboutSell.TabIndex = 4;
            this.lAboutSell.Text = "Список товаров:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.mlSeller);
            this.metroPanel1.Controls.Add(this.mlSellDate);
            this.metroPanel1.Controls.Add(this.mlFD);
            this.metroPanel1.Controls.Add(this.mlCheckNum);
            this.metroPanel1.Controls.Add(this.lFD);
            this.metroPanel1.Controls.Add(this.lTotalPrice);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lDateSell);
            this.metroPanel1.Controls.Add(this.lSeller);
            this.metroPanel1.Controls.Add(this.lbCheckNum);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 53);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(290, 101);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseEnter += new System.EventHandler(this.metroPanel1_MouseEnter);
            this.metroPanel1.MouseLeave += new System.EventHandler(this.metroPanel1_MouseLeave);
            // 
            // mlSellDate
            // 
            this.mlSellDate.AutoSize = true;
            this.mlSellDate.Location = new System.Drawing.Point(161, 40);
            this.mlSellDate.Name = "mlSellDate";
            this.mlSellDate.Size = new System.Drawing.Size(16, 19);
            this.mlSellDate.TabIndex = 11;
            this.mlSellDate.Text = "0";
            // 
            // mlFD
            // 
            this.mlFD.AutoSize = true;
            this.mlFD.Location = new System.Drawing.Point(161, 58);
            this.mlFD.Name = "mlFD";
            this.mlFD.Size = new System.Drawing.Size(16, 19);
            this.mlFD.TabIndex = 10;
            this.mlFD.Text = "0";
            // 
            // mlCheckNum
            // 
            this.mlCheckNum.AutoSize = true;
            this.mlCheckNum.Location = new System.Drawing.Point(161, 2);
            this.mlCheckNum.Name = "mlCheckNum";
            this.mlCheckNum.Size = new System.Drawing.Size(16, 19);
            this.mlCheckNum.TabIndex = 9;
            this.mlCheckNum.Text = "0";
            // 
            // lFD
            // 
            this.lFD.AutoSize = true;
            this.lFD.Location = new System.Drawing.Point(3, 58);
            this.lFD.Name = "lFD";
            this.lFD.Size = new System.Drawing.Size(31, 19);
            this.lFD.TabIndex = 8;
            this.lFD.Text = "ФД:";
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Location = new System.Drawing.Point(183, 77);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(0, 0);
            this.lTotalPrice.TabIndex = 7;
            this.lTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Итого: ";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // mlSeller
            // 
            this.mlSeller.AutoSize = true;
            this.mlSeller.Location = new System.Drawing.Point(161, 21);
            this.mlSeller.Name = "mlSeller";
            this.mlSeller.Size = new System.Drawing.Size(15, 19);
            this.mlSeller.TabIndex = 12;
            this.mlSeller.Text = "-";
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(336, 443);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lAboutSell);
            this.Controls.Add(this.mainLB);
            this.Name = "Check";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Чек";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainLB;
        private MetroFramework.Controls.MetroLabel lbCheckNum;
        private MetroFramework.Controls.MetroLabel lSeller;
        private MetroFramework.Controls.MetroLabel lDateSell;
        private MetroFramework.Controls.MetroLabel lAboutSell;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private MetroFramework.Controls.MetroLabel lTotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lFD;
        private MetroFramework.Controls.MetroLabel mlSellDate;
        private MetroFramework.Controls.MetroLabel mlFD;
        private MetroFramework.Controls.MetroLabel mlCheckNum;
        private MetroFramework.Controls.MetroLabel mlSeller;
    }
}