namespace Composition
{
    public class Installer
    {
        // Create aproperty of type Logger.
        private readonly Logger _logger;

        public Installer(Logger logger)
        { // Initialise the _logger property.
            _logger = logger;
        }

        public void Install()
        { // We now have access to the Logger class methods.
            _logger.Log("We are installing the application.");
        }
    }
}
