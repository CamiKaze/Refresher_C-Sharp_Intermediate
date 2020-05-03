using System;

namespace Database_Connection
{
    public class SqlConnection : Database_Connection
    {
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
