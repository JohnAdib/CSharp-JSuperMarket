using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket
{
    class FrmCategoryClass
    {
        private const string TableName = "dbo.tbl_SM_ProductsCategory";
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";
        public int Cid;
        public string CName = "";

        
        public DataTable DBSelect()
        {
            var UsersData = new DataTable();
            UsersData = _jsda.DBSelectBySQL("Select * from " + TableName);
            return UsersData;
        }

        public void DBAdd()
        {
            string sql = "Insert into " + TableName + " (ProductCategory) values (N'{0}')";
            sql = string.Format(sql,CName);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }
        
        public void DBDelete()
        {
            string sql = "Delete from " + TableName + " where ProductCategoryID = {0}";
            sql = string.Format(sql, Cid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBUpdate()
        {
            string sql = "Update " + TableName + " Set ProductCategory = N'{0}' where ProductCategoryID = {1}";
            sql = string.Format(sql, CName, Cid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBFind()
        {
            DataTable selectedRecord = _jsda.DBSelectBySQL("Select * from " + TableName + " where ProductCategoryID = " + Cid);
            CName = selectedRecord.Rows[0]["ProductCategory"].ToString();
        }

        public int DBSearchRecord(string fieldValue)
        {

            return _jsda.DBSelectBySQL("Select * from dbo.tbl_SM_Products where ProductCategoryID = " + fieldValue).Rows.Count;
        }
    }
}
