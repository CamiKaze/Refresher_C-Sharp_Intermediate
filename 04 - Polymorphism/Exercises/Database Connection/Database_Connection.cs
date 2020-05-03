using System;

namespace Database_Connection
{
    public abstract class Database_Connection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public void DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("message", nameof(connectionString));
            }

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
