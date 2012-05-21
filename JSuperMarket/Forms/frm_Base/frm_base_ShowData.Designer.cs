namespace JSuperMarket.Forms.frm_Base
{
    partial class FrmBaseShowData
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
            this.juC_MainMenu1 = new JSuperMarket.JUC_MainMenu();
            this.SuspendLayout();
            // 
            // juC_MainMenu1
            // 
            this.juC_MainMenu1.AutoSize = true;
            this.juC_MainMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.juC_MainMenu1.BackColor = System.Drawing.Color.Transparent;
            this.juC_MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.juC_MainMenu1.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold);
            this.juC_MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.juC_MainMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.juC_MainMenu1.MaximumSize = new System.Drawing.Size(0, 31);
            this.juC_MainMenu1.MinimumSize = new System.Drawing.Size(0, 31);
            this.juC_MainMenu1.Name = "juC_MainMenu1";
            this.juC_MainMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.juC_MainMenu1.Size = new System.Drawing.Size(406, 31);
            this.juC_MainMenu1.TabIndex = 0;
            // 
            // FrmBaseShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSuperMarket.Properties.Resources.LightBackgroundTile;
            this.ClientSize = new System.Drawing.Size(406, 314);
            this.Controls.Add(this.juC_MainMenu1);
            this.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBaseShowData";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت سوپر سعید";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingEffect);
            this.Load += new System.EventHandler(this.FrmBaseShowDataLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JUC_MainMenu juC_MainMenu1;

    }
}