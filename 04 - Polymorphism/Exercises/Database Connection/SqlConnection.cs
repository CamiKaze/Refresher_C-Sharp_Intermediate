using System;

namespace Database_Connection
{
    public class SqlConnection : Database_Connection
    {
        public void Time(TimeSpan timeout)
        {
            Timeout = timeout;
        }

        public SqlConnection(string connectionString, TimeSpan Time) : base(connectionString, Time)
        {
            ConnectionString = connectionString;
            Timeout = Time;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection Closed");
        }
    }
}
