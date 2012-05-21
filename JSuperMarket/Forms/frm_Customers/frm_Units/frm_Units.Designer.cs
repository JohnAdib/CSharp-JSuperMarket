using JSuperMarket.Utility;

namespace JSuperMarket.frm_Units
{
    partial class FrmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnits));
            this.jscDataGrid1 = new JSCDataGrid();
            this.jscHome1 = new JSCHome();
            this.lblFormTitle = new JSCLabel();
            this.jscDelete1 = new JSCDelete();
            this.jscAdd2 = new JSCAdd();
            this.jscUpdate1 = new JSCUpdate();
            this.ProductsUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ProductsUnitID,
            this.ProductsUnit});
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = true;
            this.jscDataGrid1.Location = new System.Drawing.Point(108, 38);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.ReadOnly = true;
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(185, 241);
            this.jscDataGrid1.StandardTab = true;
            this.jscDataGrid1.TabIndex = 1;
            this.jscDataGrid1.VirtualMode = true;
            this.jscDataGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JSCDataGrid1KeyDown);
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(7, 244);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 35);
            this.jscHome1.TabIndex = 5;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JSCHome1Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.lblFormTitle.Location = new System.Drawing.Point(23, 38);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(65, 48);
            this.lblFormTitle.TabIndex = 21;
            this.lblFormTitle.Text = "واحد  کالاها";
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(7, 195);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 35);
            this.jscDelete1.TabIndex = 4;
            this.jscDelete1.Text = "حذف";
            this.jscDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscDelete1.UseVisualStyleBackColor = false;
            this.jscDelete1.Click += new System.EventHandler(this.JSCDelete1Click);
            // 
            // jscAdd2
            // 
            this.jscAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd2.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd2.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd2.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd2.Image")));
            this.jscAdd2.Location = new System.Drawing.Point(7, 97);
            this.jscAdd2.Name = "jscAdd2";
            this.jscAdd2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd2.Size = new System.Drawing.Size(95, 35);
            this.jscAdd2.TabIndex = 2;
            this.jscAdd2.Text = "اضافه کردن";
            this.jscAdd2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd2.UseVisualStyleBackColor = false;
            this.jscAdd2.Click += new System.EventHandler(this.JSCAdd2Click);
            // 
            // jscUpdate1
            // 
            this.jscUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.jscUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscUpdate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.jscUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("jscUpdate1.Image")));
            this.jscUpdate1.Location = new System.Drawing.Point(7, 146);
            this.jscUpdate1.Name = "jscUpdate1";
            this.jscUpdate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscUpdate1.Size = new System.Drawing.Size(95, 35);
            this.jscUpdate1.TabIndex = 3;
            this.jscUpdate1.Text = "به روزرسانی";
            this.jscUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscUpdate1.UseVisualStyleBackColor = false;
            this.jscUpdate1.Click += new System.EventHandler(this.JSCUpdate1Click);
            // 
            // ProductsUnitID
            // 
            this.ProductsUnitID.DataPropertyName = "ProductsUnitID";
            this.ProductsUnitID.HeaderText = "کد واحد";
            this.ProductsUnitID.Name = "ProductsUnitID";
            this.ProductsUnitID.ReadOnly = true;
            this.ProductsUnitID.Visible = false;
            // 
            // ProductsUnit
            // 
            this.ProductsUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductsUnit.DataPropertyName = "ProductsUnit";
            this.ProductsUnit.HeaderText = "واحد کالاها";
            this.ProductsUnit.Name = "ProductsUnit";
            this.ProductsUnit.ReadOnly = true;
            // 
            // frm_Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(305, 295);
            this.Controls.Add(this.jscUpdate1);
            this.Controls.Add(this.jscAdd2);
            this.Controls.Add(this.jscDelete1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.jscDataGrid1);
            this.Controls.Add(this.jscHome1);
            this.KeyPreview = true;
            this.Name = "FrmUnits";
            this.Load += new System.EventHandler(this.FrmUnitsLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUnitsKeyDown);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscAdd2, 0);
            this.Controls.SetChildIndex(this.jscUpdate1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCDataGrid jscDataGrid1;
        private JSCHome jscHome1;
        private JSCLabel lblFormTitle;
        private JSCDelete jscDelete1;
        private JSCAdd jscAdd2;
        private JSCUpdate jscUpdate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsUnit;
    }
}
