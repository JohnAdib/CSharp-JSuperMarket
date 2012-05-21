using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Products;

namespace JSuperMarket.Forms.frm_Purchase
{
    public partial class FrmPurchase : frm_Base.FrmBaseShowData
    {
        readonly FrmPurchaseClass _relatedClass = new FrmPurchaseClass();
        int _currentRow;
        public FrmPurchase()
        {
            InitializeComponent();
            jscCmbSupplier.DataSource = _relatedClass.DBSupplierList();
            jscCmbSupplier.DisplayMember = "SName";
            jscCmbSupplier.ValueMember = "SupplierID";
            jscCmbSupplier.SelectedValue = 0;
            {
                var newColumn = new DataGridViewComboBoxColumn
                {
                    Name = "PCatID",
                    HeaderText = @"دسته",
                    DataSource = _relatedClass.DBCategoryList(),
                    DisplayMember = "ProductCategory",
                    ValueMember = "ProductCategoryID",
                    MinimumWidth = 100,
                    Width = 105
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
                    MinimumWidth = 30,
                    Width = 40
                };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                {
                    Name = "PPrice",
                    HeaderText = @"قیمت خرید",
                    MinimumWidth = 50,
                    Width = 65,

                };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                {
                    Name = "PSPrice",
                    HeaderText = @"قیمت فروش",
                    MinimumWidth = 50,
                    Width = 65,

                };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                {
                    Name = "PDiscount",
                    HeaderText = @"تخفیف",
                    MinimumWidth = 50,
                    Width = 65,

                };
                jscDataGrid1.Columns.Add(newColumn);
            }
            {
                var newColumn = new DataGridViewTextBoxColumn
                {
                    Name = "RTPrice",
                    HeaderText = @"مجموع",
                    MinimumWidth = 70,
                    Width = 80,
                    ReadOnly = true
                };
                jscDataGrid1.Columns.Add(newColumn);
            }

        }

        private void FrmPurchaseLoad(object sender, EventArgs e)
        {

        }

        private void JSCAdd1Click(object sender, EventArgs e)
        {
            try
            {
                if (jscCmbSupplier.Text == "")
                {
                    jscHighlightTimer.Enabled = true;
                    //jsclblSupplier.BackColor = Color.Red;
                    return;
                }
                // add to db and update prices

                var relatedClass = new FrmPurchaseClass
                                       {
                                           Sid = jscCmbSupplier.SValue,
                                           PDesc = jscTextBox1.Text
                                       };
                relatedClass.DBAddToPrimary();

                for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++)
                // for update each product data
                {
                    DataGridViewRow row = jscDataGrid1.Rows[index];

                    if (row.Cells["PID"].Value == null) continue;
                    relatedClass.Productid = Convert.ToInt32(row.Cells["PID"].Value);

                    if (row.Cells["PCount"].Value == null) continue;
                    relatedClass.PCount = Convert.ToInt32(row.Cells["PCount"].Value) +
                                          Convert.ToInt32(relatedClass.DBFindProduct(relatedClass.Productid).Rows[0]["ProductCategoryID"]);

                    if (row.Cells["PPrice"].Value == null) continue;
                    relatedClass.PPrice = Convert.ToInt32(row.Cells["PPrice"].Value);

                    if (row.Cells["PSPrice"].Value == null) continue;
                    relatedClass.PsPrice = Convert.ToInt32(row.Cells["PSPrice"].Value);

                    if (row.Cells["PDiscount"].Value == null) continue;
                    relatedClass.PDiscount = Convert.ToInt32(row.Cells["PDiscount"].Value);

                    relatedClass.DBAddToSecondary();
                    relatedClass.UpdateProducts();
                }
                // clear input data
                jsclblSupplier.BackColor = Color.Transparent;
                jscCmbSupplier.SelectedValue = 0;
                jscDataGrid1.Rows.Clear();
                jsBarCodeBox1.Text = "";
                jscTextBox1.Text = "";
                jscTPrice.Text = @"0";
                jscTextBox1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در اضافه کردن خرید جدید", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JSCDelete1Click(object sender, EventArgs e)
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

        private void JSCHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSCDataGrid1RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = e.RowIndex;
        }

