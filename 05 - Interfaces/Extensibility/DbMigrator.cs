using System;

namespace Extensibility
{
    // DbMigrator talks to an interface. It does not know what concrete
    // class is going to implement the interface.
    public class DbMigrator
    { // With Dependcy Injection, DbMigrator does not care who the actual
      // logger is. There is now no coupling between DbMigrator and the
      // concrete class.
        private readonly ILogger _logger;

        // Use Dependency Injection to inject the interface into the
        // constructor. In other words, we are injecting the
        // dependencies for the DbMigrator class.
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            // We can now directly speak to a logger instead od to console.
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);

            // Console.WriteLine("Migration started at {0}", DateTime.Now);
            // Details of migrating the database.
            // Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}
