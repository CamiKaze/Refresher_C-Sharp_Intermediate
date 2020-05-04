using System;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            // We create a dbMigrator and pass a ConsoleLogger instance
            // to its constructor. DbMigrator be default writes to console,
            // but since I extended the method with FileLogger, I did not
            // touch the DbMigrator. This is called the Open/Closed Principle.
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\camer\\Projects\\Training\\Core\\Refresher_C-Sharp_Intermediate\\05 - Interfaces\\Extensibility"));
            dbMigrator.Migrate();
        }
    }
}
