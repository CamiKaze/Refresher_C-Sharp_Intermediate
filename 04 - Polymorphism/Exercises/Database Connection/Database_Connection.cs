using System;

namespace Database_Connection
{
    public abstract class Database_Connection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public Database_Connection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("message", nameof(connectionString));
            }

            ConnectionString = connectionString;
            Timeout = timeout;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
