using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_MainForm : Form
    {
        string UserCode = "";
        string UserFullName = "";
        public frm_MainForm(string _usercode, string _Userfullname)
        {
            this.UserCode = _usercode;
            this.UserFullName = _Userfullname;
            InitializeComponent();
        }

        private void frm_MainForm_Load(object sender, EventArgs e)
        {
            jscLabel1.Text += UserFullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Category frmCategory = new frm_Category();
            frmCategory.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test1 frmtest = new test1();
            frmtest.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Units.frm_Units frmUnits = new frm_Units.frm_Units();
            frmUnits.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_Supplier.frm_Supplier frmSupplier = new frm_Supplier.frm_Supplier();
            frmSupplier.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_Customers.frm_Customers frmCustomers = new frm_Customers.frm_Customers();
            frmCustomers.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Products.frm_Products frmProducts = new frm_Products.frm_Products();
            frmProducts.ShowDialog();
        }
    }
}
