using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Base
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jsctxtDate = new JSuperMarket.Utility.JSCLabel();
            this.jsctxtUser = new JSuperMarket.Utility.JSCLabel();
            this.jscTimer1 = new JSuperMarket.Utility.JSCTimer();
            this.openFrmPurchase = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(174, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "دسته های اصلی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 7);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(321, 109);
            this.lblFormTitle.TabIndex = 7;
            this.lblFormTitle.Text = "سامانه مدیریت سوپرمارکت";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormTitle.Click += new System.EventHandler(this.LblFormTitleClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(174, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 32);
            this.button4.TabIndex = 100;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(264, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 34);
            this.button5.TabIndex = 30;
            this.button5.Text = "واحد کالاها";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(174, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 34);
            this.button6.TabIndex = 50;
            this.button6.Text = "شرکت های پخش";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(264, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 34);
            this.button7.TabIndex = 20;
            this.button7.Text = "مشتریان";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(264, 154);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "کالاها";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OpenFrmProducts);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(174, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "فروش";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OpenfrmSale);
            // 
            // jsctxtDate
            // 
            this.jsctxtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsctxtDate.BackColor = System.Drawing.Color.Transparent;
            this.jsctxtDate.Location = new System.Drawing.Point(7, 309);
            this.jsctxtDate.Name = "jsctxtDate";
            this.jsctxtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jsctxtDate.Size = new System.Drawing.Size(163, 19);
            this.jsctxtDate.TabIndex = 10;
            this.jsctxtDate.Text = "امروز";
            this.jsctxtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jsctxtDate.Click += new System.EventHandler(this.JscLabel2Click);
            // 
            // jsctxtUser
            // 
            this.jsctxtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsctxtUser.BackColor = System.Drawing.Color.Transparent;
            this.jsctxtUser.Location = new System.Drawing.Point(174, 309);
            this.jsctxtUser.Name = "jsctxtUser";
            this.jsctxtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jsctxtUser.Size = new System.Drawing.Size(174, 19);
            this.jsctxtUser.TabIndex = 8;
            this.jsctxtUser.Text = "کاربر فعلی: ";
            this.jsctxtUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jsctxtUser.Click += new System.EventHandler(this.JsctxtUserClick);
            // 
            // jscTimer1
            // 
            this.jscTimer1.Enabled = true;
            this.jscTimer1.Interval = 120;
            this.jscTimer1.MaxTickTimes = 0;
            this.jscTimer1.TickTimes = 0;
            this.jscTimer1.Tick += new System.EventHandler(this.JscTimer1Tick);
            // 
            // openFrmPurchase
            // 
            this.openFrmPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFrmPurchase.Location = new System.Drawing.Point(176, 154);
            this.openFrmPurchase.Name = "openFrmPurchase";
            this.openFrmPurchase.Size = new System.Drawing.Size(84, 34);
            this.openFrmPurchase.TabIndex = 5;
            this.openFrmPurchase.Text = "خرید";
            this.openFrmPurchase.UseVisualStyleBackColor = true;
            this.openFrmPurchase.Click += new System.EventHandler(this.OpenFrmPurchaseClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(117, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 34);
            this.button3.TabIndex = 96;
            this.button3.Text = "تنظیمات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(31, 114);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 34);
            this.button9.TabIndex = 97;
            this.button9.Text = "گزارش فروش";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSuperMarket.Properties.Resources.LightBackgroundTile;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(360, 336);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.openFrmPurchase);
            this.Controls.Add(this.jsctxtDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jsctxtUser);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmMainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت سوپرمارکت";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FrmMainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private JSCLabel jsctxtUser;
        private System.Windows.Forms.Button button2;
        private JSCLabel jsctxtDate;
        private JSCTimer jscTimer1;
        private System.Windows.Forms.Button openFrmPurchase;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
    }
}