namespace JSuperMarket
{
    partial class frm_Category_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category_Edit));
            this.jscUpdate1 = new JSuperMarket.JSCUpdate();
            this.jscClose1 = new JSuperMarket.JSCClose();
            this.jscTextBox1 = new JSuperMarket.JSCTextBox();
            this.jscLabel1 = new JSuperMarket.JSCLabel();
            this.lblFormTitle = new JSuperMarket.JSCLabel();
            this.SuspendLayout();
            // 
            // jscUpdate1
            // 
            this.jscUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscUpdate1.BackColor = System.Drawing.Color.Transparent;
            this.jscUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscUpdate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.jscUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("jscUpdate1.Image")));
            this.jscUpdate1.Location = new System.Drawing.Point(124, 94);
            this.jscUpdate1.Name = "jscUpdate1";
            this.jscUpdate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscUpdate1.Size = new System.Drawing.Size(95, 35);
            this.jscUpdate1.TabIndex = 18;
            this.jscUpdate1.Text = "به روزرسانی";
            this.jscUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscUpdate1.UseVisualStyleBackColor = false;
            this.jscUpdate1.Click += new System.EventHandler(this.jscUpdate1_Click);
            // 
            // jscClose1
            // 
            this.jscClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscClose1.BackColor = System.Drawing.Color.Transparent;
            this.jscClose1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscClose1.ForeColor = System.Drawing.Color.Black;
            this.jscClose1.Image = ((System.Drawing.Image)(resources.GetObject("jscClose1.Image")));
            this.jscClose1.Location = new System.Drawing.Point(19, 94);
            this.jscClose1.Name = "jscClose1";
            this.jscClose1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscClose1.Size = new System.Drawing.Size(95, 35);
            this.jscClose1.TabIndex = 19;
            this.jscClose1.Text = "بستن";
            this.jscClose1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscClose1.UseVisualStyleBackColor = false;
            this.jscClose1.Click += new System.EventHandler(this.jscClose1_Click);
            // 
            // jscTextBox1
            // 
            this.jscTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTextBox1.Location = new System.Drawing.Point(19, 60);
            this.jscTextBox1.Name = "jscTextBox1";
            this.jscTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTextBox1.Size = new System.Drawing.Size(200, 28);
            this.jscTextBox1.TabIndex = 20;
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Location = new System.Drawing.Point(225, 63);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(65, 21);
            this.jscLabel1.TabIndex = 21;
            this.jscLabel1.Text = "نام دسته اصلی";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 15.75F);
            this.lblFormTitle.Location = new System.Drawing.Point(76, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(133, 48);
            this.lblFormTitle.TabIndex = 26;
            this.lblFormTitle.Text = "ویرایش دسته بندی اصلی";
            // 
            // frm_Category_Edit
            // 
            this.AcceptButton = this.jscUpdate1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscClose1;
            this.ClientSize = new System.Drawing.Size(301, 152);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.jscLabel1);
            this.Controls.Add(this.jscTextBox1);
            this.Controls.Add(this.jscClose1);
            this.Controls.Add(this.jscUpdate1);
            this.Name = "frm_Category_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCUpdate jscUpdate1;
        private JSCClose jscClose1;
        private JSCTextBox jscTextBox1;
        private JSCLabel jscLabel1;
        private JSCLabel lblFormTitle;
    }
}
