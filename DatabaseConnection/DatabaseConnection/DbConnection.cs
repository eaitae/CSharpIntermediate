using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {

            if (connectionString == null)
            {
                throw new InvalidOperationException("The connection string cannot be null");
            }

            if (connectionString == " ")
            {
                throw new InvalidOperationException("The connection string cannot be empty");
            }

            return;
        }

        public abstract void OpenConnection();


        public abstract void CloseConnection();
    }
}
