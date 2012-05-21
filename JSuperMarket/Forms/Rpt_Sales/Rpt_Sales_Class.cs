using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.Forms.Rpt_Sales
{
    class RptSalesClass
    {
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";

        public DataTable DBSelect()
        {
            var result =_jsda.DBSelectBySQL("SELECT MIN(YEAR(dbo.tbl_SM_Sales.SalesTime)) AS Year, MONTH(dbo.tbl_SM_Sales.SalesTime) AS Month" +
                                       ", DAY(dbo.tbl_SM_Sales.SalesTime) AS Day, SUM(dbo.tbl_SM_SalesProducts.ProductSalesPrice) AS TotalSales" +
                                       " FROM dbo.tbl_SM_Sales INNER JOIN  dbo.tbl_SM_SalesProducts ON dbo.tbl_SM_Sales.SalesID = dbo.tbl_SM_SalesProducts.SalesID" +
                                       " GROUP BY DAY(dbo.tbl_SM_Sales.SalesTime), MONTH(dbo.tbl_SM_Sales.SalesTime)" +
                                       " ORDER BY Year, Month, Day");
            LastError += _jsda.LastError;
            return result;
        }
    }
}
