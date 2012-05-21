using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Purchase
{
    partial class FrmPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            this.jscCmbSupplier = new JSCComboBox();
            this.jsclblSupplier = new JSCLabel();
            this.jscTextBox1 = new JSCTextBox();
            this.jscLabel2 = new JSCLabel();
            this.jscLabel3 = new JSCLabel();
            this.jsBarCodeBox1 = new JSBarCodeBox();
            this.jscDataGrid1 = new JSCDataGrid();
            this.jscAdd1 = new JSCAdd();
            this.jscDelete1 = new JSCDelete();
            this.jscHome1 = new JSCHome();
            this.jscLabel5 = new JSCLabel();
            this.jscLabel4 = new JSCLabel();
            this.jscTPrice = new JSCLabel();
            this.lblFormTitle = new JSCLabel();
            this.jscHighlightTimer = new JSCTimer();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // jscCmbSupplier
            // 
            this.jscCmbSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscCmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jscCmbSupplier.FormattingEnabled = true;
            this.jscCmbSupplier.Location = new System.Drawing.Point(336, 39);
            this.jscCmbSupplier.Name = "jscCmbSupplier";
            this.jscCmbSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscCmbSupplier.Size = new System.Drawing.Size(241, 29);
            this.jscCmbSupplier.TabIndex = 1;
            // 
            // jsclblSupplier
            // 
            this.jsclblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsclblSupplier.AutoSize = true;
            this.jsclblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.jsclblSupplier.Location = new System.Drawing.Point(583, 42);
            this.jsclblSupplier.Name = "jsclblSupplier";
            this.jsclblSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jsclblSupplier.Size = new System.Drawing.Size(38, 21);
            this.jsclblSupplier.TabIndex = 2;
            this.jsclblSupplier.Text = "شرکت";
            // 
            // jscTextBox1
            // 
            this.jscTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTextBox1.Location = new System.Drawing.Point(87, 39);
            this.jscTextBox1.MaxLength = 200;
            this.jscTextBox1.Multiline = true;
            this.jscTextBox1.Name = "jscTextBox1";
            this.jscTextBox1.Number = 0;
            this.jscTextBox1.PersianText = true;
            this.jscTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTextBox1.Size = new System.Drawing.Size(201, 61);
            this.jscTextBox1.TabIndex = 33;
            // 
            // jscLabel2
            // 
            this.jscLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel2.AutoSize = true;
            this.jscLabel2.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel2.Location = new System.Drawing.Point(294, 42);
            this.jscLabel2.Name = "jscLabel2";
            this.jscLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel2.Size = new System.Drawing.Size(36, 21);
            this.jscLabel2.TabIndex = 34;
            this.jscLabel2.Text = "توضیح";
            // 
            // jscLabel3
            // 
            this.jscLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel3.AutoSize = true;
            this.jscLabel3.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel3.Location = new System.Drawing.Point(584, 74);
            this.jscLabel3.Name = "jscLabel3";
            this.jscLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel3.Size = new System.Drawing.Size(31, 21);
            this.jscLabel3.TabIndex = 36;
            this.jscLabel3.Text = "بارکد";
            // 
            // jsBarCodeBox1
            // 
            this.jsBarCodeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsBarCodeBox1.Enabled = false;
            this.jsBarCodeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jsBarCodeBox1.Location = new System.Drawing.Point(336, 74);
            this.jsBarCodeBox1.MaxLength = 20;
            this.jsBarCodeBox1.Name = "jsBarCodeBox1";
            this.jsBarCodeBox1.ReadOnly = true;
            this.jsBarCodeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jsBarCodeBox1.Size = new System.Drawing.Size(241, 26);
            this.jsBarCodeBox1.TabIndex = 35;
            this.jsBarCodeBox1.TabStop = false;
            this.jsBarCodeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jscDataGrid1
            // 
            this.jscDataGrid1.AllowUserToOrderColumns = true;
            this.jscDataGrid1.AllowUserToResizeColumns = false;
            this.jscDataGrid1.AllowUserToResizeRows = false;
            this.jscDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.jscDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jscDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jscDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jscDataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = false;
            this.jscDataGrid1.Location = new System.Drawing.Point(12, 106);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Koodak", 10.25F, System.Drawing.FontStyle.Bold);
            this.jscDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.jscDataGrid1.RowTemplate.Height = 32;
            this.jscDataGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(606, 309);
            this.jscDataGrid1.TabIndex = 37;
            this.jscDataGrid1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.JSCDataGrid1CellValidated);
            this.jscDataGrid1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.JSCDataGrid1CellValidating);
            this.jscDataGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.JSCDataGrid1RowEnter);
            this.jscDataGrid1.Enter += new System.EventHandler(this.JSCDataGrid1Enter);
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(214, 432);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 35);
            this.jscAdd1.TabIndex = 38;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.JSCAdd1Click);
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(113, 432);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 35);
            this.jscDelete1.TabIndex = 39;
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
            this.jscHome1.Location = new System.Drawing.Point(12, 432);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 35);
            this.jscHome1.TabIndex = 40;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JSCHome1Click);
            // 
            // jscLabel5
            // 
            this.jscLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel5.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel5.Font = new System.Drawing.Font("B Koodak", 10F, System.Drawing.FontStyle.Bold);
            this.jscLabel5.Location = new System.Drawing.Point(358, 435);
            this.jscLabel5.Name = "jscLabel5";
            this.jscLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel5.Size = new System.Drawing.Size(41, 28);
            this.jscLabel5.TabIndex = 43;
            this.jscLabel5.Text = "تومان";
            // 
            // jscLabel4
            // 
            this.jscLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel4.AutoSize = true;
            this.jscLabel4.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold);
            this.jscLabel4.Location = new System.Drawing.Point(547, 435);
            this.jscLabel4.Name = "jscLabel4";
            this.jscLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel4.Size = new System.Drawing.Size(71, 28);
            this.jscLabel4.TabIndex = 42;
            this.jscLabel4.Text = "جمع فاکتور";
            this.jscLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jscTPrice
            // 
            this.jscTPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTPrice.BackColor = System.Drawing.Color.Transparent;
            this.jscTPrice.Font = new System.Drawing.Font("B Koodak", 26F, System.Drawing.FontStyle.Bold);
            this.jscTPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.jscTPrice.Location = new System.Drawing.Point(399, 418);
            this.jscTPrice.Name = "jscTPrice";
            this.jscTPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTPrice.Size = new System.Drawing.Size(160, 51);
            this.jscTPrice.TabIndex = 41;
            this.jscTPrice.Text = "0";
            this.jscTPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 25F);
            this.lblFormTitle.Location = new System.Drawing.Point(12, 26);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(69, 77);
            this.lblFormTitle.TabIndex = 44;
            this.lblFormTitle.Text = "خرید";
            // 
            // jscHighlightTimer
            // 
            this.jscHighlightTimer.Interval = 300;
            this.jscHighlightTimer.MaxTickTimes = 3;
            this.jscHighlightTimer.TickTimes = 0;
            this.jscHighlightTimer.Tick += new System.EventHandler(this.JSCHighlightTimerTick);
            // 
            // FrmPurchase
            // 
            this.AcceptButton = this.jscAdd1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.jscLabel5);
            this.Controls.Add(this.jscLabel4);
            this.Controls.Add(this.jscTPrice);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.jscDelete1);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.jscDataGrid1);
            this.Controls.Add(this.jscLabel3);
            this.Controls.Add(this.jsBarCodeBox1);
            this.Controls.Add(this.jscLabel2);
            this.Controls.Add(this.jscTextBox1);
            this.Controls.Add(this.jscCmbSupplier);
            this.Controls.Add(this.jsclblSupplier);
            this.KeyPreview = true;
            this.Name = "FrmPurchase";
            this.Load += new System.EventHandler(this.FrmPurchaseLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPurchaseKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPurchaseKeyPress);
            this.Controls.SetChildIndex(this.jsclblSupplier, 0);
            this.Controls.SetChildIndex(this.jscCmbSupplier, 0);
            this.Controls.SetChildIndex(this.jscTextBox1, 0);
            this.Controls.SetChildIndex(this.jscLabel2, 0);
            this.Controls.SetChildIndex(this.jsBarCodeBox1, 0);
            this.Controls.SetChildIndex(this.jscLabel3, 0);
            this.Controls.SetChildIndex(this.jscDataGrid1, 0);
            this.Controls.SetChildIndex(this.jscAdd1, 0);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.jscTPrice, 0);
            this.Controls.SetChildIndex(this.jscLabel4, 0);
            this.Controls.SetChildIndex(this.jscLabel5, 0);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCComboBox jscCmbSupplier;
        private JSCLabel jsclblSupplier;
        private JSCTextBox jscTextBox1;
        private JSCLabel jscLabel2;
        private JSCLabel jscLabel3;
        private JSBarCodeBox jsBarCodeBox1;
        private JSCDataGrid jscDataGrid1;
        private JSCAdd jscAdd1;
        private JSCDelete jscDelete1;
        private JSCHome jscHome1;
        private JSCLabel jscLabel5;
        private JSCLabel jscLabel4;
        private JSCLabel jscTPrice;
        private JSCLabel lblFormTitle;
        private JSCTimer jscHighlightTimer;
    }
}
