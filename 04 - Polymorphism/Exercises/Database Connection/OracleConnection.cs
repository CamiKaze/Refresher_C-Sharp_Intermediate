using System;

namespace Database_Connection
{
    public class OracleConnection : Database_Connection
    {
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
