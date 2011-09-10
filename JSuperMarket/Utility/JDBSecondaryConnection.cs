using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace JSuperMarket
{
    class JDBSecondaryConnection
    {
        // Declaration Variable...
        private const string _ConnectionString =
            "server=.;database=JSuperMarket;user id=sa;password=2190053994";
        private string _CommandText = "select * from dbo.";
        public string _TableName;
        
        // Declare global objects...
        public System.Data.SqlClient.SqlConnection objConnection;
        public System.Data.SqlClient.SqlDataAdapter objDataAdapter;
        public DataSet objDataSet;

        public JDBSecondaryConnection(string TableName)      // Counstructor...
        {
            _TableName = TableName;
            _CommandText += TableName;
            objConnection = new System.Data.SqlClient.SqlConnection(_ConnectionString);
            objDataAdapter = new System.Data.SqlClient.SqlDataAdapter(_CommandText, objConnection);
            JFillDataSetAndView();
        }

        public void JFillDataSetAndView()
        {
            // initialize a new instance of the DataSet object...
            objDataSet = new DataSet();
            // Fill the DataSet object with data...
            objDataAdapter.Fill(objDataSet, _TableName);
        }
    }
}
