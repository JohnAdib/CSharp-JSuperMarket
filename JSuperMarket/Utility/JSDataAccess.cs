using System;
using System.Data;
using System.Data.SqlClient;

namespace JSuperMarket.Utility
{
    class JSDataAccess
    {
        // Declaration Variable...
        public bool ShowFriendlyMessage;
        public bool IsExpress;
        public string Server=".";
        public string DataBase = "JSSuperMarketDB";
        public string Userid="sa";
        public string Password="2190053994";
        public string CommandText = "select * from dbo.";
        public string TableName = "";
        public string LastError = "";
        public int Identity;

        public enum CmdType { Insert, Update, Delete }

        readonly SqlConnection _con;
        readonly SqlCommand _cmd;
        readonly SqlDataAdapter _da;


        public JSDataAccess()       // Constructor...
        {
            _con = new SqlConnection();
            _cmd = new SqlCommand();
            _da = new SqlDataAdapter();
            _cmd.Connection = _con;
            _da.SelectCommand = _cmd;
            
            if (IsExpress)
            {
                //con.ConnectionString = @"Data source=.\SQLEXPRESS; Attachdbfilename = |DataDirectory|\"
                //    + this._DataBase + ".mdf; Integrated security = true; user Instance = true";


                _con.ConnectionString = @"Server =.\SQLEXPRESS; Attachdbfilename = |DataDirectory|\" + DataBase + ".mdf; "
                                    + "; Integrated Security=SSPI;Persist Security Info=False";
            }
            else
                _con.ConnectionString = "Server = " + Server + "; Database = " + DataBase
                    + "; User ID = " + Userid + "; Password =" + Password;
        }
        public void DBConnect()
        {
            try     { _con.Open(); }
            catch (Exception ex) 
            {
                if (ShowFriendlyMessage) LastError += @"اشکال در ارتباط با بانک اطلاعاتی";
                else LastError += @"Connect: " + ex.Message;
            }
        }

        public void DBDisconnect()
        {
            try     { _con.Close(); }
            catch (Exception ex)
            {
                if (ShowFriendlyMessage) LastError += @"اشکال در قطع ارتباط با بانک اطلاعاتی";
                else LastError += @"Disconnect: " + ex.Message;
            }
        }
        
        public DataTable DBSelectBySQL(string sql)
        {
            DBConnect();
            var dt = new DataTable();

            if (LastError == "")
            {
                try
                {
                    _cmd.CommandText = sql ;
                    _da.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (ShowFriendlyMessage) LastError += @"خطا در خواندن اطلاعات";
                    else LastError += @"SelectBySQL: " + ex.Message;
                }
                finally { DBDisconnect(); }
            }
            return dt;
        }

        public DataTable DBSelectByTable(string tblname)
        {
            DBConnect();
            var dt = new DataTable();

            if (LastError == "")
            {
                try
                {
                    _cmd.CommandText = "select * from dbo." + tblname;
                    _da.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (ShowFriendlyMessage) LastError += @"خطا در خواندن اطلاعات";
                    else LastError += @"SelectBytable: " + ex.Message;

                }
                finally { DBDisconnect(); }

            }
            return dt;

        }

        public void DBDoCommand(string sql, bool returnIdentity = false)
        {
            DBConnect();
            try
            {
                if (!returnIdentity)
                {
                    _cmd.CommandText = sql;
                    _cmd.ExecuteNonQuery();
                }
                else
                {
                    _cmd.CommandText = sql + "; SELECT SCOPE_IDENTITY() AS [lastInsertedId]";
                    Identity = Convert.ToInt32(_cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                if (ShowFriendlyMessage) LastError += @"خطا در اجرای دستورات";
                else LastError += @"DoCommand: " + ex.Message;
            }
            finally { DBDisconnect(); }
        }
    }
}

