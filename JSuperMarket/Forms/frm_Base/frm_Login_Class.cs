using System.Data;
using JSuperMarket.Utility;

namespace JSuperMarket.Forms.frm_Base
{
    class FrmLoginClass
    {
        readonly JSDataAccess _jsda = new JSDataAccess();
        public string ErrorMessage = "";
        public DataTable DBUsers()
        {
            _jsda.IsExpress = false;
            _jsda.ShowFriendlyMessage = false;
            DataTable usersData = _jsda.DBSelectBySQL("Select * from dbo.tbl_DB_Users ORDER BY ModifiedDate");
            ErrorMessage = _jsda.LastError;
            return usersData;
        }

        public bool TrustUser(string user, string pass)
        {
            string sql= string.Format("Select count(*) From dbo.tbl_DB_Users where UserCode = '{0}' and PassCode = '{1}'", user, pass);
            DataTable dt = _jsda.DBSelectBySQL(sql);
            if (dt.Rows[0][0].ToString() == "1") return true;
            return false;                        //else
        }
    }
}
