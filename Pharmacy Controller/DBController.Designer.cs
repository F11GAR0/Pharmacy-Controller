namespace Pharmacy_Controller
{
    partial class DBController
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.pageSellController = new MetroFramework.Controls.MetroTabPage();
            this.bAddToQueue = new MetroFramework.Controls.MetroButton();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.bSell = new MetroFramework.Controls.MetroButton();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.pageHistoryView = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGVRecept = new System.Windows.Forms.DataGridView();
            this.dataGVSellInf = new System.Windows.Forms.DataGridView();
            this.dataGVHistory = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.pageSellController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.pageHistoryView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSellInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.pageSellController);
            this.metroTabControl1.Controls.Add(this.pageHistoryView);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 33);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(908, 488);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // pageSellController
            // 
            this.pageSellController.Controls.Add(this.bAddToQueue);
            this.pageSellController.Controls.Add(this.tbSearch);
            this.pageSellController.Controls.Add(this.bSell);
            this.pageSellController.Controls.Add(this.dataGV);
            this.pageSellController.HorizontalScrollbarBarColor = true;
            this.pageSellController.Location = new System.Drawing.Point(4, 35);
            this.pageSellController.Name = "pageSellController";
            this.pageSellController.Size = new System.Drawing.Size(900, 449);
            this.pageSellController.TabIndex = 0;
            this.pageSellController.Text = "Управление продажами";
            this.pageSellController.VerticalScrollbarBarColor = true;
            // 
            // bAddToQueue
            // 
            this.bAddToQueue.Location = new System.Drawing.Point(5, 422);
            this.bAddToQueue.Name = "bAddToQueue";
            this.bAddToQueue.Size = new System.Drawing.Size(124, 23);
            this.bAddToQueue.TabIndex = 9;
            this.bAddToQueue.Text = "Добавить в очередь";
            this.bAddToQueue.Click += new System.EventHandler(this.bAddToQueue_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(276, 422);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(620, 23);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.UseStyleColors = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_Click);
            // 
            // bSell
            // 
            this.bSell.Location = new System.Drawing.Point(135, 422);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(135, 23);
            this.bSell.TabIndex = 6;
            this.bSell.Text = "Продать";
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AllowUserToResizeRows = false;
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGV.EnableHeadersVisualStyles = false;
            this.dataGV.GridColor = System.Drawing.Color.White;
            this.dataGV.Location = new System.Drawing.Point(5, 3);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGV.Size = new System.Drawing.Size(891, 414);
            this.dataGV.TabIndex = 5;
            // 
            // pageHistoryView
            // 
            this.pageHistoryView.Controls.Add(this.metroLabel4);
            this.pageHistoryView.Controls.Add(this.metroLabel3);
            this.pageHistoryView.Controls.Add(this.timePickerTo);
            this.pageHistoryView.Controls.Add(this.timePickerFrom);
            this.pageHistoryView.Controls.Add(this.metroLabel2);
            this.pageHistoryView.Controls.Add(this.metroLabel1);
            this.pageHistoryView.Controls.Add(this.dataGVRecept);
            this.pageHistoryView.Controls.Add(this.dataGVSellInf);
            this.pageHistoryView.Controls.Add(this.dataGVHistory);
            this.pageHistoryView.HorizontalScrollbarBarColor = true;
            this.pageHistoryView.Location = new System.Drawing.Point(4, 35);
            this.pageHistoryView.Name = "pageHistoryView";
            this.pageHistoryView.Size = new System.Drawing.Size(900, 449);
            this.pageHistoryView.TabIndex = 1;
            this.pageHistoryView.Text = "История продаж";
            this.pageHistoryView.VerticalScrollbarBarColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(253, 430);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(29, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "До:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 430);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "От:";
            // 
            // timePickerTo
            // 
            this.timePickerTo.Location = new System.Drawing.Point(288, 429);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.Size = new System.Drawing.Size(152, 20);
            this.timePickerTo.TabIndex = 12;
            this.timePickerTo.Value = new System.DateTime(2019, 12, 31, 12, 53, 0, 0);
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.Location = new System.Drawing.Point(37, 429);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.Size = new System.Drawing.Size(152, 20);
            this.timePickerFrom.TabIndex = 11;
            this.timePickerFrom.Value = new System.DateTime(2019, 11, 25, 12, 52, 0, 0);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(460, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(160, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Информация о рецепте:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(460, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Информация о продаже:";
            // 
            // dataGVRecept
            // 
            this.dataGVRecept.AllowUserToAddRows = false;
            this.dataGVRecept.AllowUserToDeleteRows = false;
            this.dataGVRecept.AllowUserToResizeRows = false;
            this.dataGVRecept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVRecept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVRecept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGVRecept.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVRecept.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGVRecept.EnableHeadersVisualStyles = false;
            this.dataGVRecept.GridColor = System.Drawing.Color.White;
            this.dataGVRecept.Location = new System.Drawing.Point(460, 240);
            this.dataGVRecept.Name = "dataGVRecept";
            this.dataGVRecept.ReadOnly = true;
            this.dataGVRecept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVRecept.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGVRecept.Size = new System.Drawing.Size(437, 206);
            this.dataGVRecept.TabIndex = 8;
            // 
            // dataGVSellInf
            // 
            this.dataGVSellInf.AllowUserToAddRows = false;
            this.dataGVSellInf.AllowUserToDeleteRows = false;
            this.dataGVSellInf.AllowUserToResizeRows = false;
            this.dataGVSellInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVSellInf.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVSellInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGVSellInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVSellInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVSellInf.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGVSellInf.EnableHeadersVisualStyles = false;
            this.dataGVSellInf.GridColor = System.Drawing.Color.White;
            this.dataGVSellInf.Location = new System.Drawing.Point(460, 25);
            this.dataGVSellInf.Name = "dataGVSellInf";
            this.dataGVSellInf.ReadOnly = true;
            this.dataGVSellInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVSellInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGVSellInf.Size = new System.Drawing.Size(437, 190);
            this.dataGVSellInf.TabIndex = 7;
            this.dataGVSellInf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVSellInf_CellClick);
            // 
            // dataGVHistory
            // 
            this.dataGVHistory.AllowUserToAddRows = false;
            this.dataGVHistory.AllowUserToDeleteRows = false;
            this.dataGVHistory.AllowUserToResizeRows = false;
            this.dataGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGVHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVHistory.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGVHistory.EnableHeadersVisualStyles = false;
            this.dataGVHistory.GridColor = System.Drawing.Color.White;
            this.dataGVHistory.Location = new System.Drawing.Point(3, 3);
            this.dataGVHistory.Name = "dataGVHistory";
            this.dataGVHistory.ReadOnly = true;
            this.dataGVHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGVHistory.Size = new System.Drawing.Size(437, 417);
            this.dataGVHistory.TabIndex = 6;
            this.dataGVHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHistory_CellDoubleClick);
            this.dataGVHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHistory_CellDoubleClick);
            // 
            // DBController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 523);
            this.Controls.Add(this.metroTabControl1);
            this.DisplayHeader = false;
            this.Name = "DBController";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "DBController";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBController_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.pageSellController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.pageHistoryView.ResumeLayout(false);
            this.pageHistoryView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSellInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage pageSellController;
        private MetroFramework.Controls.MetroButton bAddToQueue;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroButton bSell;
        private System.Windows.Forms.DataGridView dataGV;
        private MetroFramework.Controls.MetroTabPage pageHistoryView;
        private System.Windows.Forms.DataGridView dataGVSellInf;
        private System.Windows.Forms.DataGridView dataGVHistory;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGVRecept;
    }
}