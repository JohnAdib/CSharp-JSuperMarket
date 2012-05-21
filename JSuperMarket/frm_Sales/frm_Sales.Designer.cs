namespace JSuperMarket.frm_Sales
{
    partial class FrmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            this.lblFormTitle = new JSuperMarket.JSCLabel();
            this.jsBarCodeBox1 = new JSuperMarket.JSBarCodeBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCredit = new System.Windows.Forms.Button();
            this.jscLabel3 = new JSuperMarket.JSCLabel();
            this.jscTextBox1 = new JSuperMarket.JSCTextBox();
            this.jscLabel2 = new JSuperMarket.JSCLabel();
            this.jscLabel1 = new JSuperMarket.JSCLabel();
            this.jscComboBox1 = new JSuperMarket.JSCComboBox();
            this.jscDataGrid1 = new JSuperMarket.JSCDataGrid();
            this.jscTPrice = new JSuperMarket.JSCLabel();
            this.jscDelete1 = new JSuperMarket.JSCDelete();
            this.jscHome1 = new JSuperMarket.JSCHome();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainSalepage = new System.Windows.Forms.TabPage();
            this.jscLabel7 = new JSuperMarket.JSCLabel();
            this.jscTDiscount = new JSuperMarket.JSCLabel();
            this.jscLabel6 = new JSuperMarket.JSCLabel();
            this.jscLabel5 = new JSuperMarket.JSCLabel();
            this.jscLabel4 = new JSuperMarket.JSCLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.jscAdd1 = new JSuperMarket.JSCAdd();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MainSalepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("IranNastaliq", 25F);
            this.lblFormTitle.Location = new System.Drawing.Point(44, 137);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(87, 77);
            this.lblFormTitle.TabIndex = 25;
            this.lblFormTitle.Text = "فروش";
            // 
            // jsBarCodeBox1
            // 
            this.jsBarCodeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsBarCodeBox1.Enabled = false;
            this.jsBarCodeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jsBarCodeBox1.Location = new System.Drawing.Point(369, 40);
            this.jsBarCodeBox1.MaxLength = 20;
            this.jsBarCodeBox1.Name = "jsBarCodeBox1";
            this.jsBarCodeBox1.ReadOnly = true;
            this.jsBarCodeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jsBarCodeBox1.Size = new System.Drawing.Size(211, 26);
            this.jsBarCodeBox1.TabIndex = 26;
            this.jsBarCodeBox1.TabStop = false;
            this.jsBarCodeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCredit);
            this.groupBox1.Controls.Add(this.jscLabel3);
            this.groupBox1.Controls.Add(this.jscTextBox1);
            this.groupBox1.Controls.Add(this.jscLabel2);
            this.groupBox1.Controls.Add(this.jscLabel1);
            this.groupBox1.Controls.Add(this.jscComboBox1);
            this.groupBox1.Controls.Add(this.jsBarCodeBox1);
            this.groupBox1.Font = new System.Drawing.Font("B Koodak", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 116);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشتری را انتخاب و درصورت لزوم توضیح مربوط به آن را وارد نمایید، به گزینه ی فروش ن" +
    "قدی نیز توجه بفرمائید";
            // 
            // btnCredit
            // 
            this.btnCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredit.Location = new System.Drawing.Point(288, 69);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 31);
            this.btnCredit.TabIndex = 33;
            this.btnCredit.Text = "نقدی";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.BtnCreditClick);
            // 
            // jscLabel3
            // 
            this.jscLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel3.AutoSize = true;
            this.jscLabel3.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel3.Location = new System.Drawing.Point(288, 40);
            this.jscLabel3.Name = "jscLabel3";
            this.jscLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel3.Size = new System.Drawing.Size(36, 21);
            this.jscLabel3.TabIndex = 31;
            this.jscLabel3.Text = "توضیح";
            // 
            // jscTextBox1
            // 
            this.jscTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTextBox1.Location = new System.Drawing.Point(5, 40);
            this.jscTextBox1.MaxLength = 200;
            this.jscTextBox1.Multiline = true;
            this.jscTextBox1.Name = "jscTextBox1";
            this.jscTextBox1.Number = 0;
            this.jscTextBox1.PersianText = true;
            this.jscTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTextBox1.Size = new System.Drawing.Size(276, 61);
            this.jscTextBox1.TabIndex = 32;
            // 
            // jscLabel2
            // 
            this.jscLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel2.AutoSize = true;
            this.jscLabel2.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel2.Location = new System.Drawing.Point(587, 74);
            this.jscLabel2.Name = "jscLabel2";
            this.jscLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel2.Size = new System.Drawing.Size(39, 21);
            this.jscLabel2.TabIndex = 30;
            this.jscLabel2.Text = "مشتری";
            // 
            // jscLabel1
            // 
            this.jscLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel1.AutoSize = true;
            this.jscLabel1.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel1.Location = new System.Drawing.Point(587, 40);
            this.jscLabel1.Name = "jscLabel1";
            this.jscLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel1.Size = new System.Drawing.Size(31, 21);
            this.jscLabel1.TabIndex = 29;
            this.jscLabel1.Text = "بارکد";
            // 
            // jscComboBox1
            // 
            this.jscComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jscComboBox1.FormattingEnabled = true;
            this.jscComboBox1.Location = new System.Drawing.Point(369, 73);
            this.jscComboBox1.Name = "jscComboBox1";
            this.jscComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscComboBox1.Size = new System.Drawing.Size(211, 29);
            this.jscComboBox1.TabIndex = 27;
            // 
            // jscDataGrid1
            // 
            this.jscDataGrid1.AllowUserToOrderColumns = true;
            this.jscDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.jscDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jscDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.jscDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jscDataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.jscDataGrid1.GridColor = System.Drawing.SystemColors.Menu;
            this.jscDataGrid1.JSCustomSetting = false;
            this.jscDataGrid1.Location = new System.Drawing.Point(13, 137);
            this.jscDataGrid1.MultiSelect = false;
            this.jscDataGrid1.Name = "jscDataGrid1";
            this.jscDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDataGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.jscDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.jscDataGrid1.RowTemplate.Height = 32;
            this.jscDataGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jscDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.jscDataGrid1.Size = new System.Drawing.Size(639, 305);
            this.jscDataGrid1.StandardTab = true;
            this.jscDataGrid1.TabIndex = 28;
            this.jscDataGrid1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.JscDataGrid1CellValidated);
            this.jscDataGrid1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.JscDataGrid1CellValidating);
            this.jscDataGrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.JscDataGrid1RowEnter);
            this.jscDataGrid1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.JscDataGrid1RowValidating);
            this.jscDataGrid1.Enter += new System.EventHandler(this.JscDataGrid1Enter);
            // 
            // jscTPrice
            // 
            this.jscTPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTPrice.BackColor = System.Drawing.Color.Transparent;
            this.jscTPrice.Font = new System.Drawing.Font("B Koodak", 26F, System.Drawing.FontStyle.Bold);
            this.jscTPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.jscTPrice.Location = new System.Drawing.Point(431, 437);
            this.jscTPrice.Name = "jscTPrice";
            this.jscTPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTPrice.Size = new System.Drawing.Size(143, 51);
            this.jscTPrice.TabIndex = 29;
            this.jscTPrice.Text = "0";
            this.jscTPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jscDelete1
            // 
            this.jscDelete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscDelete1.BackColor = System.Drawing.Color.Transparent;
            this.jscDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscDelete1.ForeColor = System.Drawing.Color.Red;
            this.jscDelete1.Image = ((System.Drawing.Image)(resources.GetObject("jscDelete1.Image")));
            this.jscDelete1.Location = new System.Drawing.Point(36, 260);
            this.jscDelete1.Name = "jscDelete1";
            this.jscDelete1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscDelete1.Size = new System.Drawing.Size(95, 36);
            this.jscDelete1.TabIndex = 30;
            this.jscDelete1.Text = "حذف";
            this.jscDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscDelete1.UseVisualStyleBackColor = false;
            this.jscDelete1.Click += new System.EventHandler(this.DeleteRecord);
            // 
            // jscHome1
            // 
            this.jscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscHome1.BackColor = System.Drawing.Color.Transparent;
            this.jscHome1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.jscHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscHome1.ForeColor = System.Drawing.Color.Black;
            this.jscHome1.Image = ((System.Drawing.Image)(resources.GetObject("jscHome1.Image")));
            this.jscHome1.Location = new System.Drawing.Point(36, 302);
            this.jscHome1.Name = "jscHome1";
            this.jscHome1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscHome1.Size = new System.Drawing.Size(95, 36);
            this.jscHome1.TabIndex = 31;
            this.jscHome1.Text = "بازگشت";
            this.jscHome1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscHome1.UseVisualStyleBackColor = false;
            this.jscHome1.Click += new System.EventHandler(this.JscHome1Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.MainSalepage);
            this.tabControl1.Font = new System.Drawing.Font("B Koodak", 14F, System.Drawing.FontStyle.Bold);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(151, 39);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 543);
            this.tabControl1.TabIndex = 32;
            // 
            // MainSalepage
            // 
            this.MainSalepage.BackgroundImage = global::JSuperMarket.Properties.Resources.LightBackgroundTile;
            this.MainSalepage.Controls.Add(this.jscLabel7);
            this.MainSalepage.Controls.Add(this.jscTDiscount);
            this.MainSalepage.Controls.Add(this.jscLabel6);
            this.MainSalepage.Controls.Add(this.jscLabel5);
            this.MainSalepage.Controls.Add(this.jscLabel4);
            this.MainSalepage.Controls.Add(this.groupBox1);
            this.MainSalepage.Controls.Add(this.jscDataGrid1);
            this.MainSalepage.Controls.Add(this.jscTPrice);
            this.MainSalepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainSalepage.Location = new System.Drawing.Point(4, 42);
            this.MainSalepage.Name = "MainSalepage";
            this.MainSalepage.Padding = new System.Windows.Forms.Padding(3);
            this.MainSalepage.Size = new System.Drawing.Size(657, 497);
            this.MainSalepage.TabIndex = 0;
            this.MainSalepage.Text = "فرم اصلی فروش";
            this.MainSalepage.UseVisualStyleBackColor = true;
            // 
            // jscLabel7
            // 
            this.jscLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel7.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel7.Font = new System.Drawing.Font("B Koodak", 10F, System.Drawing.FontStyle.Bold);
            this.jscLabel7.Location = new System.Drawing.Point(301, 454);
            this.jscLabel7.Name = "jscLabel7";
            this.jscLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel7.Size = new System.Drawing.Size(83, 28);
            this.jscLabel7.TabIndex = 34;
            this.jscLabel7.Text = "با احتساب";
            this.jscLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jscTDiscount
            // 
            this.jscTDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscTDiscount.BackColor = System.Drawing.Color.Transparent;
            this.jscTDiscount.Font = new System.Drawing.Font("B Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.jscTDiscount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.jscTDiscount.Location = new System.Drawing.Point(99, 447);
            this.jscTDiscount.Name = "jscTDiscount";
            this.jscTDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscTDiscount.Size = new System.Drawing.Size(143, 39);
            this.jscTDiscount.TabIndex = 33;
            this.jscTDiscount.Text = "0";
            this.jscTDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jscLabel6
            // 
            this.jscLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel6.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel6.Font = new System.Drawing.Font("B Koodak", 10F, System.Drawing.FontStyle.Bold);
            this.jscLabel6.Location = new System.Drawing.Point(13, 454);
            this.jscLabel6.Name = "jscLabel6";
            this.jscLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel6.Size = new System.Drawing.Size(80, 28);
            this.jscLabel6.TabIndex = 32;
            this.jscLabel6.Text = "تومان تخفیف";
            // 
            // jscLabel5
            // 
            this.jscLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel5.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel5.Font = new System.Drawing.Font("B Koodak", 10F, System.Drawing.FontStyle.Bold);
            this.jscLabel5.Location = new System.Drawing.Point(390, 454);
            this.jscLabel5.Name = "jscLabel5";
            this.jscLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel5.Size = new System.Drawing.Size(41, 28);
            this.jscLabel5.TabIndex = 31;
            this.jscLabel5.Text = "تومان";
            // 
            // jscLabel4
            // 
            this.jscLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscLabel4.AutoSize = true;
            this.jscLabel4.BackColor = System.Drawing.Color.Transparent;
            this.jscLabel4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold);
            this.jscLabel4.Location = new System.Drawing.Point(579, 454);
            this.jscLabel4.Name = "jscLabel4";
            this.jscLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscLabel4.Size = new System.Drawing.Size(71, 28);
            this.jscLabel4.TabIndex = 30;
            this.jscLabel4.Text = "جمع فاکتور";
            this.jscLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(36, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "تب جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // jscAdd1
            // 
            this.jscAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jscAdd1.BackColor = System.Drawing.Color.Transparent;
            this.jscAdd1.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.jscAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jscAdd1.ForeColor = System.Drawing.Color.Olive;
            this.jscAdd1.Image = ((System.Drawing.Image)(resources.GetObject("jscAdd1.Image")));
            this.jscAdd1.Location = new System.Drawing.Point(36, 219);
            this.jscAdd1.Name = "jscAdd1";
            this.jscAdd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.jscAdd1.Size = new System.Drawing.Size(95, 36);
            this.jscAdd1.TabIndex = 33;
            this.jscAdd1.Text = "اضافه کردن";
            this.jscAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jscAdd1.UseVisualStyleBackColor = false;
            this.jscAdd1.Click += new System.EventHandler(this.JscAdd1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 34;
            this.button2.Text = "فروش جدید";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // FrmSales
            // 
            this.AcceptButton = this.jscAdd1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.CancelButton = this.jscHome1;
            this.ClientSize = new System.Drawing.Size(827, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jscAdd1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.jscHome1);
            this.Controls.Add(this.jscDelete1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSalesLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSalesKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmSalesKeyPress);
            this.Controls.SetChildIndex(this.jscDelete1, 0);
            this.Controls.SetChildIndex(this.jscHome1, 0);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.jscAdd1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jscDataGrid1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MainSalepage.ResumeLayout(false);
            this.MainSalepage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JSCLabel lblFormTitle;
        private JSBarCodeBox jsBarCodeBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private JSCLabel jscLabel3;
        private JSCLabel jscLabel2;
        private JSCLabel jscLabel1;
        private JSCComboBox jscComboBox1;
        private JSCDataGrid jscDataGrid1;
        private System.Windows.Forms.Button btnCredit;
        private JSCTextBox jscTextBox1;
        private JSCLabel jscTPrice;
        private JSCDelete jscDelete1;
        private JSCHome jscHome1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainSalepage;
        private System.Windows.Forms.Button button1;
        private JSCAdd jscAdd1;
        private System.Windows.Forms.Button button2;
        private JSCLabel jscLabel4;
        private JSCLabel jscLabel5;
        private JSCLabel jscLabel6;
        private JSCLabel jscTDiscount;
        private JSCLabel jscLabel7;
    }
}
