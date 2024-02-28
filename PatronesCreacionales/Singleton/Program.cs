using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        // Access the configuration instance and use it
        var configValue = Configuration.Instance.GetValue("someKey");
        Console.WriteLine($"Configuration value: {configValue}");
    }
}