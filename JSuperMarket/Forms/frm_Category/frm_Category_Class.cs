using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JSuperMarket
{
    class frm_Category_Class
    {
        private string TableName = "dbo.tbl_SM_ProductsCategory";
        JSDataAccess JSDA = new JSDataAccess();
        public string LastError = "";
        public int _CID = 0;
        public string _CName = "";

        
        public DataTable DBSelect()
        {
            DataTable UsersData = new DataTable();
            UsersData = JSDA.DBSelectBySQL("Select * from " + this.TableName);
            return UsersData;
        }

        public void DBAdd()
        {
            string SQL = "Insert into " + this.TableName + " (ProductCategory) values (N'{0}')";
            SQL = string.Format(SQL,this._CName);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }
        
        public void DBDelete()
        {
            string SQL = "Delete from " + this.TableName + " where ProductCategoryID = {0}";
            SQL = string.Format(SQL, this._CID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }

        public void DBUpdate()
        {
            string SQL = "Update " + this.TableName + " Set ProductCategory = N'{0}' where ProductCategoryID = {1}";
            SQL = string.Format(SQL, this._CName, this._CID);
            JSDA.DBDoCommand(SQL);
            LastError += JSDA._LastError;
        }

        public void DBFind()
        {
            DataTable SelectedRecord = new DataTable();
            SelectedRecord = JSDA.DBSelectBySQL("Select * from " + this.TableName + " where ProductCategoryID = " + this._CID);
            this._CName = SelectedRecord.Rows[0]["ProductCategory"].ToString();
        }
    }
}
