internal class Program
{
    private static void Main(string[] args)
    {
        // Create an original game setting
        GameSetting originalSetting = new GameSetting("High", "Custom", true);

        // Clone the original setting to create a new setting
        GameSetting clonedSetting = originalSetting.Clone();
        clonedSetting.Difficulty = "Medium"; // Modify the property of the cloned setting

        Console.WriteLine("Original Setting:");
        Console.WriteLine(originalSetting.ToString());
        Console.WriteLine("Cloned and Modified Setting:");
        Console.WriteLine(clonedSetting.ToString());
    }
}