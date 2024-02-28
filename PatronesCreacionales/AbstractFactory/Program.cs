using AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        IUIFactory uiFactory;

        // Decide at runtime which theme to use
        var theme = "dark"; // This could come from user input or configuration

        if (theme == "dark")
        {
            uiFactory = new DarkUIFactory();
        }
        else
        {
            uiFactory = new LightUIFactory();
        }

        var button = uiFactory.CreateButton();
        var textBox = uiFactory.CreateTextBox();

        Console.WriteLine(button.Display());
        Console.WriteLine(textBox.Display());
    }
}