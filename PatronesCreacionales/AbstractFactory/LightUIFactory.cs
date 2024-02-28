namespace AbstractFactory
{
    public class LightUIFactory : IUIFactory
    {
        public IButton CreateButton() => new LightButton();

        public ITextBox CreateTextBox() => new LightTextBox();
    }
}