        private bool _isBarCode;
        private string _barcode = "";
        private void FrmPurchaseKeyPress(object sender, KeyPressEventArgs e)
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
                        catch (Exception)
                        {
                            return;
                        }
                    }
                }
                else if (_isBarCode)
                {
                    e.Handled = true;
                    _barcode += e.KeyChar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در خواندن اطلاعات از کاربر", @"سامانه مدیریت سوپر مارکت");
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
                        var frmaddproduct = new FrmProductsAdd { Barcode = jsBarCodeBox1.Text };
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
                    jscDataGrid1.Rows.Add(dt.Rows[0]["ProductCategoryID"], dt.Rows[0]["ProductID"], "1", dt.Rows[0]["PBuyPrice"],
                                          Convert.ToInt32(dt.Rows[0]["PPrice"]), Convert.ToInt32(dt.Rows[0]["PDiscount"]),
                                           dt.Rows[0]["PPrice"]);
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
                                * Convert.ToInt32(jscDataGrid1.Rows[rowNumber].Cells["PPrice"].Value);
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
                for (int index = 0; index < jscDataGrid1.Rows.Count - 1; index++)
                // for calc totalprice and totaldiscount
                {
                    DataGridViewRow row = jscDataGrid1.Rows[index];
                    //if (jscDataGrid1.Rows.Count - 1 == row.Index) break;
                    if (row.Cells["RTPrice"].Value == null) continue;
                    saletotalprice += Convert.ToInt32(row.Cells["RTPrice"].Value);
                }
                jscTPrice.Text = saletotalprice.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در محاسبه جمع کل فروش", @"سامانه مدیریت سوپر مارکت");
                return;
            }
        }

        private void JSCDataGrid1Enter(object sender, EventArgs e)
        {
            var elanguage = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);

        }

        private void FrmPurchaseKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) JSCDelete1Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) JSCAdd1Click(null, null);
            if (e.KeyCode == Keys.F8) JSCHome1Click(null, null);
        }

        private void JSCDataGrid1CellValidated(object sender, DataGridViewCellEventArgs e)
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
                                jscDataGrid1.Rows[e.RowIndex].Cells["PSPrice"].Value = 0;
                                jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value = 0;
                            }
                        }
                        var cell = (DataGridViewComboBoxCell)(jscDataGrid1.Rows[e.RowIndex].Cells["PID"]);
                        cell.DataSource = _relatedClass.DBFindCategory(catid);
                        break;

                    case 1:
                        if (jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) break;
                        var dt = _relatedClass.DBFindProduct(Int32.Parse(jscDataGrid1.Rows[e.RowIndex].Cells["PID"].Value.ToString()));
                        
                        if (jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value == null
                            || jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value.ToString() == "0")
                            jscDataGrid1.Rows[e.RowIndex].Cells["PCount"].Value = 1;


                        if (jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value == null
                            || jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value.ToString() == "0")
                            jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value = 1;

                        jscDataGrid1.Rows[e.RowIndex].Cells["PCatID"].Value = dt.Rows[0]["ProductCategoryID"];
                        jscDataGrid1.Rows[e.RowIndex].Cells["PPrice"].Value = dt.Rows[0]["PBuyPrice"];
                        jscDataGrid1.Rows[e.RowIndex].Cells["PSPrice"].Value = dt.Rows[0]["PPrice"];
                        jscDataGrid1.Rows[e.RowIndex].Cells["PDiscount"].Value = 0;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در اعتبار سنجی سلول ها", @"سامانه مدیریت سوپر مارکت");
                return;
            }

            TotalSaleForRow(e.RowIndex);
            SaleTotalPrice();

        }

        private void JSCDataGrid1CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        if (e.FormattedValue.ToString() == "" || e.FormattedValue.ToString() == "0")
                            jscDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در حال اعتبارسنجی سلول", @"سامانه مدیریت سوپر مارکت");
                return;
            }

        }

        private void JSCHighlightTimerTick(object sender, EventArgs e)
        {
            jsclblSupplier.BackColor = jscHighlightTimer.TickTimes % 2 == 0 ? Color.DarkKhaki : Color.Transparent;
        }
    }
}
