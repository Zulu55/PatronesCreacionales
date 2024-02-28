namespace AbstractFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();

        ITextBox CreateTextBox();
    }
}