namespace JSuperMarket.Forms.Rpt_Sales
{
    partial class FrmSalesReport
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
            this.jscDataGrid1 = new JSuperMarket.Utility.JSCDataGrid();
            this.YearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRptSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // jscDataGrid1
            // 
            this.jscDataGrid1.AllowUserToOrderColumns = true;
            this.jscDataGrid1.AllowUserToResizeColumns = false;
            this.jscDataGrid1.AllowUserToResizeRows = false;
            this.jscDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.jscDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jscDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jscDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YearName,
            this.MonthName,
            this.DayName,
            this.TotalSale});
            this.jscDataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = false;
            this.jscDataGrid1.Location = new System.Drawing.Point(12, 78);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(535, 298);
            this.jscDataGrid1.TabIndex = 1;
            // 
            // YearName
            // 
            this.YearName.DataPropertyName = "Year";
            this.YearName.HeaderText = "سال";
            this.YearName.Name = "YearName";
            this.YearName.ReadOnly = true;
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "Month";
            this.MonthName.HeaderText = "ماه";
            this.MonthName.Name = "MonthName";
            this.MonthName.ReadOnly = true;
            // 
            // DayName
            // 
            this.DayName.DataPropertyName = "Day";
            this.DayName.HeaderText = "روز";
            this.DayName.Name = "DayName";
            this.DayName.ReadOnly = true;
            // 
            // TotalSale
            // 
            this.TotalSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSale.DataPropertyName = "TotalSales";
            this.TotalSale.HeaderText = "فروش کل";
            this.TotalSale.Name = "TotalSale";
            this.TotalSale.ReadOnly = true;
            // 
            // btnRptSales
            // 
            this.btnRptSales.Location = new System.Drawing.Point(12, 39);
            this.btnRptSales.Name = "btnRptSales";
            this.btnRptSales.Size = new System.Drawing.Size(535, 33);
            this.btnRptSales.TabIndex = 2;
            this.btnRptSales.Text = "گزارش فروش بر اساس روز";
            this.btnRptSales.UseVisualStyleBackColor = true;
            this.btnRptSales.Click += new System.EventHandler(this.BtnRptSalesClick);
            // 
            // FrmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.ClientSize = new System.Drawing.Size(559, 388);
            this.Controls.Add(this.btnRptSales);
            this.Controls.Add(this.jscDataGrid1);
            this.Name = "FrmSalesReport";
            this.Load += new System.EventHandler(this.FrmSalesReportLoad);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.btnRptSales, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.JSCDataGrid jscDataGrid1;
        private System.Windows.Forms.Button btnRptSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSale;
    }
}
