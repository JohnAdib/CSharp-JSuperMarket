using System;
using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Sales
{
    class FrmSalesClass
    {
        private const string PrimaryTable = "dbo.tbl_SM_Sales";
        private const string SecondTable = "dbo.tbl_SM_SalesProducts";
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";

        // Table Sales
        public int Sid ;
        public string Seller = "";
        public int Cid ;
        public string SalesDesc = "";
        public bool Credit;

        // Table Sales-Product
        public int Pid;
        public int PCount = 1;
        public int PsPrice;

        public DataTable DBSelect()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }
        
        public DataTable DBSelectfromSecondary()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Sales-Products");
        }

        public int DBAddToPrimary()
        {
            string sql = "Insert into " + PrimaryTable + " ( SellerUser, CustomerID, SalesDesc, Credit ) "
                                        + " Values ( N'{0}', {1}, N'{2}', {3})";
            sql = string.Format(sql, Seller, Cid, SalesDesc, Convert.ToInt32(Credit));
            _jsda.DBDoCommand(sql, true);
            LastError += _jsda.LastError;
            return _jsda.Identity;
        }

        public void DBAddToSecondary()
        {
            string sql = "Insert into " + SecondTable + " ( SalesID, ProductID, ProductCount, ProductSalesPrice ) "
                            + " Values ( {0}, {1}, {2}, {3} )";
            sql = string.Format(sql, _jsda.Identity, Pid, PCount, PsPrice);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBDelete()                               // delete sales from first and second table
        {
            string sql = "Delete from " + PrimaryTable + " where SalesID = {0}";
            sql = string.Format(sql, Sid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }                                                   // complete
        
        public void DBDeleteByProduct()
        {
            string sql = "Delete from " + SecondTable + " where SalesID = {0} AND ProductID = {1}";
            sql = string.Format(sql, Sid, Pid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBUpdate()
        {

            string sql = "Update " + PrimaryTable + " Set SellerUser = N'{0}', CustomerID = {1}, SalesDesc = N'{2}', Credit = {3} "
                                                    + " where SalesID = {4}";
            sql = string.Format(sql, Seller, Cid, SalesDesc, Credit, Sid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;

            sql = "Update " + SecondTable + " Set ProductID = {0}, ProductCount = {1}, ProductSalesPrice = {2} "
                                        + " where SalesID = {4}";
            sql = string.Format(sql, Pid, PCount, PsPrice, Sid );
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }


        public DataTable DBCategoryList()
        {
            return _jsda.DBSelectBySQL("SELECT dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory"
                + " FROM dbo.tbl_SM_ProductsCategory RIGHT OUTER JOIN"
                + " dbo.tbl_SM_Products ON dbo.tbl_SM_ProductsCategory.ProductCategoryID = dbo.tbl_SM_Products.ProductCategoryID"
                + " GROUP BY dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory");
        }

        public DataTable DBCustomerList()
        {
            return _jsda.DBSelectBySQL("SELECT CustomerID, CName FROM dbo.tbl_SM_Customers");
        }

        public DataTable DBFindBarcode(string productBarcode)
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where PBarCode = N'" + productBarcode + "'");
        }

        public DataTable DBFindCategory(int categoryID)
        {
            //if (categoryID == null) return null;
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductCategoryID = " + categoryID);
        }

        public DataTable DBFindProduct(int productID)
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductID = " + productID);
        }

        public DataTable DBSelectProducts()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }

        public DataTable DBSalesReport()
        {
            var result = _jsda.DBSelectBySQL("SELECT MIN(YEAR(dbo.tbl_SM_Sales.SalesTime)) AS Year, MONTH(dbo.tbl_SM_Sales.SalesTime) AS Month" +
                                       ", DAY(dbo.tbl_SM_Sales.SalesTime) AS Day, SUM(dbo.tbl_SM_SalesProducts.ProductSalesPrice * dbo.tbl_SM_SalesProducts.ProductCount) AS TotalSales" +
                                       " FROM dbo.tbl_SM_Sales INNER JOIN  dbo.tbl_SM_SalesProducts ON dbo.tbl_SM_Sales.SalesID = dbo.tbl_SM_SalesProducts.SalesID" +
                                       " GROUP BY DAY(dbo.tbl_SM_Sales.SalesTime), MONTH(dbo.tbl_SM_Sales.SalesTime)");
            LastError += _jsda.LastError;
            return result;
        }

        public string DBSalesReportByDate(int year, int month, int day)
        {
            return _jsda.DBSelectBySQL(
                    "SELECT dbo.tbl_SM_SalesProducts.ProductSalesPrice * dbo.tbl_SM_SalesProducts.ProductCount AS TotalSales" +
                    " FROM dbo.tbl_SM_SalesProducts INNER JOIN dbo.tbl_SM_Sales ON dbo.tbl_SM_SalesProducts.SalesID = dbo.tbl_SM_Sales.SalesID" +
                    " year(dbo.tbl_SM_Sales.SalesTime)='" + year + "' and month(dbo.tbl_SM_Sales.SalesTime)='" + month +
                    "' and day(dbo.tbl_SM_Sales.SalesTime)='" + day + "'").Rows[0]["TotalSales"].ToString();
        }
    }
}
