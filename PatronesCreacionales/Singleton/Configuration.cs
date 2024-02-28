namespace Singleton
{
    public class Configuration
    {
        // Private static field that stores the single instance
        private static Configuration instance = null!;

        // Public static property to access the instance
        public static Configuration Instance
        {
            get
            {
                // If the instance has not yet been created, create it
                instance ??= new Configuration();
                return instance;
            }
        }

        // Private constructor to prevent external instantiation
        private Configuration()
        {
            // Load the configuration here
            LoadConfiguration();
        }

        // Method to load the configuration
        private void LoadConfiguration()
        {
            // Implement configuration loading (from a file, for example)
            Console.WriteLine("Loading configuration...");
        }

        // Method to get a configuration value
        public string GetValue(string key)
        {
            // Return the configuration value based on the key
            // This is just an example, you should implement your own logic to store and retrieve configuration values
            return "Configuration value";
        }
    }
}