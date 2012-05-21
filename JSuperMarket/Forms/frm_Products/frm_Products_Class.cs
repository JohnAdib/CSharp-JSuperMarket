using System;
using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.frm_Products
{
    class FrmProductsClass
    {
        private const string TableName = "dbo.tbl_SM_Products";
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";

        public int _PID;
        public string _PName = "";
        public int _PUID;
        public int _PCID;
        public DateTime _PExpDate;
        public string _PDesc = "";
        public string _PBarCode = "";
        public string _PManufacture = "";
        public int _PStock = -1;
        public int _pSold;
        public int _PMin = 1;
        public int _PBuyPrice;
        public int _PPrice;
        public int _PDiscount;
        public string _PSize = "36";

        public DataTable DBSelect()
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }

        public DataTable DBAdd()
        {
             string sql = "Insert into " + TableName + " ( PName, ProductsUnitID, PDesc, PBarCode,"
                                         + " PManufacturer, PStock, PSold, PMinInventory, PBuyPrice, PPrice, PDiscount, PExpDate, PSize, ProductCategoryID )"
                                         + " Values ( N'{0}', {1}, N'{2}', N'{3}', N'{4}', {5}, {6}, {7}, {8}, {9}, {10}, '{11}', '{12}', {13})";
             sql = string.Format(sql, _PName, _PUID, _PDesc, _PBarCode,
                                      _PManufacture, _PStock, _pSold, _PMin, _PBuyPrice, _PPrice, _PDiscount, _PExpDate, _PSize, _PCID);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products");
        }

        public void DBDelete()
        {
            string SQL = "Delete from " + TableName + " where ProductID = {0}";
            SQL = string.Format(SQL, this._PID);
            _jsda.DBDoCommand(SQL);
            LastError += _jsda.LastError;
        }

        public void DBUpdate()
        {

            string SQL = "Update " + TableName + " Set PName = N'{0}', ProductsUnitID = {1}, PDesc = N'{2}', PBarCode = N'{3}',"
                                                    + " PManufacturer = N'{4}', PStock = {5}, PSold = {6}, PMinInventory = {7}, PBuyPrice = {8}, PPrice = {9}, PDiscount = {10} , PSize = '{11}', ProductCategoryID = {12} "
                                                    + " where ProductID = {13}";
            SQL = string.Format(SQL, this._PName, this._PUID, this._PDesc, this._PBarCode,
                                     this._PManufacture, this._PStock, this._pSold, this._PMin, this._PBuyPrice, this._PPrice, this._PDiscount,this._PSize,this._PCID, this._PID);
            _jsda.DBDoCommand(SQL);
            LastError += _jsda.LastError;
        }

        public void DBFind()
        {
            DataTable SelectedRecord = new DataTable();
            SelectedRecord = _jsda.DBSelectBySQL("Select * from " + TableName + " where ProductID = " + this._PID);

            this._PName = SelectedRecord.Rows[0]["PName"].ToString();
            Int32.TryParse(SelectedRecord.Rows[0]["ProductsUnitID"].ToString(), out this._PUID);
            Int32.TryParse(SelectedRecord.Rows[0]["ProductCategoryID"].ToString(), out this._PCID);
            this._PSize = SelectedRecord.Rows[0]["PSize"].ToString();
            DateTime.TryParse(SelectedRecord.Rows[0]["PExpDate"].ToString(), out this._PExpDate);

            this._PDesc = SelectedRecord.Rows[0]["PDesc"].ToString();
            this._PBarCode = SelectedRecord.Rows[0]["PBarCode"].ToString();
            this._PManufacture = SelectedRecord.Rows[0]["PManufacturer"].ToString();

            Int32.TryParse(SelectedRecord.Rows[0]["PStock"].ToString(), out this._PStock);
            Int32.TryParse(SelectedRecord.Rows[0]["PSold"].ToString(), out this._pSold);
            Int32.TryParse(SelectedRecord.Rows[0]["PMinInventory"].ToString(), out this._PMin);

            Int32.TryParse(SelectedRecord.Rows[0]["PBuyPrice"].ToString(), out this._PBuyPrice);
            Int32.TryParse(SelectedRecord.Rows[0]["PPrice"].ToString(), out this._PPrice);
            Int32.TryParse(SelectedRecord.Rows[0]["PDiscount"].ToString(), out this._PDiscount);

        }
        
        public DataTable DBFindBarcode(string ProductBarcode)
        {
            LastError += _jsda.LastError;
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Barcodes where PBarCode = N'" + ProductBarcode + "'");
        }

        public DataTable DBCategoryList()
        {
            return _jsda.DBSelectBySQL("SELECT dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory"
                + " FROM dbo.tbl_SM_ProductsCategory RIGHT OUTER JOIN"
                + " dbo.tbl_SM_Products ON dbo.tbl_SM_ProductsCategory.ProductCategoryID = dbo.tbl_SM_Products.ProductCategoryID"
                + " GROUP BY dbo.tbl_SM_ProductsCategory.ProductCategoryID, dbo.tbl_SM_ProductsCategory.ProductCategory");
        }

        public DataTable DBFilterByCategory(int CategoryID)
        {
            return _jsda.DBSelectBySQL("Select * from dbo.View_SM_Products where ProductCategoryID = " + CategoryID );
                
        }
    }
}
