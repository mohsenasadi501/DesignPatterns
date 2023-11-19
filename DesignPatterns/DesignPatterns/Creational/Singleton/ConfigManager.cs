namespace DesignPatterns.Creational.Singleton
{
    internal class ConfigManager
    {
        Dictionary<string, object> settings = new Dictionary<string, object>();
        private ConfigManager()
        {
        }

        private static ConfigManager instance = new ConfigManager();
        public static ConfigManager GetInstatnce() { return instance; }
        public void Set(string key, object value)
        {
            settings.Add(key, value);
        }
        public object Get(string key)
        {
            return settings[key];
        }
    }
}
