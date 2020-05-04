using System;

namespace Database_Connection
{
    public class OracleConnection : Database_Connection
    {
        private string connection { get; set; }
        private TimeSpan Timeout { get; set; }
        public void Time(TimeSpan timeout)
        {
            Timeout = timeout;
        }

        public OracleConnection(string connectionString, TimeSpan Time) : base(connectionString, Time)
        {
            connection = connectionString;
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
