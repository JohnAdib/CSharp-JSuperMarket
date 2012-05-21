using System;

namespace JSuperMarket.Forms.frm_Sales
{
    public partial class FrmSalesSetting : frm_Base.FrmBaseAddData
    {
        readonly FrmSalesClass _relatedClass = new FrmSalesClass();
        public FrmSalesSetting()
        {
            InitializeComponent();
            jscCmbCategory.DataSource = _relatedClass.DBCategoryList();
            jscCmbCategory.DisplayMember = "ProductCategory";
            jscCmbCategory.ValueMember = "ProductCategoryID";

            jscCmbProducts.DataSource = _relatedClass.DBSelectProducts();
            jscCmbProducts.DisplayMember = "PName";
            jscCmbProducts.ValueMember = "ProductID";
        }

        private void JSCHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSCAdd1Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.AppName = jscTxtAppname.Text;
                Properties.Settings.Default.Sales_DefaultCategory = jscCmbCategory.SValue;
                Properties.Settings.Default.Sales_DefaultProduct = jscCmbProducts.SValue;
                Properties.Settings.Default.Save();
                Close();
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void FrmSalesSettingLoad(object sender, EventArgs e)
        {
            try
            {
                Text = Properties.Settings.Default.AppNamePre +  @" " + Properties.Settings.Default.AppName;
                jscTxtAppname.Text = Properties.Settings.Default.AppName;
                jscCmbCategory.SelectedValue = Properties.Settings.Default.Sales_DefaultCategory;
                jscCmbProducts.SelectedValue = Properties.Settings.Default.Sales_DefaultProduct;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void JSCCmbCategoryTextChanged(object sender, EventArgs e)
        {
            jscCmbProducts.DataSource = _relatedClass.DBFindCategory(jscCmbCategory.SValue);
        }

        private void JSCCmbProductsTextChanged(object sender, EventArgs e)
        {
            
        }

        private void JSCCmbCategoryValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            jscCmbProducts.SelectedValue = 0;
        }

        private void JSCCmbProductsSelectedIndexChanged(object sender, EventArgs e)
        {
            //jscCmbCategory.SelectedValue = _relatedClass.DBFindProduct(jscCmbProducts.SValue).Rows[0]["ProductCategoryID"];
        }

    }
}
