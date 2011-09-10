using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Products
{
    public partial class frm_Products_Add : JSuperMarket.frm_base_AddData
    {
        public frm_Products_Add()
        {
            InitializeComponent();
        }

        private void frm_Products_Add_Load(object sender, EventArgs e)
        {
            frm_Category_Class frmCategory = new frm_Category_Class();
            jscComboBox1.DataSource = frmCategory.DBSelect();
            jscComboBox1.DisplayMember = "ProductCategory";
            jscComboBox1.ValueMember = "ProductCategoryID";

            frm_Units.frm_Units_Class frmUnits = new frm_Units.frm_Units_Class();
            jscComboBox3.DataSource = frmUnits.DBSelect();
            jscComboBox3.DisplayMember = "ProductsUnit";
            jscComboBox3.ValueMember = "ProductsUnitID";
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "" || jscTextBox2.Text == "" || jscTextBox4.Text == "") 
            {
                jscTextBox1.BackColor = Color.Red;
                jscTextBox2.BackColor = Color.Red;
                jscTextBox4.BackColor = Color.Red;
                return;
            }

            frm_Products_Class RelatedClass = new frm_Products_Class();
            
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

            RelatedClass.DBAdd();
            //MessageBox.Show(RelatedClass.LastError);

            ((frm_Products)this.Owner).UpdateDateGrid();
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


        private void jscComboBox1_Enter(object sender, EventArgs e)
        {
            frm_Category_Class frmCategory = new frm_Category_Class();
            jscComboBox1.DataSource = frmCategory.DBSelect();
            jscComboBox1.DisplayMember = "ProductCategory";
            jscComboBox1.ValueMember = "ProductCategoryID";
        }

        private void jscComboBox3_Enter(object sender, EventArgs e)
        {
            frm_Units.frm_Units_Class frmUnits = new frm_Units.frm_Units_Class();
            jscComboBox3.DataSource = frmUnits.DBSelect();
            jscComboBox3.DisplayMember = "ProductsUnit";
            jscComboBox3.ValueMember = "ProductsUnitID";
        }

        private bool IsBarCode = false;
        private string Barcode = "";
        private void frm_Products_Add_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (e.KeyChar == '$')
            {
                IsBarCode = !IsBarCode;
                e.Handled = true;
                if (!IsBarCode)
                {
                    if (Barcode.Length > 7)
                    {
                        jsBarCodeBox1.Text = Barcode;
                        frm_Products_Class RelatedClass = new frm_Products_Class();
                        DataTable dt = RelatedClass.DBFindBarcode(Barcode);
                        if (dt.Rows.Count > 0)
                        {
                            Barcode = "";
                            jsBarCodeBox1.Text = "";
                            string messagetext = "این بارکد برای کالایی با نام '" + dt.Rows[0]["PName"].ToString() + "' ثبت شده است." + "\n"
                            + "لطفا بارکد درست را وارد کرده و یا بارکد قبلی را تصحیح نمایید " + "\n" + "احتمال ورود تکراری کالا هم می رود. به نام کالا دقت کنید";
                            MessageBox.Show(messagetext, "این بارکد متعلق است به " + dt.Rows[0]["PName"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    Barcode = "";
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
    }
}
