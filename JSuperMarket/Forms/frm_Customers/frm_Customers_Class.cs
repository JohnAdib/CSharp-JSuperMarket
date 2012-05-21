using System;
using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.frm_Customers
{
    class FrmCustomersClass
    {
        private const string TableName = "dbo.tbl_SM_Customers";
        readonly JSDataAccess JSDA = new JSDataAccess();
        public string LastError = "";
        public int _CID = 0;
        public string _CName = "";
        public string _CAddress = "";
        public string _CTel = "";
        public string _CMobile = "";
        public string _CDesc = "";
        public bool _Credit = false;
        


        public DataTable DBSelect()
        {
            return JSDA.DBSelectBySQL("Select * from " + TableName);
        }

        public void DBAdd()
        {
            string SQL = "Insert into " + TableName + " (CName, CAddress, CTel, CMobile, CDesc, Credit) "
                                        + "values ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', {5} )";
            SQL = string.Format(SQL, this._CName, this._CAddress, this._CTel, this._CMobile, this._CDesc, Convert.ToInt32(this._Credit));
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBDelete()
        {
            string SQL = "Delete from " + TableName + " where CustomerID = {0}";
            SQL = string.Format(SQL, this._CID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBUpdate()
        {
            string SQL = "Update " + TableName + " Set CName = N'{0}', CAddress = N'{1}', CTel = N'{2}', CMobile = N'{3}', CDesc = N'{4}', Credit = {5} "
                                   + " where CustomerID = {6}";
            SQL = string.Format(SQL, this._CName, this._CAddress, this._CTel, this._CMobile, this._CDesc, Convert.ToInt32(this._Credit), this._CID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBFind()
        {
            DataTable SelectedRecord = new DataTable();
            SelectedRecord = JSDA.DBSelectBySQL("Select * from " + TableName + " where CustomerID = " + this._CID);
            this._CName = SelectedRecord.Rows[0]["CName"].ToString();
            this._CAddress = SelectedRecord.Rows[0]["CAddress"].ToString();
            this._CTel = SelectedRecord.Rows[0]["CTel"].ToString();
            this._CMobile = SelectedRecord.Rows[0]["CMobile"].ToString();
            this._CDesc = SelectedRecord.Rows[0]["CDesc"].ToString();
            this._Credit = Convert.ToBoolean(SelectedRecord.Rows[0]["Credit"].ToString());
            
        }
    }
}
