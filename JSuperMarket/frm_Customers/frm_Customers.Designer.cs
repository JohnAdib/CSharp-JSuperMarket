namespace JSuperMarket.frm_Customers
{
    partial class frm_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customers));
            this.jscDataGrid1 = new JSuperMarket.JSCDataGrid();
            this.jscAdd1 = new JSuperMarket.JSCAdd();
            this.jscUpdate1 = new JSuperMarket.JSCUpdate();
            this.jscDelete1 = new JSuperMarket.JSCDelete();
            this.jscHome1 = new JSuperMarket.JSCHome();
            this.lblFormTitle = new JSuperMarket.JSCLabel();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // jscDataGrid1
            // 
            this.jscDataGrid1.AllowUserToAddRows = false;
            this.jscDataGrid1.AllowUserToDeleteRows = false;
            this.jscDataGrid1.AllowUserToOrderColumns = true;
            this.jscDataGrid1.AllowUserToResizeColumns = false;
            this.jscDataGrid1.AllowUserToResizeRows = false;
            this.jscDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.jscDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jscDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jscDataGrid1.ColumnHeadersVisible = false;
            this.jscDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.Credit,
            this.CAddress,
            this.CTel,
            this.CMobile,
            this.CDesc});
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.Location = new System.Drawing.Point(111, 39);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.ReadOnly = true;
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(576, 273);
            this.jscDataGrid1.StandardTab = true;
            this.jscDataGrid1.TabIndex = 1;
            this.jscDataGrid1.VirtualMode = true;
            this.jscDataGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jscDataGrid1_KeyDown);
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(10, 106);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 35);
            this.jscAdd1.TabIndex = 2;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.jscAdd1_Click);
            // 
            // jscUpdate1
            // 
            this.jscUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.jscUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscUpdate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.jscUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("jscUpdate1.Image")));
            this.jscUpdate1.Location = new System.Drawing.Point(10, 163);
            this.jscUpdate1.Name = "jscUpdate1";
            this.jscUpdate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscUpdate1.Size = new System.Drawing.Size(95, 35);
            this.jscUpdate1.TabIndex = 3;
            this.jscUpdate1.Text = "به روزرسانی";
            this.jscUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscUpdate1.UseVisualStyleBackColor = false;
            this.jscUpdate1.Click += new System.EventHandler(this.jscUpdate1_Click);
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(10, 220);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 35);
            this.jscDelete1.TabIndex = 4;
            this.jscDelete1.Text = "حذف";
            this.jscDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscDelete1.UseVisualStyleBackColor = false;
            this.jscDelete1.Click += new System.EventHandler(this.jscDelete1_Click);
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(10, 277);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 35);
            this.jscHome1.TabIndex = 5;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.jscHome1_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.lblFormTitle.Location = new System.Drawing.Point(26, 39);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(61, 48);
            this.lblFormTitle.TabIndex = 23;
            this.lblFormTitle.Text = "مشتریان";
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "نام مشتری";
            this.CName.MinimumWidth = 150;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "نسیه";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Credit.TrueValue = "";
            this.Credit.Width = 30;
            // 
            // CAddress
            // 
            this.CAddress.DataPropertyName = "CAddress";
            this.CAddress.HeaderText = "آدرس";
            this.CAddress.Name = "CAddress";
            this.CAddress.ReadOnly = true;
            // 
            // CTel
            // 
            this.CTel.DataPropertyName = "CTel";
            this.CTel.HeaderText = "تلفن";
            this.CTel.Name = "CTel";
            this.CTel.ReadOnly = true;
            this.CTel.Width = 70;
            // 
            // CMobile
            // 
            this.CMobile.DataPropertyName = "CMobile";
            this.CMobile.HeaderText = "موبایل";
            this.CMobile.Name = "CMobile";
            this.CMobile.ReadOnly = true;
            this.CMobile.Width = 70;
            // 
            // CDesc
            // 
            this.CDesc.DataPropertyName = "CDesc";
            this.CDesc.HeaderText = "توضیح";
            this.CDesc.MinimumWidth = 70;
            this.CDesc.Name = "CDesc";
            this.CDesc.ReadOnly = true;
            this.CDesc.Width = 70;
            // 
            // frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(699, 323);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.jscDelete1);
            this.Controls.Add(this.jscUpdate1);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.jscDataGrid1);
            this.Name = "frm_Customers";
            this.Load += new System.EventHandler(this.frm_Customers_Load);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.jscAdd1, 0);
            this.Controls.SetChildIndex(this.jscUpdate1, 0);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCDataGrid jscDataGrid1;
        private JSCAdd jscAdd1;
        private JSCUpdate jscUpdate1;
        private JSCDelete jscDelete1;
        private JSCHome jscHome1;
        private JSCLabel lblFormTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDesc;
    }
}
