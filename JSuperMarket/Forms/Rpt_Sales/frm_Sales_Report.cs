using System;

namespace JSuperMarket.Forms.Rpt_Sales
{
    public partial class FrmSalesReport : frm_Base.FrmBaseShowData
    {
        readonly RptSalesClass _relatedClass = new RptSalesClass();

        public FrmSalesReport()
        {
            InitializeComponent();
        }

        private void BtnRptSalesClick(object sender, EventArgs e)
        {
            jscDataGrid1.DataSource = _relatedClass.DBSelect();
            System.Windows.Forms.MessageBox.Show(_relatedClass.LastError);
        }

        private void FrmSalesReportLoad(object sender, EventArgs e)
        {
            jscDataGrid1.DataSource = _relatedClass.DBSelect();
        }

    }
}
