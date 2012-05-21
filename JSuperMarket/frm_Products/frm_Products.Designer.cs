namespace JSuperMarket.frm_Products
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            this.lblFormTitle = new JSuperMarket.JSCLabel();
            this.jscDataGrid1 = new JSuperMarket.JSCDataGrid();
            this.jscAdd1 = new JSuperMarket.JSCAdd();
            this.jscUpdate1 = new JSuperMarket.JSCUpdate();
            this.jscDelete1 = new JSuperMarket.JSCDelete();
            this.jscHome1 = new JSuperMarket.JSCHome();
            this.jscCmbCategory = new JSuperMarket.JSCComboBox();
            this.jscLabel1 = new JSuperMarket.JSCLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jscDataDesc = new JSuperMarket.JSCLabel();
            this.jscHighlightTimer = new JSuperMarket.JSCTimer();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMinInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.lblFormTitle.Location = new System.Drawing.Point(40, 39);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(41, 48);
            this.lblFormTitle.TabIndex = 24;
            this.lblFormTitle.Text = "کالاها";
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
            this.ProductID,
            this.PBarCode,
            this.PName,
            this.ProductCategory,
            this.ProductCategoryID,
            this.ProductsUnit,
            this.PSize,
            this.PPrice,
            this.PDiscount,
            this.PBuyPrice,
            this.PStock,
            this.PMinInventory,
            this.PManufacturer,
            this.PDesc});
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = true;
            this.jscDataGrid1.Location = new System.Drawing.Point(109, 112);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.ReadOnly = true;
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(840, 306);
            this.jscDataGrid1.StandardTab = true;
            this.jscDataGrid1.TabIndex = 1;
            this.jscDataGrid1.VirtualMode = true;
            this.jscDataGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JscDataGrid1KeyDown);
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(8, 112);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 35);
            this.jscAdd1.TabIndex = 26;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.JscAdd1Click);
            // 
            // jscUpdate1
            // 
            this.jscUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.jscUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscUpdate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.jscUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("jscUpdate1.Image")));
            this.jscUpdate1.Location = new System.Drawing.Point(8, 178);
            this.jscUpdate1.Name = "jscUpdate1";
            this.jscUpdate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscUpdate1.Size = new System.Drawing.Size(95, 35);
            this.jscUpdate1.TabIndex = 27;
            this.jscUpdate1.Text = "به روزرسانی";
            this.jscUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscUpdate1.UseVisualStyleBackColor = false;
            this.jscUpdate1.Click += new System.EventHandler(this.JscUpdate1Click);
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(8, 244);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 35);
            this.jscDelete1.TabIndex = 28;
            this.jscDelete1.Text = "حذف";
            this.jscDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscDelete1.UseVisualStyleBackColor = false;
            this.jscDelete1.Click += new System.EventHandler(this.JscDelete1Click);
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(8, 310);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 35);
            this.jscHome1.TabIndex = 29;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JscHome1Click);
            // 
            // jscCmbCategory
            // 
            this.jscCmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscCmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jscCmbCategory.FormattingEnabled = true;
            this.jscCmbCategory.Location = new System.Drawing.Point(6, 21);
            this.jscCmbCategory.Name = "jscCmbCategory";
            this.jscCmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscCmbCategory.Size = new System.Drawing.Size(253, 29);
            this.jscCmbCategory.TabIndex = 0;
            this.jscCmbCategory.SelectedIndexChanged += new System.EventHandler(this.JscCmbCategorySelectedIndexChanged);
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Location = new System.Drawing.Point(265, 24);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(569, 21);
            this.jscLabel1.TabIndex = 31;
            this.jscLabel1.Text = "دسته بندی را از لیست روبرو انتخاب نموده تا فقط محصولات موجود در آن دسته نمایش داد" +
    "ه شوند برای غیرفعال کردن فیلتر F12 را بفشارید";
            this.jscLabel1.Click += new System.EventHandler(this.JscLabel1Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.jscLabel1);
            this.groupBox1.Controls.Add(this.jscCmbCategory);
            this.groupBox1.Location = new System.Drawing.Point(109, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر بندی";
            // 
            // jscDataDesc
            // 
            this.jscDataDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDataDesc.BackColor = System.Drawing.Color.Transparent;
            this.jscDataDesc.Location = new System.Drawing.Point(109, 421);
            this.jscDataDesc.Name = "jscDataDesc";
            this.jscDataDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jscDataDesc.Size = new System.Drawing.Size(840, 21);
            this.jscDataDesc.TabIndex = 0;
            this.jscDataDesc.Text = "تعداد --- کالا ثبت شده است";
            this.jscDataDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jscHighlightTimer
            // 
            this.jscHighlightTimer.Interval = 300;
            this.jscHighlightTimer.MaxTickTimes = 3;
            this.jscHighlightTimer.TickTimes = 0;
            this.jscHighlightTimer.Tick += new System.EventHandler(this.JscHighlightTimerTick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "کد کالا";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // PBarCode
            // 
            this.PBarCode.DataPropertyName = "PBarCode";
            this.PBarCode.HeaderText = "بارکد";
            this.PBarCode.Name = "PBarCode";
            this.PBarCode.ReadOnly = true;
            this.PBarCode.Visible = false;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.DataPropertyName = "PName";
            this.PName.FillWeight = 200F;
            this.PName.HeaderText = "نام کالا";
            this.PName.MinimumWidth = 100;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // ProductCategory
            // 
            this.ProductCategory.DataPropertyName = "ProductCategory";
            this.ProductCategory.HeaderText = "دسته";
            this.ProductCategory.MinimumWidth = 60;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 70;
            // 
            // ProductCategoryID
            // 
            this.ProductCategoryID.DataPropertyName = "ProductCategoryID";
            this.ProductCategoryID.HeaderText = "کد دسته";
            this.ProductCategoryID.Name = "ProductCategoryID";
            this.ProductCategoryID.ReadOnly = true;
            this.ProductCategoryID.Visible = false;
            // 
            // ProductsUnit
            // 
            this.ProductsUnit.DataPropertyName = "ProductsUnit";
            this.ProductsUnit.HeaderText = "واحد کالا";
            this.ProductsUnit.MinimumWidth = 50;
            this.ProductsUnit.Name = "ProductsUnit";
            this.ProductsUnit.ReadOnly = true;
            this.ProductsUnit.Width = 50;
            // 
            // PSize
            // 
            this.PSize.DataPropertyName = "PSize";
            this.PSize.HeaderText = "تعداد هر کارتن";
            this.PSize.MinimumWidth = 70;
            this.PSize.Name = "PSize";
            this.PSize.ReadOnly = true;
            this.PSize.Width = 70;
            // 
            // PPrice
            // 
            this.PPrice.DataPropertyName = "PPrice";
            this.PPrice.HeaderText = "قیمت";
            this.PPrice.MinimumWidth = 85;
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            this.PPrice.Width = 85;
            // 
            // PDiscount
            // 
            this.PDiscount.DataPropertyName = "PDiscount";
            this.PDiscount.HeaderText = "تخفیف";
            this.PDiscount.MinimumWidth = 70;
            this.PDiscount.Name = "PDiscount";
            this.PDiscount.ReadOnly = true;
            this.PDiscount.Width = 70;
            // 
            // PBuyPrice
            // 
            this.PBuyPrice.DataPropertyName = "PBuyPrice";
            this.PBuyPrice.HeaderText = "قیمت خرید";
            this.PBuyPrice.MinimumWidth = 85;
            this.PBuyPrice.Name = "PBuyPrice";
            this.PBuyPrice.ReadOnly = true;
            this.PBuyPrice.Visible = false;
            this.PBuyPrice.Width = 85;
            // 
            // PStock
            // 
            this.PStock.DataPropertyName = "PStock";
            this.PStock.HeaderText = "موجودی";
            this.PStock.MinimumWidth = 50;
            this.PStock.Name = "PStock";
            this.PStock.ReadOnly = true;
            this.PStock.Width = 50;
            // 
            // PMinInventory
            // 
            this.PMinInventory.DataPropertyName = "PMinInventory";
            this.PMinInventory.HeaderText = "حداقل موجودی";
            this.PMinInventory.MinimumWidth = 50;
            this.PMinInventory.Name = "PMinInventory";
            this.PMinInventory.ReadOnly = true;
            this.PMinInventory.Width = 50;
            // 
            // PManufacturer
            // 
            this.PManufacturer.DataPropertyName = "PManufacturer";
            this.PManufacturer.HeaderText = "کارخانه";
            this.PManufacturer.MinimumWidth = 50;
            this.PManufacturer.Name = "PManufacturer";
            this.PManufacturer.ReadOnly = true;
            this.PManufacturer.Width = 50;
            // 
            // PDesc
            // 
            this.PDesc.DataPropertyName = "PDesc";
            this.PDesc.HeaderText = "توضیح";
            this.PDesc.MinimumWidth = 50;
            this.PDesc.Name = "PDesc";
            this.PDesc.ReadOnly = true;
            this.PDesc.Width = 50;
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.jscDataDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.jscDelete1);
            this.Controls.Add(this.jscUpdate1);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.jscDataGrid1);
            this.Controls.Add(this.lblFormTitle);
            this.KeyPreview = true;
            this.Name = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProductsLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductsKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmProductsKeyPress);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.jscAdd1, 0);
            this.Controls.SetChildIndex(this.jscUpdate1, 0);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.jscDataDesc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCLabel lblFormTitle;
        private JSCDataGrid jscDataGrid1;
        private JSCAdd jscAdd1;
        private JSCUpdate jscUpdate1;
        private JSCDelete jscDelete1;
        private JSCHome jscHome1;
        private JSCComboBox jscCmbCategory;
        private JSCLabel jscLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private JSCLabel jscDataDesc;
        private JSCTimer jscHighlightTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMinInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDesc;
    }
}
