namespace JSuperMarket.Forms.frm_Sales
{
    partial class FrmSalesSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesSetting));
            this.lblFormTitle = new JSuperMarket.Utility.JSCLabel();
            this.jscHome1 = new JSuperMarket.Utility.JSCHome();
            this.jscAdd1 = new JSuperMarket.Utility.JSCAdd();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jscLabel2 = new JSuperMarket.Utility.JSCLabel();
            this.jscLabel1 = new JSuperMarket.Utility.JSCLabel();
            this.jscCmbProducts = new JSuperMarket.Utility.JSCComboBox();
            this.jscCmbCategory = new JSuperMarket.Utility.JSCComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jscTxtAppname = new JSuperMarket.Utility.JSCTextBox();
            this.jscLabel4 = new JSuperMarket.Utility.JSCLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 20F);
            this.lblFormTitle.Location = new System.Drawing.Point(17, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(123, 62);
            this.lblFormTitle.TabIndex = 26;
            this.lblFormTitle.Tag = "Error List:";
            this.lblFormTitle.Text = "تنظیمات فروش";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(26, 162);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 36);
            this.jscHome1.TabIndex = 32;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JSCHome1Click);
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(26, 120);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 36);
            this.jscAdd1.TabIndex = 34;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.JSCAdd1Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.jscLabel2);
            this.groupBox1.Controls.Add(this.jscLabel1);
            this.groupBox1.Controls.Add(this.jscCmbProducts);
            this.groupBox1.Controls.Add(this.jscCmbCategory);
            this.groupBox1.Location = new System.Drawing.Point(146, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 116);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کالای پیش فرض را برای فروش دستی کالا وارد نمایید";
            // 
            // jscLabel2
            // 
            this.jscLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel2.AutoSize = true;
            this.jscLabel2.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel2.Location = new System.Drawing.Point(308, 71);
            this.jscLabel2.Name = "jscLabel2";
            this.jscLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel2.Size = new System.Drawing.Size(78, 21);
            this.jscLabel2.TabIndex = 42;
            this.jscLabel2.Text = "کالای پیش فرض";
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Location = new System.Drawing.Point(307, 36);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(76, 21);
            this.jscLabel1.TabIndex = 41;
            this.jscLabel1.Text = "دسته پیش فرض";
            // 
            // jscCmbProducts
            // 
            this.jscCmbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscCmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jscCmbProducts.FormattingEnabled = true;
            this.jscCmbProducts.Location = new System.Drawing.Point(6, 68);
            this.jscCmbProducts.Name = "jscCmbProducts";
            this.jscCmbProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscCmbProducts.Size = new System.Drawing.Size(295, 29);
            this.jscCmbProducts.TabIndex = 40;
            this.jscCmbProducts.SelectedIndexChanged += new System.EventHandler(this.JSCCmbProductsSelectedIndexChanged);
            this.jscCmbProducts.TextChanged += new System.EventHandler(this.JSCCmbProductsTextChanged);
            // 
            // jscCmbCategory
            // 
            this.jscCmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscCmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jscCmbCategory.FormattingEnabled = true;
            this.jscCmbCategory.Location = new System.Drawing.Point(6, 33);
            this.jscCmbCategory.Name = "jscCmbCategory";
            this.jscCmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscCmbCategory.Size = new System.Drawing.Size(295, 29);
            this.jscCmbCategory.TabIndex = 39;
            this.jscCmbCategory.TextChanged += new System.EventHandler(this.JSCCmbCategoryTextChanged);
            this.jscCmbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.JSCCmbCategoryValidating);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.jscTxtAppname);
            this.groupBox2.Controls.Add(this.jscLabel4);
            this.groupBox2.Location = new System.Drawing.Point(146, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 85);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نام فروشگاه خود را وارد نمایید";
            // 
            // jscTxtAppname
            // 
            this.jscTxtAppname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTxtAppname.Location = new System.Drawing.Point(6, 33);
            this.jscTxtAppname.MaxLength = 200;
            this.jscTxtAppname.Name = "jscTxtAppname";
            this.jscTxtAppname.Number = 0;
            this.jscTxtAppname.PersianText = true;
            this.jscTxtAppname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTxtAppname.Size = new System.Drawing.Size(295, 28);
            this.jscTxtAppname.TabIndex = 42;
            // 
            // jscLabel4
            // 
            this.jscLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel4.AutoSize = true;
            this.jscLabel4.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel4.Location = new System.Drawing.Point(307, 36);
            this.jscLabel4.Name = "jscLabel4";
            this.jscLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel4.Size = new System.Drawing.Size(69, 21);
            this.jscLabel4.TabIndex = 41;
            this.jscLabel4.Text = "سامانه مدیریت";
            // 
            // FrmSalesSetting
            // 
            this.AcceptButton = this.jscAdd1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "FrmSalesSetting";
            this.Text = "تنظیمات سامانه مدیریت";
            this.Load += new System.EventHandler(this.FrmSalesSettingLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.JSCLabel lblFormTitle;
        private Utility.JSCHome jscHome1;
        private Utility.JSCAdd jscAdd1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Utility.JSCLabel jscLabel2;
        private Utility.JSCLabel jscLabel1;
        private Utility.JSCComboBox jscCmbProducts;
        private Utility.JSCComboBox jscCmbCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private Utility.JSCTextBox jscTxtAppname;
        private Utility.JSCLabel jscLabel4;
    }
}
