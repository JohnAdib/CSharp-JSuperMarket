using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Base
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.cmbUserCode = new System.Windows.Forms.ComboBox();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblPassCode = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jscMessage = new JSuperMarket.Utility.JSCLabel();
            this.txtPassCode = new JSuperMarket.Utility.JSCTextBox();
            this.jscTimer1 = new JSuperMarket.Utility.JSCTimer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserCode
            // 
            this.cmbUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserCode.FormattingEnabled = true;
            this.cmbUserCode.Location = new System.Drawing.Point(125, 43);
            this.cmbUserCode.Name = "cmbUserCode";
            this.cmbUserCode.Size = new System.Drawing.Size(162, 29);
            this.cmbUserCode.TabIndex = 0;
            this.cmbUserCode.SelectionChangeCommitted += new System.EventHandler(this.CmbUserCodeSelectionChangeCommitted);
            this.cmbUserCode.Enter += new System.EventHandler(this.CmbUserCodeEnter);
            this.cmbUserCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CmbUserCodePreviewKeyDown);
            // 
            // lblUserCode
            // 
            this.lblUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCode.Location = new System.Drawing.Point(292, 45);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(52, 21);
            this.lblUserCode.TabIndex = 1;
            this.lblUserCode.Text = "نام کاربری";
            // 
            // lblPassCode
            // 
            this.lblPassCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassCode.AutoSize = true;
            this.lblPassCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPassCode.Location = new System.Drawing.Point(292, 81);
            this.lblPassCode.Name = "lblPassCode";
            this.lblPassCode.Size = new System.Drawing.Size(49, 21);
            this.lblPassCode.TabIndex = 2;
            this.lblPassCode.Text = "کلمه عبور";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(236, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ورود";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(125, 136);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(104, 30);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "خروج";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // jscMessage
            // 
            this.jscMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscMessage.BackColor = System.Drawing.Color.Transparent;
            this.jscMessage.Location = new System.Drawing.Point(12, 194);
            this.jscMessage.Name = "jscMessage";
            this.jscMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscMessage.Size = new System.Drawing.Size(372, 24);
            this.jscMessage.TabIndex = 8;
            this.jscMessage.Text = "به سامانه مدیریت سوپر سعید خوش آمدید..";
            // 
            // txtPassCode
            // 
            this.txtPassCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassCode.Location = new System.Drawing.Point(125, 78);
            this.txtPassCode.MaxLength = 16;
            this.txtPassCode.Name = "txtPassCode";
            this.txtPassCode.Number = 0;
            this.txtPassCode.PasswordChar = '●';
            this.txtPassCode.PersianText = false;
            this.txtPassCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassCode.Size = new System.Drawing.Size(162, 28);
            this.txtPassCode.TabIndex = 1;
            this.txtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassCode.UseSystemPasswordChar = true;
            this.txtPassCode.TextChanged += new System.EventHandler(this.TxtPassCodeTextChanged);
            // 
            // jscTimer1
            // 
            this.jscTimer1.Enabled = true;
            this.jscTimer1.MaxTickTimes = 74;
            this.jscTimer1.TickTimes = 0;
            this.jscTimer1.Tick += new System.EventHandler(this.JscTimer1Tick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSuperMarket.Properties.Resources.LightBackgroundTile;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(385, 218);
            this.Controls.Add(this.jscMessage);
            this.Controls.Add(this.txtPassCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPassCode);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.cmbUserCode);
            this.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت سوپر مارکت";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FrmLoginLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserCode;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblPassCode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JSCTextBox txtPassCode;
        private JSCLabel jscMessage;
        private JSCTimer jscTimer1;
    }
}