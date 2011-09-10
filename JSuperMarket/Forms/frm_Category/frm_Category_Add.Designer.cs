namespace JSuperMarket
{
    partial class frm_Category_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category_Add));
            this.lblFormTitle = new JSuperMarket.JSCLabel();
            this.jscLabel1 = new JSuperMarket.JSCLabel();
            this.jscTextBox1 = new JSuperMarket.JSCTextBox();
            this.jscAdd1 = new JSuperMarket.JSCAdd();
            this.jscClose1 = new JSuperMarket.JSCClose();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.lblFormTitle.Location = new System.Drawing.Point(74, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(141, 48);
            this.lblFormTitle.TabIndex = 26;
            this.lblFormTitle.Text = "اضافه کردن دسته ی اصلی";
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Location = new System.Drawing.Point(236, 63);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(65, 21);
            this.jscLabel1.TabIndex = 27;
            this.jscLabel1.Text = "نام دسته اصلی";
            // 
            // jscTextBox1
            // 
            this.jscTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTextBox1.Location = new System.Drawing.Point(30, 60);
            this.jscTextBox1.Name = "jscTextBox1";
            this.jscTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTextBox1.Size = new System.Drawing.Size(200, 28);
            this.jscTextBox1.TabIndex = 28;
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(135, 94);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 35);
            this.jscAdd1.TabIndex = 29;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.jscAdd1_Click);
            // 
            // jscClose1
            // 
            this.jscClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscClose1.BackColor = System.Drawing.Color.Transparent;
            this.jscClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscClose1.ForeColor = System.Drawing.Color.Black;
            this.jscClose1.Image = ((System.Drawing.Image)(resources.GetObject("jscClose1.Image")));
            this.jscClose1.Location = new System.Drawing.Point(30, 94);
            this.jscClose1.Name = "jscClose1";
            this.jscClose1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscClose1.Size = new System.Drawing.Size(95, 35);
            this.jscClose1.TabIndex = 30;
            this.jscClose1.Text = "بستن";
            this.jscClose1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscClose1.UseVisualStyleBackColor = false;
            this.jscClose1.Click += new System.EventHandler(this.jscClose1_Click);
            // 
            // frm_Category_Add
            // 
            this.AcceptButton = this.jscAdd1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscClose1;
            this.ClientSize = new System.Drawing.Size(313, 149);
            this.Controls.Add(this.jscClose1);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.jscTextBox1);
            this.Controls.Add(this.jscLabel1);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "frm_Category_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCLabel lblFormTitle;
        private JSCLabel jscLabel1;
        private JSCTextBox jscTextBox1;
        private JSCAdd jscAdd1;
        private JSCClose jscClose1;
    }
}
