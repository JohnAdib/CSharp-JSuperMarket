using System;
using System.Drawing;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;
using JSuperMarket.frm_Products;

namespace JSuperMarket.Forms.frm_Products
{
    public partial class FrmProducts : FrmBaseShowData
    {
        bool _initializement = true;
        string _totalRowsCount = "";
        readonly FrmProductsClass _relatedClass = new FrmProductsClass();
        public void UpdateDateGrid(bool filterByCategory = false)
        {
            
            if (_initializement)
            {
                jscDataGrid1.DataSource = _relatedClass.DBSelect();
//                 jscDataGrid1.Columns["ProductID"].Visible = false;
//                 jscDataGrid1.Columns["PBarCode"].Visible = false;
//                 jscDataGrid1.Columns["PSold"].Visible = false;
//                 jscDataGrid1.Columns["ProductsUnitID"].Visible = false;
//                 jscDataGrid1.Columns["ProductCategoryID"].Visible = false;
//                 jscDataGrid1.Columns["PExpDate"].Visible = false;
                _totalRowsCount = jscDataGrid1.Rows.Count.ToString();
                jscDataDesc.Text = @".در مجموع " + _totalRowsCount + @" قلم کالا ثبت شده است";

                _initializement = false;
            }
            else
            {
                int userSelectedRow = jscDataGrid1.CurrentCellAddress.Y;
                int categoryID = jscCmbCategory.SValue;
                if (filterByCategory && categoryID != 0)
                {
                    var dt = _relatedClass.DBFilterByCategory(categoryID);
                    if (dt.Rows.Count > 0)
                    {
                        jscDataGrid1.DataSource = _relatedClass.DBFilterByCategory(categoryID);
                        jscDataDesc.Text = @".در مجموع " + _totalRowsCount + @" قلم کالا ثبت شده است؛ که "
                            + jscDataGrid1.Rows.Count + @" مورد آن در دسته ی " + jscCmbCategory.Text + @" قرار دارد";
                    }
                    else
                        MessageBox.Show(@"کالایی در این دسته وجود ندارد", @"خطا");
                }
                else
                {
                    jscDataGrid1.DataSource = _relatedClass.DBSelect();
                    jscDataDesc.Text = @".در مجموع " + _totalRowsCount + @" قلم کالا ثبت شده است";
                }

                if (userSelectedRow > 0)
                {
                    if (userSelectedRow < jscDataGrid1.Rows.Count) jscDataGrid1.CurrentCell = jscDataGrid1["PName", userSelectedRow];
                        //jscDataGrid1.Rows[userSelectedRow].Selected = true;
                    else jscDataGrid1.Rows[jscDataGrid1.Rows.Count-1].Selected = true;

                }
            }
        }
        public FrmProducts()
        {
            InitializeComponent();
            jscDataGrid1.ColumnHeadersVisible = true;
            jscCmbCategory.DataSource = _relatedClass.DBCategoryList();
            jscCmbCategory.DisplayMember = "ProductCategory";
            jscCmbCategory.ValueMember = "ProductCategoryID";
            jscCmbCategory.SelectedValue = 0;
        }

        private void FrmProductsLoad(object sender, EventArgs e)
        {
            UpdateDateGrid(true);
        }

        private void JscHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JscDelete1Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            if (MessageBox.Show(@"مطمئنید؟", @"حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            //Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._PID);
            Int32.TryParse(jscDataGrid1.SelectedCells[0].Value.ToString(), out _relatedClass._PID);
            _relatedClass.DBDelete();
            UpdateDateGrid(true);
            jscDataGrid1.Focus();
        }

        private void JscDataGrid1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { JscDelete1Click(null, null); }
        }

        private void JscAdd1Click(object sender, EventArgs e)
        {
            var addform = new FrmProductsAdd {Owner = this};
            addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void JscUpdate1Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            Int32.TryParse(jscDataGrid1["ProductID", jscDataGrid1.CurrentRow.Index].Value.ToString(), out _relatedClass._PID);
            //Int32.TryParse(jscDataGrid1.SelectedCells[0].Value.ToString(), out RelatedClass._PID);

            _relatedClass.DBFind();
            var editForm = new FrmProductsEdit(_relatedClass._PID, _relatedClass._PName, _relatedClass._PUID, _relatedClass._PCID
                , _relatedClass._PDesc, _relatedClass._PBarCode, _relatedClass._PManufacture, _relatedClass._PStock
                , _relatedClass._pSold, _relatedClass._PMin, _relatedClass._PBuyPrice, _relatedClass._PPrice, _relatedClass._PDiscount, _relatedClass._PExpDate, _relatedClass._PSize);

            
            editForm.ShowDialog();
            UpdateDateGrid(true);
            jscDataGrid1.Focus();
        }

        private void FrmProductsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) JscUpdate1Click(null, null);            
            if (e.KeyCode == Keys.F4 && e.Alt == false) JscAdd1Click(null, null);
            if (e.KeyCode == Keys.F8) JscHome1Click(null, null);
            if (e.KeyCode == Keys.F12) jscCmbCategory.SelectedValue = 0;
        }

        private void JscLabel1Click(object sender, EventArgs e)
        {
            jscCmbCategory.SelectedValue = 0;
        }

        private void JscCmbCategorySelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateGrid(true);
        }

        private bool _isBarCode;
        private string _barcode = "";
        private void FrmProductsKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                try
                {
                    var elanguage = new System.Globalization.CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
                }
                catch (Exception ) { return;}

                _isBarCode = !_isBarCode;
                e.Handled = true;
                if (!_isBarCode)
                {
                    if (_barcode.Length > 7)
                    {
                        bool barcodeExist = false;
                        jscCmbCategory.SelectedValue = 0;
                        foreach (DataGridViewRow r in jscDataGrid1.Rows)
                        {
                            if (r.Cells["PBarCode"].Value == null) return;
                            if (r.Cells["PBarCode"].Value.ToString() == _barcode)
                            {
                                jscCmbCategory.SelectedValue = r.Cells["ProductCategoryID"].Value;
                                barcodeExist = true;
                            }
                        }
                        if (barcodeExist)
                        {
                            jscHighlightTimer.Enabled = true;
                            jscDataGrid1.ClearSelection();
                            foreach (DataGridViewRow r in jscDataGrid1.Rows)
                            {
                                if (r.Cells["PBarCode"].Value == null) return;
                                if (r.Cells["PBarCode"].Value.ToString() == _barcode)
                                {
                                    //jscDataGrid1.Rows[r.Index].Selected = true;
                                    jscDataGrid1.CurrentCell = jscDataGrid1["PName", r.Index];
                                    //jscDataGrid1.FirstDisplayedScrollingRowIndex = 2;

                                    jscDataDesc.Text += @". این بارکد برای کالایی با نام " + r.Cells["PName"].Value + @" ثبت گردیده است";
                                    JscUpdate1Click(null, null);
                                }
                            }
                        }
                        else
                        {
                            jscDataDesc.Text += @". کالایی با این بارکد ثبت نشده است";
                        }
                    }
                    _barcode = "";
                    try
                    {
                        var flanguage = new System.Globalization.CultureInfo("fa-ir");
                        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(flanguage);
                    }
                    catch (Exception) { return; }
                }
            }
            else if (_isBarCode)
            {

                _barcode += e.KeyChar;
                e.Handled = true;
            }
        }

        private void JscHighlightTimerTick(object sender, EventArgs e)
        {
            jscDataDesc.BackColor = jscHighlightTimer.TickTimes % 2 == 0 ? Color.DarkKhaki : Color.Transparent;
        }
    }
}
