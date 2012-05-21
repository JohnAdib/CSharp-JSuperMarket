using System;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Products;
using JSuperMarket.Forms.frm_Purchase;
using JSuperMarket.Forms.frm_Sales;

namespace JSuperMarket.Forms.frm_Base
{
    public partial class FrmMainForm : Form
    {
// ReSharper disable NotAccessedField.Local
        string _userCode = "";
// ReSharper restore NotAccessedField.Local
        readonly string _userFullName = "";
        public FrmMainForm(string usercode, string userfullname)
        {
            _userCode = usercode;
            _userFullName = userfullname;
            InitializeComponent();
        }
        


        private void FrmMainFormLoad(object sender, EventArgs e)
        {
            //jsctxtUser.Text += _userFullName;
        }




        private void Button4Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            var frmUnits = new frm_Units.FrmUnits();
            frmUnits.ShowDialog();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            var frmSupplier = new frm_Supplier.frm_Supplier();
            frmSupplier.ShowDialog();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            var frmCustomers = new frm_Customers.frm_Customers();
            frmCustomers.ShowDialog();
        }





        private void JscLabel2Click(object sender, EventArgs e)
        {
            var test = new Utility.Form1();
            test.ShowDialog();
        }

        private void JscTimer1Tick(object sender, EventArgs e)
        {
            // add shamsi date to main form
            var pc = new System.Globalization.PersianCalendar();
            string txtdate = @"امروز " + pc.GetYear(DateTime.Now) + @"/" + pc.GetMonth(DateTime.Now) + @"/" + pc.GetDayOfMonth(DateTime.Now);
            if (txtdate.Length <= jscTimer1.TickTimes) jscTimer1.Enabled = false;
            jsctxtDate.Text = txtdate.Substring(0, jscTimer1.TickTimes);
            
            // add current user to main form
            string txtuser = _userFullName;
            if (txtuser.Length <= jscTimer1.TickTimes) return;
            jsctxtUser.Text += txtuser.Substring(jscTimer1.TickTimes, 1);
        }

        private FrmSales _frmSales;
        private void OpenfrmSale(object sender, EventArgs e)
        {
            _frmSales = new FrmSales();
            _frmSales.FormClosed += FrmSalesClosed;
            _frmSales.Show();
            Hide();
        }
        void FrmSalesClosed(object sender, FormClosedEventArgs e)
        {
            _frmSales.Dispose();
            _frmSales = null;
            Show();
        }
        private FrmProducts _frmProducts;
        private void OpenFrmProducts(object sender, EventArgs e)
        {
            _frmProducts = new FrmProducts();
            //_frmProducts.FormClosed += FrmProductsClosed;
            Hide();
            _frmProducts.ShowDialog();
            Show();
        }
/*
        void FrmProductsClosed(object sender, FormClosedEventArgs e)
        {
            _frmProducts.Dispose();
            _frmProducts = null;
            Show();
        }
*/

        private void Button1Click(object sender, EventArgs e)
        {
            var frmCategory = new FrmCategory();
            frmCategory.ShowDialog();
        }

        private FrmPurchase _frmPurchase;
        private void OpenFrmPurchaseClick(object sender, EventArgs e)
        {
            _frmPurchase = new FrmPurchase();
            _frmPurchase.FormClosed += FrmPurchaseClosed;
            _frmPurchase.Show();
            Hide();
        }
        void FrmPurchaseClosed(object sender, FormClosedEventArgs e)
        {
            _frmPurchase.Dispose();
            _frmPurchase = null;
            Show();
        }

        private void LblFormTitleClick(object sender, EventArgs e)
        {
            var rptSales = new Rpt_Sales.FrmSalesReport();
            rptSales.ShowDialog();
        }

        private void Button9Click(object sender, EventArgs e)
        {
            var rptSales = new Rpt_Sales.FrmSalesReport();
            rptSales.ShowDialog();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            var frmSaleSetting = new FrmSalesSetting();
            frmSaleSetting.ShowDialog();
        }

        private void JsctxtUserClick(object sender, EventArgs e)
        {
            var frmtest = new Test1();
            frmtest.Show();
        }

    }
}
