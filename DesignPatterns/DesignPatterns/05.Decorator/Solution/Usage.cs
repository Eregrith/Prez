namespace DesignPatterns.Decorator.Solution
{
    public class Usage
    {
        public void Main()
        {
            IWindow usefulWindow = new BorderDecorator(
                new HorizontalScrollBarDecorator(
                    new VerticalScrollBarDecorator(
                        new Window())));

            usefulWindow.Draw();

            //Or you can add some syntaxic sugar:

            IWindow sugarWindow = new Window()
                .DecorateWith(new VerticalScrollBarDecorator())
                .DecorateWith(new HorizontalScrollBarDecorator())
                .DecorateWith(new BorderDecorator());

            sugarWindow.Draw();
        }
    }
}
