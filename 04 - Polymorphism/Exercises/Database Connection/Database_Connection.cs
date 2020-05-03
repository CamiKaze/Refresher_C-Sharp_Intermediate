using System;

namespace Database_Connection
{
    public abstract class Database_Connection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public Database_Connection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("message", nameof(connectionString));
            }

            ConnectionString = connectionString;
            //DbType = dbType;
            Timeout = timeout;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
