namespace DesignPatterns.Decorator.Solution
{
    internal class VerticalScrollBarDecorator : WindowDecorator
    {
        public VerticalScrollBarDecorator()
        { }

        public VerticalScrollBarDecorator(IWindow next) : base(next)
        {
        }

        protected override void AfterDraw()
        {
            //Add Vertical ScrollBar
        }

        protected override void BeforeDraw()
        {
            //Nothing
        }
    }
}