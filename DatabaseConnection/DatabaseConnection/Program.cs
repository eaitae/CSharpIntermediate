using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("connection");
            var oracleConnection = new OracleConnection("connection");

            var dbCommand = new DbCommand(oracleConnection, "passdb");
            dbCommand.Execute();

            var dbCommand2 = new DbCommand(sqlConnection, "passdb");
            dbCommand2.Execute();
        }
    }


}
