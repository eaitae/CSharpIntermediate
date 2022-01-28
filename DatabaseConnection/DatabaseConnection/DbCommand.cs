using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DbCommand
    {
        DbConnection ConnectionType;
        string PassDb = "Send to the database";
        public DbCommand(DbConnection connectionType, String passDb)
        {
            ConnectionType = connectionType;
            PassDb = passDb;


            if (connectionType == null)
            {
                throw new InvalidOperationException("connectionType cannot be null");
            }

            if (String.IsNullOrWhiteSpace(passDb))
            {
                throw new InvalidOperationException("passDb cannot be null or white space");
            }

            return;
        }

        public void Execute()
        {
            ConnectionType.OpenConnection();
            Console.WriteLine("Sending open connection command to the database");
            Console.WriteLine("Running the instruction");
            ConnectionType.CloseConnection();
            Console.WriteLine("Sending close connection command to the database");

        }
    }
}
