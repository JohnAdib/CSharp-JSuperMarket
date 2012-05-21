using System.Data;

namespace JSuperMarket.frm_Sales
{
    class frm_Sales_Class
    {
        private const string PrimaryTable = "dbo.tbl_SM_Sales";
        private const string SecondTable = "dbo.tbl_SM_Sales-Products";
        readonly JSDataAccess JSDA = new JSDataAccess();
        public string LastError = "";

        // Table Sales
        public int _SID ;
        public string _Seller = "";
        public int _CID ;
        public string _SalesDesc = "";
        public bool _Credit = false;

        // Table Sales-Product
        public int _PID;
        public int _PCount = 1;
        public int _PSPrice = 0;

        public DataTable DBSelect()
        {
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }
        
        public DataTable DBSelectfromSecondary()
        {
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Sales-Products");
        }

        public void DBAddToPrimary()
        {
            string sql = "Insert into " + PrimaryTable + " ( SellerUser, CustomerID, SalesDesc, Credit ) "
                                        + " Values ( N'{0}', {1}, N'{2}', {3})";
            sql = string.Format(sql, this._Seller, this._CID, this._SalesDesc, this._Credit);
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;
            JSDA.DBSelectBySQL("Select * from " + PrimaryTable);

        }
        public void DBAddToSecondary()
        {
            string sql = "Insert into " + SecondTable + " ( SalesID, ProductID, ProductCount, ProductSalesPrice ) "
                            + " Values ( {0}, {1}, {2}, {3} )";
            sql = string.Format(sql, this._SID, this._PID, this._PCount, this._PSPrice);
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;
        }

        public void DBDelete()                               // delete sales from first and second table
        {
            string sql = "Delete from " + PrimaryTable + " where SalesID = {0}";
            sql = string.Format(sql, this._SID);
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;
        }                                                   // complete
        
        public void DBDeleteByProduct()
        {
            string sql = "Delete from " + SecondTable + " where SalesID = {0} AND ProductID = {1}";
            sql = string.Format(sql, this._SID, this._PID);
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;
        }

        public void DBUpdate()
        {

            string sql = "Update " + PrimaryTable + " Set SellerUser = N'{0}', CustomerID = {1}, SalesDesc = N'{2}', Credit = {3} "
                                                    + " where SalesID = {4}";
            sql = string.Format(sql, this._Seller, this._CID, this._SalesDesc, this._Credit, this._SID);
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;

            sql = "Update " + PrimaryTable + " Set ProductID = {0}, ProductCount = {1}, ProductSalesPrice = {2} "
                                        + " where SalesID = {4}";
            sql = string.Format(sql, this._PID, this._PCount, this._PSPrice, this._SID );
            JSDA.DBDoCommand(sql);
            LastError += JSDA._LastError;
        }

        public void DBFind()
        {
            var selectedRecord = new DataTable();
            //SelectedRecord = JSDA.DBSelectBySQL("Select * from " + this.TableName + " where ProductID = " + this._PID);

            //this._PName = SelectedRecord.Rows[0]["PName"].ToString();
            //Int32.TryParse(SelectedRecord.Rows[0]["ProductsUnitID"].ToString(), out this._PUID);
            //DateTime.TryParse(SelectedRecord.Rows[0]["PExpDate"].ToString(), out this._PExpDate);


        }

        public DataTable DBCategoryList()
        {
            return JSDA.DBSelectBySQL("SELECT dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory"
                + " FROM dbo.tbl_SM_ProductsCategory RIGHT OUTER JOIN"
                + " dbo.tbl_SM_Products ON dbo.tbl_SM_ProductsCategory.ProductCategoryID = dbo.tbl_SM_Products.ProductCategoryID"
                + " GROUP BY dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory");
        }

        public DataTable DBFindBarcode(string productBarcode)
        {
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Products where PBarCode = N'" + productBarcode + "'");
        }

        public DataTable DBFindCategory(int categoryID)
        {
            //if (categoryID == null) return null;
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductCategoryID = " + categoryID);
        }

        public DataTable DBFindProduct(int productID)
        {
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductID = " + productID);
        }

        public DataTable DBSelectProducts()
        {
            return JSDA.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }
    }
}
