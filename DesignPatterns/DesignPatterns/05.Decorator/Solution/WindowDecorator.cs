using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Solution
{
    public abstract class WindowDecorator : IWindow
    {
        public IWindow DecoratedObject { get; set; }

        protected abstract void BeforeDraw();
        protected abstract void AfterDraw();

        protected WindowDecorator()
        { }

        protected WindowDecorator(IWindow decoratedObject)
        {
            DecoratedObject = decoratedObject;
        }

        public void Draw()
        {
            BeforeDraw();
            DecoratedObject.Draw();
            AfterDraw();
        }
    }
}
