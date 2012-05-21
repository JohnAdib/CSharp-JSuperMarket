using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace JSuperMarket.frm_Products
{
    public partial class FrmProductsAdd : frm_base_AddData
    {
        public FrmProductsAdd()
        {
            InitializeComponent();
        }

        private void FrmProductsAddLoad(object sender, EventArgs e)
        {
            var frmCategory = new frm_Category_Class();
            jscComboBox1.DataSource = frmCategory.DBSelect();
            jscComboBox1.DisplayMember = "ProductCategory";
            jscComboBox1.ValueMember = "ProductCategoryID";

            var frmUnits = new frm_Units.frm_Units_Class();
            jscComboBox3.DataSource = frmUnits.DBSelect();
            jscComboBox3.DisplayMember = "ProductsUnit";
            jscComboBox3.ValueMember = "ProductsUnitID";
        }

        private void JscClose1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JscAdd1Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "" || jscTextBox2.Text == "" || jscTextBox4.Text == "") 
            {
                jscTextBox1.BackColor = Color.Red;
                jscTextBox2.BackColor = Color.Red;
                jscTextBox4.BackColor = Color.Red;
                return;
            }

            var relatedClass = new frm_Products_Class
                                   {
                                       _PName = jscTextBox1.Text,
                                       _PPrice = jscTextBox2.Number,
                                       _PDiscount = jscTextBox3.Number,
                                       _PBuyPrice = jscTextBox4.Number,
                                       _PUID = jscComboBox3.SValue,
                                       _PCID = jscComboBox1.SValue,
                                       _PSize = jscTextBox7.Text,
                                       _PBarCode = jsBarCodeBox1.Text,
                                       _PStock = jscTextBox5.Number,
                                       _PMin = jscTextBox6.Number,
                                       _PManufacture = jscTextBox8.Text
                                   };
            // second fields
            DateTime.TryParse(maskedTextBox1.Text, out relatedClass._PExpDate);
            relatedClass._PDesc = jscTextBox10.Text;

            relatedClass.DBAdd();
            //MessageBox.Show(RelatedClass.LastError);

            
            if (Owner != null)
            {
                ((FrmProducts)Owner).UpdateDateGrid(true);
            }
            // above code update data grid view in main form
            jscTextBox1.Text = "";
            jscTextBox2.Text = "";
            jscTextBox3.Text = "";
            jscTextBox4.Text = "";
            jscTextBox5.Text = "";
            jscTextBox6.Text = "";
            jscTextBox7.Text = "";
            jscTextBox8.Text = "";
            jscTextBox10.Text = "";
            jsBarCodeBox1.Text = "";
            jscTextBox1.Focus();
        }

        private bool _isBarCode;
        private string _barcode = "";
        private void FrmProductsAddKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                try
                {
                    var elanguage = new System.Globalization.CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
                }
                catch (Exception) { return; }

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

        private void JscLabel13Click(object sender, EventArgs e)
        {
            jsBarCodeBox1.Text = "";
        }

        private void JsBarCodeBox1TextChanged(object sender, EventArgs e)
        {
            var relatedClass = new frm_Products_Class();
            DataTable dt = relatedClass.DBFindBarcode(jsBarCodeBox1.Text);
            if (dt.Rows.Count > 0)
            {
                _barcode = "";
                jsBarCodeBox1.Text = "";
                string messagetext = @"این بارکد برای کالایی با نام '" + dt.Rows[0]["PName"] + @"' ثبت شده است." + "\n"
                + @"لطفا بارکد درست را وارد کرده و یا بارکد قبلی را تصحیح نمایید " + "\n" + @"احتمال ورود تکراری کالا هم می رود. به نام کالا دقت کنید";
                MessageBox.Show(messagetext, @"این بارکد متعلق است به " + dt.Rows[0]["PName"], MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
