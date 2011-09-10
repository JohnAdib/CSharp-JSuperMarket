using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JSuperMarket.frm_Supplier
{
    class frm_Supplier_Class
    {

        private string TableName = "dbo.tbl_SM_Suppliers";
        JSDataAccess JSDA = new JSDataAccess();
        public string LastError = "";
        public int _SID = 0;
        public string _SName = "";
        public string _SAddress = "";
        public string _STel = "";
        public string _SDesc = "";
        public string _SVisitor = "";


        public DataTable DBSelect()
        {
            return JSDA.DBSelectBySQL("Select * from " + this.TableName);
        }

        public void DBAdd()
        {
            string SQL = "Insert into " + this.TableName + " (SName, SAddress, STel, SDesc, SVisitor) "
                                        + "values ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}' )";
            SQL = string.Format(SQL, this._SName, this._SAddress, this._STel, this._SDesc, this._SVisitor);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }

        public void DBDelete()
        {
            string SQL = "Delete from " + this.TableName + " where SupplierID = {0}";
            SQL = string.Format(SQL, this._SID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }

        public void DBUpdate()
        {
            string SQL = "Update " + this.TableName + " Set SName = N'{0}', SAddress = N'{1}', STel = N'{2}', SDesc = N'{3}', SVisitor= N'{4}' "
                                   + "where SupplierID = {5}";
            SQL = string.Format(SQL, this._SName, this._SAddress, this._STel, this._SDesc, this._SVisitor, this._SID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }

        public void DBFind()
        {
            DataTable SelectedRecord = new DataTable();
            SelectedRecord = JSDA.DBSelectBySQL("Select * from " + this.TableName + " where SupplierID = " + this._SID);
            this._SName = SelectedRecord.Rows[0]["SName"].ToString();
            this._SAddress = SelectedRecord.Rows[0]["SAddress"].ToString();
            this._STel = SelectedRecord.Rows[0]["STel"].ToString();
            this._SDesc = SelectedRecord.Rows[0]["SDesc"].ToString();
            this._SVisitor = SelectedRecord.Rows[0]["SVisitor"].ToString();
        }
    }
}
