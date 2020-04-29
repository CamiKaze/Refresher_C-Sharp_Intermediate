namespace Composition
{
    public class DbMigrator
    {
        // Create aproperty of type Logger.
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        { // Initialise the _logger property.
            _logger = logger;
        }

        public void Migrate()
        { // We now have access to the Logger class methods.
            _logger.Log("We are migrating.");
        }
    }
}
