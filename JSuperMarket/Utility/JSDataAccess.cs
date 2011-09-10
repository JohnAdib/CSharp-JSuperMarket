using System;
using System.Data;
using System.Data.SqlClient;

namespace JSuperMarket
{
    class JSDataAccess
    {
        // Declaration Variable...
        public bool _ShowFriendlyMessage = false;
        public bool _IsExpress = false;
        public string _Server=".";
        public string _DataBase = "JSuperMarket";
        public string _userid="sa";
        public string _password="2190053994";
        public string _CommandText = "select * from dbo.";
        public string _TableName = "";
        public string _LastError = "";

        public enum CmdType { Insert, Update, Delete }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        public JSDataAccess()       // Counstructor...
        {
            this.con = new SqlConnection();
            this.cmd = new SqlCommand();
            this.da = new SqlDataAdapter();
            this.cmd.Connection = this.con;
            this.da.SelectCommand = this.cmd;
            
            if (_IsExpress)
                con.ConnectionString = @"Data source=.\SQLEXPRESS;Attachdbfilename=|DataDirectory|\"
                    + this._DataBase + ";Integrated security=true;user Instance=true";
            else
                con.ConnectionString = "Server = " + this._Server + "; Database = " + this._DataBase
                    + "; User ID = " + this._userid + "; Password =" + this._password;
        }
        public void DBConnect()
        {
            try     { this.con.Open(); }
            catch (Exception ex) 
            {
                if (this._ShowFriendlyMessage)      this._LastError += "اشکال در ارتباط با بانک اطلاعاتی";
                else                                this._LastError += "Connect: " + ex.Message;
            }
        }

        public void DBDisconnect()
        {
            try     { this.con.Close(); }
            catch (Exception ex)
            {
                if (this._ShowFriendlyMessage)      this._LastError += "اشکال در قطع ارتباط با بانک اطلاعاتی";
                else                                this._LastError += "Disconnect: " + ex.Message;
            }
        }
        
        public DataTable DBSelectBySQL(string SQL)
        {
            this.DBConnect();
            DataTable dt = new DataTable();

            if (this._LastError == "")
            {
                try
                {
                    this.cmd.CommandText = SQL;
                    this.da.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (this._ShowFriendlyMessage)  this._LastError += "خطا در خواندن اطلاعات";
                    else                            this._LastError += "SelectBySQL: " +ex.Message;

                }
                finally { this.DBDisconnect(); }

            }
            return dt;
            
        }
        public DataTable DBSelectByTable(string TableName)
        {
            this.DBConnect();
            DataTable dt = new DataTable();

            if (this._LastError == "")
            {
                try
                {
                    this.cmd.CommandText = "select * from dbo.";
                    this.da.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (this._ShowFriendlyMessage) this._LastError += "خطا در خواندن اطلاعات";
                    else                           this._LastError += "SelectBytable: " + ex.Message;

                }
                finally { this.DBDisconnect(); }

            }
            return dt;

        }

        public void DBDoCommand(string SQL)
        {
            this.DBConnect();
            try
            {
                this.cmd.CommandText = SQL;
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (this._ShowFriendlyMessage)  this._LastError += "خطا در اجرای اطلاعات";
                else                            this._LastError += "DoCommand: " + ex.Message;
            }
            finally { this.DBDisconnect(); }
        }
    }
}

