namespace DesignPatterns.Decorator.Solution
{
    public class HorizontalScrollBarDecorator : WindowDecorator
    {
        public HorizontalScrollBarDecorator()
        { }

        public HorizontalScrollBarDecorator(IWindow next) : base(next)
        {
        }

        protected override void AfterDraw()
        {
            //Add Horizontal Scrollbar
        }

        protected override void BeforeDraw()
        {
            //Nothing
        }
    }
}