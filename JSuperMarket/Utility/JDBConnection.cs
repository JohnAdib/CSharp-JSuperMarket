using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace JSuperMarket
{
    class JDBConnection
    {
        // Declaration Variable...
        private const string _ConnectionString =
            "server=.;database=JSuperMarket;user id=sa;password=2190053994";
        private string _CommandText = "select * from dbo.";
        public string _TableName;
        
        // Declare global objects...
        public enum CmdType { Insert, Update, Delete }
        public System.Data.SqlClient.SqlConnection objConnection;
        public System.Data.SqlClient.SqlDataAdapter objDataAdapter;
        public DataSet objDataSet;
        public DataView objDataView;
        public System.Data.SqlClient.SqlCommand objCommand;

        public JDBConnection(string TableName)      // Counstructor...
        {
            _TableName = TableName;
            _CommandText += TableName;
            objConnection = new System.Data.SqlClient.SqlConnection(_ConnectionString);
            objDataAdapter = new System.Data.SqlClient.SqlDataAdapter(_CommandText, objConnection);
            //objDataAdapter.InsertCommand = objConnection.CreateCommand();

            objCommand = new System.Data.SqlClient.SqlCommand();
            objCommand.Connection = objConnection;

            JFillDataSetAndView();

        }

        public void JFillDataSetAndView()
        {
            // initialize a new instance of the DataSet object...
            objDataSet = new DataSet();
            // Fill the DataSet object with data...
            objDataAdapter.Fill(objDataSet, _TableName);
            // Set the DataView object to the DataSet object...
            objDataView = new DataView(objDataSet.Tables[_TableName]);
        }

        /*
        private void RunCommand(CmdType CommandType, string PK, params string[] parameters)
        {
            //string sqlcmd = "";

            switch (CommandType)
            {
              //  case CmdType.Insert:

                
                sqlcmd = "insert into " + objDBC._TableName + " (";
                foreach (string para in parameters) { sqlcmd += para + ", "; }
                sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + ") values (";
                foreach (string para in parameters) { sqlcmd += "@" + para + ", "; }
                sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + ")";
                objDBC.objCommand.CommandText = sqlcmd;
                AddParams(CmdType.Insert);
                try
                {
                    objDBC.objConnection.Open();
                    objDBC.objCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added!");
                }
                catch (System.Data.SqlClient.SqlException sqlExceptionErr)
                {
                    MessageBox.Show(sqlExceptionErr.Message);
                }
                finally
                {
                    objDBC.objConnection.Close();
                }
                break;
                 
            }
        }
         */
    }
}
