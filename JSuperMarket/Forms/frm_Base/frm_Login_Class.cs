using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JSuperMarket
{
    class frm_Login_Class
    {
        JSDataAccess JSDA = new JSDataAccess();
        
        public DataTable DBUsers()
        {
            DataTable UsersData = new DataTable();
            UsersData = JSDA.DBSelectBySQL("Select * from dbo.tbl_DB_Users");
            return UsersData;
        }
        public bool TrustUser(string User, string Pass)
        {
            string SQL= string.Format("Select count(*) From dbo.tbl_DB_Users where UserCode = '{0}' and PassCode = '{1}'", User, Pass);
            DataTable dt = new DataTable();
            dt = JSDA.DBSelectBySQL(SQL);
            if (dt.Rows[0][0].ToString() == "1") return true;
            return false;                        //else
        }
    }
}
