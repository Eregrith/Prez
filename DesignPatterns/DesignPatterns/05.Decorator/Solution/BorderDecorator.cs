namespace DesignPatterns.Decorator.Solution
{
    public class BorderDecorator : WindowDecorator
    {
        public BorderDecorator()
        { }
        
        public BorderDecorator(IWindow next) : base(next)
        {
        }

        protected override void AfterDraw()
        {
            //Add Border
        }

        protected override void BeforeDraw()
        {
            //Nothing
        }
    }
}