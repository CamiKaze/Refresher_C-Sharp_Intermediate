using System;

namespace Database_Connection
{
    public class OracleConnection : Database_Connection
    {
        public void Time(TimeSpan timeout)
        {
            Timeout = timeout;
        }

        public OracleConnection(string connectionString, TimeSpan Time) : base(connectionString, Time)
        {
            ConnectionString = connectionString;
            Timeout = Time;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
        }
    }
}
