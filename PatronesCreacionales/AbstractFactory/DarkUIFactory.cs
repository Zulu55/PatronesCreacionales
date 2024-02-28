namespace AbstractFactory
{
    public class DarkUIFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();

        public ITextBox CreateTextBox() => new DarkTextBox();
    }
}