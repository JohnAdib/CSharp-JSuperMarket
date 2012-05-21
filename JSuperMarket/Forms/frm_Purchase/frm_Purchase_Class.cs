using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Purchase
{
    class FrmPurchaseClass
    {
        private const string PrimaryTable = "dbo.tbl_SM_Purchases";
        private const string SecondTable = "dbo.tbl_SM_PurchasesProducts";
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";

        // Table Purchase
        public int PurchaseID;
        public int Sid;
        public string PDesc;

        // Table purchase-product and product
        public int Productid;
        public int PCount = 1;
        public int PPrice;
        public int PsPrice;
        public int PDiscount;


        public DataTable DBSelect()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.tbl_SM_Purchases");
        }

        public DataTable DBSelectfromSecondary()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.tbl_SM_Purchases-Products");
        }

        public int DBAddToPrimary()
        {
            string sql = "Insert into " + PrimaryTable + " ( SupplierID, PurchaseDesc ) "
                                        + " Values ( {0}, N'{1}' )";
            sql = string.Format(sql, Sid, PDesc);
            _jsda.DBDoCommand(sql, true);
            LastError += _jsda.LastError;
            return _jsda.Identity;
        }

        public void DBAddToSecondary()
        {
            string sql = "Insert into " + SecondTable + " ( PurchasesID, ProductID, ProductCount, PPrice ) "
                            + " Values ( {0}, {1}, {2}, {3})";
            sql = string.Format(sql, _jsda.Identity, Productid, PCount, PPrice);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void UpdateProducts()
        {
            string sql = "Update tbl_SM_Products Set PStock = {0}, PBuyPrice = {1}, PPrice = {2}, PDiscount = {3}"
                                                    + " where ProductID = {4}";
            sql = string.Format(sql, PCount,PPrice, PsPrice, PDiscount,Productid);            // check this
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBDelete()                               // delete sales from first and second table
        {
            string sql = "Delete from " + PrimaryTable + " where PurchasesID = {0}";
            sql = string.Format(sql, PurchaseID);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }                                                   // complete

        public void DBDeleteFromSecondary()
        {
            string sql = "Delete from " + SecondTable + " where PurchasesID = {0} AND ProductID = {1}";
            sql = string.Format(sql, PurchaseID, Productid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBUpdate()
        {

            string sql = "Update " + PrimaryTable + " Set SupplierID = {0}, PurchaseDesc = N'{1}' "
                                                    + " where PurchasesID = {2}";
            sql = string.Format(sql, Sid, PDesc, PurchaseID);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        private void Test()
        {
            PurchaseID = 0;
            Productid = 0;
            PCount = 0;
            PPrice = 0;
        }

        public DataTable DBFindProduct(int productID)
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductID = " + productID);
        }

        public DataTable DBFindCategory(int categoryID)
        {
            //if (categoryID == null) return null;
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductCategoryID = " + categoryID);
        }

        public DataTable DBCategoryList()
        {
            return _jsda.DBSelectBySQL("SELECT dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory"
                + " FROM dbo.tbl_SM_ProductsCategory RIGHT OUTER JOIN"
                + " dbo.tbl_SM_Products ON dbo.tbl_SM_ProductsCategory.ProductCategoryID = dbo.tbl_SM_Products.ProductCategoryID"
                + " GROUP BY dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory");
        }

        public DataTable DBSupplierList()
        {
            return _jsda.DBSelectBySQL("SELECT SupplierID, SName FROM dbo.tbl_SM_Suppliers");
        }

        public DataTable DBFindBarcode(string productBarcode)
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where PBarCode = N'" + productBarcode + "'");
        }

        public DataTable DBSelectProducts()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }

    }
}
