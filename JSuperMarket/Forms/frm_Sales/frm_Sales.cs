using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;
using JSuperMarket.Forms.frm_Products;

namespace JSuperMarket.Forms.frm_Sales
{
    public partial class FrmSales : FrmBaseShowData
    {
        readonly FrmSalesClass _relatedClass = new FrmSalesClass();
        int _currentRow;
        bool _creditSale;
        public FrmSales()
        {
            InitializeComponent();

            {
                var newColumn = new DataGridViewComboBoxColumn
                                    {
                                        Name = "PCatID",
                                        HeaderText = @"دسته",
                                        DataSource = _relatedClass.DBCategoryList(),
                                        DisplayMember = "ProductCategory",
                                        ValueMember = "ProductCategoryID",
                                        MinimumWidth = 110
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewComboBoxColumn
                                    {
                                        Name = "PID",
                                        HeaderText = @"نام کالا",
                                        DataSource = _relatedClass.DBSelectProducts(),
                                        DisplayMember = "PName",
                                        ValueMember = "ProductID",
                                        DataPropertyName = "",
                                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                                        MinimumWidth = 180
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                                    {
                                        Name = "PCount",
                                        HeaderText = @"تعداد",
                                        MinimumWidth = 50,
                                        
                                                              Width = 50
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                                    {
                                        Name = "PPrice",
                                        HeaderText = @"قیمت کالا",
                                        MinimumWidth = 70,
                                        Width = 100,
                                        ReadOnly = true
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                                    {
                                        Name = "PDiscount",
                                        HeaderText = @"تخفیف",
                                        MinimumWidth = 70,
                                        Width = 70
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                                    {
                                        Name = "RTPrice",
                                        HeaderText = @"مجموع",
                                        MinimumWidth = 100,
                                        Width = 110,
                                        ReadOnly = true
                                    };
                jscDataGrid1.Columns.Add(newColumn);
            }
            jscCmbCustomers.DataSource = _relatedClass.DBCustomerList();
            jscCmbCustomers.DisplayMember = "CName";
            jscCmbCustomers.ValueMember = "CustomerID";
        }

        private void FrmSalesLoad(object sender, EventArgs e)
        {

        }

        private bool _inAddStatus;
        private int _addNum;
        private bool _isBarCode;
        private string _barcode = "";
        private void FrmSalesKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // for giving barcode from user
                if (e.KeyChar == '$')
                {
                    try
                    {
                        var elanguage = new System.Globalization.CultureInfo("en-us");
                        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    _isBarCode = !_isBarCode;
                    e.Handled = true;
                    if (!_isBarCode)
                    {
                        if (_barcode.Length > 2)
                        {
                            jsBarCodeBox1.Text = _barcode;
                            BarcodeChanged();
                        }
                        _barcode = "";
                        try
                        {
                            var planguage = new System.Globalization.CultureInfo("fa-ir");
                            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(planguage);
                        }
                        catch (Exception) { return; }
                    }
                }
                else if (_isBarCode)
                {
                    e.Handled = true;
                    _barcode += e.KeyChar;
                }

                    //for add number to datagridview
                else if (e.KeyChar == '+')
                {
                    e.Handled = true;
                    if (_inAddStatus)
                    {
                        // event when in add status
                        JscfAddNumToDataGrid();
                        jsclblAddValue.Text = @"+";
                    }
                    else
                    {
                        // event when in starting to add
                        _inAddStatus = true;
                    }
                }
                else if (e.KeyChar == '=' && _inAddStatus)
                {
                    e.Handled = true;
                    _inAddStatus = false;
                    JscfAddNumToDataGrid();
                    jsclblAddValue.Text = @"=";
                }
                else if (_inAddStatus && !(e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                    if(_addNum.ToString().Length >= 9) return;
                    _addNum *= 10;
                    _addNum += Convert.ToInt32(e.KeyChar.ToString());
                    jsclblAddValue.Text = _addNum.ToString();
                }
                else if (_inAddStatus && e.KeyChar == 8 )
                {
                    _addNum /= 10;
                    jsclblAddValue.Text = _addNum.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در خواندن اطلاعات از کاربر", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscfAddNumToDataGrid()
        {
            try
            {
                if (_addNum == 0) return;

                jscDataGrid1.Rows.Add(null, null, "1", _addNum, "0", _addNum);
                //TotalSaleForRow(jscDataGrid1.Rows.Count - 2);
                SaleTotalPrice();
                _currentRow = jscDataGrid1.RowCount - 2;
                _addNum = 0;
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در وارد کردن عدد به جدول", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        bool _newProduct = true;
        private void BarcodeChanged()
        {
            try
            {
                DataTable dt = _relatedClass.DBFindBarcode(jsBarCodeBox1.Text);
                if (dt.Rows.Count == 0)
                {
                    const string msgtxt =
                        @"این بارکد برای هیچ کالایی ثبت نشده است" + "\n" + " را بفشارید Yes برای افزودن کالا";
                    var result = MessageBox.Show(msgtxt, @"سامانه مدیریت سوپر مارکت",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                 MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        var frmaddproduct = new FrmProductsAdd {Barcode = jsBarCodeBox1.Text};
                        frmaddproduct.ShowDialog();
                        Close();
                    }
                    jsBarCodeBox1.Text = "";
                    return;
                }

                if (dt.Rows.Count > 1)
                {
                    jsBarCodeBox1.Text = "";
                    MessageBox.Show(@"این بارکد برای بیش از یک کالا ثبت شده است", @"خطا");
                    return;
                }

                if (dt.Rows.Count == 1)
                {
                    JscfAddToDataGrid(dt);
                }
                _barcode = "";
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در تغییر بارکد", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscfAddToDataGrid(DataTable dt)
        {
            try
            {
                for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++) // for check new product or not
                {
                    var row = jscDataGrid1.Rows[index];
                    //if (jscDataGrid1.Rows.Count - 1 == row.Index) break;
                    if (row.Cells["PID"].Value == null) continue;
                    if (dt.Rows[0]["ProductID"].ToString() == row.Cells["PID"].Value.ToString())
                    {
                        row.Cells["PCount"].Value = Int32.Parse(row.Cells["PCount"].Value.ToString()) + 1;
                        TotalSaleForRow(index);
                        _newProduct = false;
                        _currentRow = index;
                    }
                }
                if (_newProduct) // if new then
                {
                    if (_creditSale) // if credit add without discount
                        jscDataGrid1.Rows.Add(dt.Rows[0]["ProductCategoryID"], dt.Rows[0]["ProductID"], "1",
                                              dt.Rows[0]["PPrice"], "0", dt.Rows[0]["PPrice"]);
                    else // else add with discount
                    {
                        int tprice = Int32.Parse(dt.Rows[0]["PPrice"].ToString());
                        tprice -= Int32.Parse(dt.Rows[0]["PDiscount"].ToString());
                        jscDataGrid1.Rows.Add(dt.Rows[0]["ProductCategoryID"], dt.Rows[0]["ProductID"], "1",
                                              dt.Rows[0]["PPrice"], dt.Rows[0]["PDiscount"], tprice);
                    }
                    _currentRow = jscDataGrid1.RowCount - 2;
                }
                else
                {
                    _newProduct = true;
                }

                TotalSaleForRow(jscDataGrid1.Rows.Count - 2);
                SaleTotalPrice();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در اضافه کردن به جدول", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void TotalSaleForRow(int rowNumber)
        {
            try
            {
                int totalofrow = Convert.ToInt32(jscDataGrid1.Rows[rowNumber].Cells["PCount"].Value)
                                * (Convert.ToInt32(jscDataGrid1.Rows[rowNumber].Cells["PPrice"].Value)
                                    - Convert.ToInt32(jscDataGrid1.Rows[rowNumber].Cells["PDiscount"].Value));
                jscDataGrid1.Rows[rowNumber].Cells["RTPrice"].Value = totalofrow;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(@"محاسبه جمع سطر", @"سامانه مدیریت سوپر مارکت");
                jscDataGrid1.Rows[rowNumber].Cells["RTPrice"].Value = "خطا";
                return;
            }
        }

        private void SaleTotalPrice()
        {
            try
            {
                int saletotalprice = 0;
                int saletotalDiscount = 0;
                for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++)
                    // for calc totalprice and totaldiscount
                {
                    DataGridViewRow row = jscDataGrid1.Rows[index];
                    //if (jscDataGrid1.Rows.Count - 1 == row.Index) break;
                    if (row.Cells["RTPrice"].Value == null) continue;
                    saletotalprice += Convert.ToInt32(row.Cells["RTPrice"].Value);
                    if (row.Cells["PDiscount"].Value == null) continue;
                    saletotalDiscount += Convert.ToInt32(row.Cells["PDiscount"].Value)*
                                         Convert.ToInt32(row.Cells["PCount"].Value);
                }
                jscTPrice.Text = saletotalprice.ToString();
                jscTDiscount.Text = saletotalDiscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در محاسبه جمع کل فروش", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscDataGrid1Enter(object sender, EventArgs e)
        {
            var elanguage = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
        }

        private void FrmSalesKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteRecord(null, null);
            if (e.KeyCode == Keys.F8) Button2Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) JscAdd1Click(null, null); 
        }

        private void DeleteRecord(object sender, EventArgs e)
        {
            try
            {
                if (jscDataGrid1.Rows.Count == 1) return;
                if (jscDataGrid1.Rows.Count == _currentRow + 1) return;
                jscDataGrid1.Rows.RemoveAt(_currentRow);
                _currentRow = jscDataGrid1.RowCount - 2;
                SaleTotalPrice();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در پاک کردن ردیف از جدول", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var newPage = new TabPage
                              {
                                  Name = "new page",
                                  Text = @"فروش موازی",
                                  BackgroundImage = Properties.Resources.LightBackgroundTile
                              };
            tabControl1.TabPages.Add(newPage);
        }

        private void JscAdd1Click(object sender, EventArgs e)
        {
            try
            {
                if (jscDataGrid1.RowCount > 0)
                {

                    // add to db and update prices

                    var relatedClass = new FrmSalesClass
                                           {
                                               Seller = "Admin",
                                               Cid = jscCmbCustomers.SValue,
                                               SalesDesc = jscTextBox1.Text,
                                               Credit = btnCredit.Text == @"اعتباری",
                                           };
                    relatedClass.DBAddToPrimary();

                    for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++)
                        // for update each product data
                    {
                        DataGridViewRow row = jscDataGrid1.Rows[index];

                        if (row.Cells["PID"].Value == null) continue;
                        relatedClass.Pid = Convert.ToInt32(row.Cells["PID"].Value);

                        if (row.Cells["PCount"].Value == null) continue;
                        relatedClass.PCount = Convert.ToInt32(row.Cells["PCount"].Value);

                        if (row.Cells["PPrice"].Value == null) continue;
                        relatedClass.PsPrice = Convert.ToInt32(row.Cells["PPrice"].Value);

                        relatedClass.DBAddToSecondary();
                    }
                    lblFormTitle.Tag += relatedClass.LastError;
                }

                jscDataGrid1.Rows.Clear();
                jsBarCodeBox1.Text = "";
                jscTextBox1.Text = "";
                //jscComboBox1.SelectedValue = 0;
                jscTPrice.Text = @"0";
                jscTDiscount.Text = @"0";
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در اضافه کردن فروش جدید", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var frmsales = new FrmSales();
            frmsales.Show();
        }

        private void BtnCreditClick(object sender, EventArgs e)
        {
            try
            {
                if (btnCredit.Text == @"نقدی")
                {
                    btnCredit.Text = @"اعتباری";
                    _creditSale = true;
                }
                else
                {
                    btnCredit.Text = @"نقدی";
                    _creditSale = false;
                }
// ReSharper disable EmptyForStatement
                for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++)
                {
                    
                }
// ReSharper restore EmptyForStatement
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در تغییر وضعیت فروش", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscDataGrid1CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        if (e.FormattedValue.ToString() == "" || e.FormattedValue.ToString() == "0")
                            jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                        break;

                    case 4:
                        if (e.FormattedValue.ToString() == "")
                            jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در حال اعتبارسنجی سلول", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JscDataGrid1CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        if (jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) break;
                        int catid = Convert.ToInt32(jscDataGrid1.Rows[e.RowIndex].Cells["PCatID"].Value.ToString());

                        if (jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value != null)
                        {
                            var tmpDt = _relatedClass.DBFindProduct(
                                         Convert.ToInt32(jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value.ToString()));
                                if (catid.ToString() != tmpDt.Rows[0]["ProductCategoryID"].ToString())
                                {
                                    jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value = null;
                                    jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value = 0;
                                    jscDataGrid1.Rows[e.RowIndex].Cells["PPrice"].Value = 0;
                            }
                        }
                        var cell = (DataGridViewComboBoxCell) (jscDataGrid1.Rows[e.RowIndex].Cells["PID"]);
                        cell.DataSource =_relatedClass.DBFindCategory(catid);
                        break;

                    case 1:
                        if (jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) break;
                        var dt =_relatedClass.DBFindProduct(Int32.Parse(jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value.ToString()));
                        if (jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value == null 
                            || jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value.ToString() == "0")
                            jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value = 1;

                        jscDataGrid1.Rows[e.RowIndex].Cells["PCatID"].Value = dt.Rows[0]["ProductCategoryID"];
                        jscDataGrid1.Rows[e.RowIndex].Cells["PPrice"].Value = dt.Rows[0]["PPrice"];

                        jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value = "0";
                        if (!_creditSale)
                            jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value = dt.Rows[0]["PDiscount"];


                        break;
                }
                //lblFormTitle.Tag += Environment.NewLine + " <forValidating> :. " + _relatedClass.LastError;
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در اعتبار سنجی سلول ها", @"سامانه مدیریت سوپر مارکت");
                return ;
            }

            TotalSaleForRow(e.RowIndex);
            SaleTotalPrice();
        }

        private void JscDataGrid1RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value == null) e.Cancel = true;
        }

        private void JscDataGrid1RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = e.RowIndex;
        }

        private void LblFormTitleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lblFormTitle.Tag.ToString());
        }

        private void TabControl1Selected(object sender, TabControlEventArgs e)
        {
            jscDataGrid2.DataSource = _relatedClass.DBSalesReport();
            jscDataGrid2.Sort(jscDataGrid2.Columns[0], ListSortDirection.Ascending);
            //jscDataGrid2.Sort(newColumn, direction);
        }

        private void DateTimePicker1ValueChanged(object sender, EventArgs e)
        {

        }

        private void JSCLabel8Click(object sender, EventArgs e)
        {
            JscTxtTotalSale.Text = _relatedClass.DBSalesReportByDate(dateTimePicker1.Value.Year,
                                                         dateTimePicker1.Value.Month,
                                                         dateTimePicker1.Value.Day);
        }
    }
}