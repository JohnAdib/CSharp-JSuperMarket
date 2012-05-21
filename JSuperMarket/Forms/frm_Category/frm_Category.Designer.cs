using JSuperMarket.Utility;

namespace JSuperMarket
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.jscAdd1 = new JSCAdd();
            this.jscUpdate1 = new JSCUpdate();
            this.jscDelete1 = new JSCDelete();
            this.jscHome1 = new JSCHome();
            this.jscDataGrid1 = new JSCDataGrid();
            this.jscLabel1 = new JSCLabel();
            this.ProductCategor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(12, 98);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 35);
            this.jscAdd1.TabIndex = 7;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.JSCAdd1Click);
            // 
            // jscUpdate1
            // 
            this.jscUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.jscUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscUpdate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.jscUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("jscUpdate1.Image")));
            this.jscUpdate1.Location = new System.Drawing.Point(12, 147);
            this.jscUpdate1.Name = "jscUpdate1";
            this.jscUpdate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscUpdate1.Size = new System.Drawing.Size(95, 35);
            this.jscUpdate1.TabIndex = 8;
            this.jscUpdate1.Text = "به روزرسانی";
            this.jscUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscUpdate1.UseVisualStyleBackColor = false;
            this.jscUpdate1.Click += new System.EventHandler(this.JSCUpdate1Click);
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(12, 196);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 35);
            this.jscDelete1.TabIndex = 9;
            this.jscDelete1.Text = "حذف";
            this.jscDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscDelete1.UseVisualStyleBackColor = false;
            this.jscDelete1.Click += new System.EventHandler(this.JSCDelete1Click);
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(12, 245);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 35);
            this.jscHome1.TabIndex = 10;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JSCHome1Click);
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
            this.ProductCategor,
            this.ProductCategoryID});
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = true;
            this.jscDataGrid1.Location = new System.Drawing.Point(113, 39);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.ReadOnly = true;
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(196, 241);
            this.jscDataGrid1.StandardTab = true;
            this.jscDataGrid1.TabIndex = 11;
            this.jscDataGrid1.VirtualMode = true;
            this.jscDataGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JSCDataGrid1KeyDown);
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.jscLabel1.Location = new System.Drawing.Point(13, 39);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(95, 48);
            this.jscLabel1.TabIndex = 21;
            this.jscLabel1.Text = "دسته بندی اصلی";
            // 
            // ProductCategor
            // 
            this.ProductCategor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategor.DataPropertyName = "ProductCategory";
            this.ProductCategor.HeaderText = "دسته بندی اصلی";
            this.ProductCategor.Name = "ProductCategor";
            this.ProductCategor.ReadOnly = true;
            // 
            // ProductCategoryID
            // 
            this.ProductCategoryID.DataPropertyName = "ProductCategoryID";
            this.ProductCategoryID.HeaderText = "کد دسته ";
            this.ProductCategoryID.Name = "ProductCategoryID";
            this.ProductCategoryID.ReadOnly = true;
            this.ProductCategoryID.Visible = false;
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(321, 294);
            this.Controls.Add(this.jscLabel1);
            this.Controls.Add(this.jscDataGrid1);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.jscDelete1);
            this.Controls.Add(this.jscUpdate1);
            this.Controls.Add(this.jscAdd1);
            this.KeyPreview = true;
            this.Name = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategoryLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCategoryKeyDown);
            this.Controls.SetChildIndex(this.jscAdd1, 0);
            this.Controls.SetChildIndex(this.jscUpdate1, 0);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.jscLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCAdd jscAdd1;
        private JSCUpdate jscUpdate1;
        private JSCDelete jscDelete1;
        private JSCHome jscHome1;
        private JSCDataGrid jscDataGrid1;
        private JSCLabel jscLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryID;
    }
}
