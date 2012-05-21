using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Products
{
    public partial class frm_Products_Edit : JSuperMarket.frm_base_AddData
    {
        frm_Products_Class RelatedClass = new frm_Products_Class();
        public frm_Products_Edit(int PID, string PName, int PUID, int PCID, string PDesc, string Pbarcode, string Pmanuf, int PStock, int PSold, int PMin, int PBPrice, int PPrice, int PDiscount, DateTime PExpDate, string PSize)
        {
            InitializeComponent();

            frm_Units.frm_Units_Class frmUnits = new frm_Units.frm_Units_Class();
            jscComboBox3.DataSource = frmUnits.DBSelect();
            jscComboBox3.DisplayMember = "ProductsUnit";
            jscComboBox3.ValueMember = "ProductsUnitID";

            frm_Category_Class frmCategory = new frm_Category_Class();
            jscComboBox1.DataSource = frmCategory.DBSelect();
            jscComboBox1.DisplayMember = "ProductCategory";
            jscComboBox1.ValueMember = "ProductCategoryID";

            this.RelatedClass._PBarCode = Pbarcode;
            this.RelatedClass._PID = PID;
            // main fields
            jscTextBox1.Text = PName;
            jscTextBox2.Text = PPrice.ToString();
            jscTextBox3.Text = PDiscount.ToString();
            jscTextBox4.Text = PBPrice.ToString();
            jsBarCodeBox1.Text = Pbarcode.ToString();
            jscComboBox1.SelectedValue = PCID;
            jscComboBox3.SelectedValue = PUID;
            jscTextBox7.Text = PSize;

            // second fields
            jscTextBox5.Text = PStock.ToString();
            jscTextBox6.Text = PMin.ToString();
            jscTextBox8.Text = Pmanuf.ToString();
            jscTextBox10.Text = PDesc.ToString();
            maskedTextBox1.Text = PExpDate.ToString();        //check this ***

        }

        private void frm_Products_Edit_Load(object sender, EventArgs e)
        {

        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "" || jscTextBox2.Text == "" || jscTextBox4.Text == "")
            {
                jscTextBox1.BackColor = Color.Red;
                jscTextBox2.BackColor = Color.Red;
                jscTextBox4.BackColor = Color.Red;
                return;
            }
            // main fields
            RelatedClass._PName = jscTextBox1.Text;
            RelatedClass._PPrice = jscTextBox2.Number;
            RelatedClass._PDiscount = jscTextBox3.Number;
            RelatedClass._PBuyPrice = jscTextBox4.Number;
            RelatedClass._PUID = jscComboBox3.SValue;
            RelatedClass._PCID = jscComboBox1.SValue;
            RelatedClass._PSize = jscTextBox7.Text;
            RelatedClass._PBarCode = jsBarCodeBox1.Text;

            // second fields
            RelatedClass._PStock = jscTextBox5.Number;
            RelatedClass._PMin = jscTextBox6.Number;
            RelatedClass._PManufacture = jscTextBox8.Text;
            DateTime.TryParse(maskedTextBox1.Text, out RelatedClass._PExpDate);
            RelatedClass._PDesc = jscTextBox10.Text;

            RelatedClass.DBUpdate();
            //MessageBox.Show(RelatedClass.LastError);
            this.Close();
        }

        private bool IsBarCode = false;
        private string Barcode = "";
        private void frm_Products_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                try
                {
                    System.Globalization.CultureInfo elanguage = new System.Globalization.CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(elanguage);
                }
                catch (Exception ex) { string error = ex.Message; }

                IsBarCode = !IsBarCode;
                e.Handled = true;
                if (!IsBarCode)
                {
                    if (Barcode.Length > 7)
                    {
                        jsBarCodeBox1.Text = Barcode;
                    }
                    Barcode = "";

                    try
                    {
                        System.Globalization.CultureInfo flanguage = new System.Globalization.CultureInfo("fa-ir");
                        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(flanguage);
                    }
                    catch (Exception ex) { string error = ex.Message; }
                }
            }
            else if (IsBarCode)
            {
                Barcode += e.KeyChar;
                e.Handled = true;
            }
        }

        private void jscLabel13_Click(object sender, EventArgs e)
        {
            jsBarCodeBox1.Text = "";
        }

        private void jsBarCodeBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = RelatedClass.DBFindBarcode(Barcode);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["PBarCode"].ToString() != RelatedClass._PBarCode)
                {
                    Barcode = "";
                    jsBarCodeBox1.Text = RelatedClass._PBarCode;
                    string messagetext = "این بارکد برای کالایی با نام '" + dt.Rows[0]["PName"].ToString() + "' ثبت شده است." + Environment.NewLine
                    + "لطفا بارکد درست را وارد کرده و یا بارکد قبلی را تصحیح نمایید " + Environment.NewLine + 
                    "احتمال ورود تکراری کالا هم می رود. به نام کالا دقت کنید";
                    MessageBox.Show(messagetext, "این بارکد متعلق است به " + dt.Rows[0]["PName"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
