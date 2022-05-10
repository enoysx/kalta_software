using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Kalta_project
{
    class connection
    {
        public OleDbCommand cmd;
        public DataSet dataS;
        public OleDbDataAdapter dataA;

        public OleDbConnection Getconnection()
        {
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|Data Directory|/cost_control.accdb";
            return connect;
        }
    }
}
