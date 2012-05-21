using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.frm_Supplier
{
    class FrmSupplierClass
    {
        private const string TableName = "dbo.tbl_SM_Suppliers";
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string LastError = "";
        public int Sid;
        public string SName = "";
        public string SAddress = "";
        public string STel = "";
        public string SDesc = "";
        public string SVisitor = "";


        public DataTable DBSelect()
        {
            return _jsda.DBSelectBySQL("Select * from " + TableName);
        }

        public void DBAdd()
        {
            string sql = "Insert into " + TableName + " (SName, SAddress, STel, SDesc, SVisitor) "
                                        + "values ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}' )";
            sql = string.Format(sql, SName, SAddress, STel, SDesc, SVisitor);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBDelete()
        {
            string sql = "Delete from " + TableName + " where SupplierID = {0}";
            sql = string.Format(sql, Sid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBUpdate()
        {
            string sql = "Update " + TableName + " Set SName = N'{0}', SAddress = N'{1}', STel = N'{2}', SDesc = N'{3}', SVisitor= N'{4}' "
                                   + "where SupplierID = {5}";
            sql = string.Format(sql, SName, SAddress, STel, SDesc, SVisitor, Sid);
            _jsda.DBDoCommand(sql);
            LastError += _jsda.LastError;
        }

        public void DBFind()
        {
            var SelectedRecord = new DataTable();
            SelectedRecord = _jsda.DBSelectBySQL("Select * from " + TableName + " where SupplierID = " + Sid);
            SName = SelectedRecord.Rows[0]["SName"].ToString();
            SAddress = SelectedRecord.Rows[0]["SAddress"].ToString();
            STel = SelectedRecord.Rows[0]["STel"].ToString();
            SDesc = SelectedRecord.Rows[0]["SDesc"].ToString();
            SVisitor = SelectedRecord.Rows[0]["SVisitor"].ToString();
        }

        public int DBSearchRecord(string fieldValue)
        {

            return _jsda.DBSelectBySQL("Select * from dbo.tbl_SM_Purchases where SupplierID = " + fieldValue).Rows.Count;
        }
    }
}
