using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Products
{
    public partial class FrmProductsEdit : FrmBaseAddData
    {
        readonly FrmProductsClass _relatedClass = new FrmProductsClass();
        public FrmProductsEdit(int pid, string pName, int puid, int pcid, string pDesc, string pbarcode, string pmanuf, int pStock, int pSold, int pMin, int pbPrice, int pPrice, int pDiscount, DateTime pExpDate, string pSize)
        {
            InitializeComponent();

            var frmUnits = new frm_Units.frm_Units_Class();
            jscComboBox3.DataSource = frmUnits.DBSelect();
            jscComboBox3.DisplayMember = "ProductsUnit";
            jscComboBox3.ValueMember = "ProductsUnitID";

            var frmCategory = new FrmCategoryClass();
            jscComboBox1.DataSource = frmCategory.DBSelect();
            jscComboBox1.DisplayMember = "ProductCategory";
            jscComboBox1.ValueMember = "ProductCategoryID";

            _relatedClass._PBarCode = pbarcode;
            _relatedClass._PID = pid;
            // main fields
            jscTextBox1.Text = pName;
            jscTextBox2.Text = pPrice.ToString();
            jscTextBox3.Text = pDiscount.ToString();
            jscTextBox4.Text = pbPrice.ToString();
            jsBarCodeBox1.Text = pbarcode;
            jscComboBox1.SelectedValue = pcid;
            jscComboBox3.SelectedValue = puid;
            jscTextBox7.Text = pSize;

            // second fields
            jscTextBox5.Text = pStock.ToString();
            jscTextBox6.Text = pMin.ToString();
            jscTextBox8.Text = pmanuf;
            jscTextBox10.Text = pDesc;
            maskedTextBox1.Text = pExpDate.ToString();        //check this ***

            ActiveControl = jscTextBox2;
        }

        private void FrmProductsEditLoad(object sender, EventArgs e)
        {
            
        }

        private void JSCClose1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSCUpdate1Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "" || jscTextBox2.Text == "" || jscTextBox4.Text == "")
            {
                jscTextBox1.BackColor = Color.Red;
                jscTextBox2.BackColor = Color.Red;
                jscTextBox4.BackColor = Color.Red;
                return;
            }
            // main fields
            _relatedClass._PName = jscTextBox1.Text;
            _relatedClass._PPrice = jscTextBox2.Number;
            _relatedClass._PDiscount = jscTextBox3.Number;
            _relatedClass._PBuyPrice = jscTextBox4.Number;
            _relatedClass._PUID = jscComboBox3.SValue;
            _relatedClass._PCID = jscComboBox1.SValue;
            _relatedClass._PSize = jscTextBox7.Text;
            _relatedClass._PBarCode = jsBarCodeBox1.Text;

            // second fields
            _relatedClass._PStock = jscTextBox5.Number;
            _relatedClass._PMin = jscTextBox6.Number;
            _relatedClass._PManufacture = jscTextBox8.Text;
            DateTime.TryParse(maskedTextBox1.Text, out _relatedClass._PExpDate);
            _relatedClass._PDesc = jscTextBox10.Text;

            _relatedClass.DBUpdate();
            //MessageBox.Show(RelatedClass.LastError);
            Close();
        }

        private bool _isBarCode;
        private string _barcode = "";
        private void FrmProductsEditKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                try
                {
                    var elanguage = new System.Globalization.CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
                }
                catch (Exception) {return; }

                _isBarCode = !_isBarCode;
                e.Handled = true;
                if (!_isBarCode)
                {
                    if (_barcode.Length > 7)
                    {
                        jsBarCodeBox1.Text = _barcode;
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

        private void JSCLabel13Click(object sender, EventArgs e)
        {
            jsBarCodeBox1.Text = "";
        }

        private void JSBarCodeBox1TextChanged(object sender, EventArgs e)
        {
            DataTable dt = _relatedClass.DBFindBarcode(_barcode);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["PBarCode"].ToString() != _relatedClass._PBarCode)
                {
                    _barcode = "";
                    jsBarCodeBox1.Text = _relatedClass._PBarCode;
                    string messagetext = "این بارکد برای کالایی با نام '" + dt.Rows[0]["PName"] + "' ثبت شده است." + Environment.NewLine
                    + "لطفا بارکد درست را وارد کرده و یا بارکد قبلی را تصحیح نمایید " + Environment.NewLine + 
                    "احتمال ورود تکراری کالا هم می رود. به نام کالا دقت کنید";
                    MessageBox.Show(messagetext, @"این بارکد متعلق است به " + dt.Rows[0]["PName"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
