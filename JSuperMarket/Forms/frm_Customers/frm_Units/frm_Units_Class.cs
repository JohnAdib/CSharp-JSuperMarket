using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JSuperMarket.Utility;

namespace JSuperMarket.frm_Units
{
    class frm_Units_Class
    {
        private string TableName = "dbo.tbl_SM_ProductsUnits";
        JSDataAccess JSDA = new JSDataAccess();
        public string LastError = "";
        public int _PUID = 0;
        public string _PUName = "";


        public DataTable DBSelect()
        {
            return JSDA.DBSelectBySQL("Select * from " + this.TableName);
        }

        public void DBAdd()
        {
            string SQL = "Insert into " + this.TableName + " (ProductsUnit) values (N'{0}')";
            SQL = string.Format(SQL, this._PUName);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBDelete()
        {
            string SQL = "Delete from " + this.TableName + " where ProductsUnitID = {0}";
            SQL = string.Format(SQL, this._PUID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBUpdate()
        {
            string SQL = "Update " + this.TableName + " Set ProductsUnit = N'{0}' where ProductsUnitID = {1}";
            SQL = string.Format(SQL, this._PUName, this._PUID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA.LastError;
        }

        public void DBFind()
        {
            DataTable SelectedRecord = new DataTable();
            SelectedRecord = JSDA.DBSelectBySQL("Select * from " + this.TableName + " where ProductsUnitID = " + this._PUID);
            this._PUName = SelectedRecord.Rows[0]["ProductsUnit"].ToString();
        }

        public int DBSearchRecord(string _FieldValue)
        {

            return JSDA.DBSelectBySQL("Select * from dbo.tbl_SM_Products where ProductsUnitID = " + _FieldValue).Rows.Count;
        }
    }
}
