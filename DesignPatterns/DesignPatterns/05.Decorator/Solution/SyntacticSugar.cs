using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Solution
{
    public static class SyntacticSugar
    {
        public static IWindow DecorateWith(this IWindow decoratable, WindowDecorator decorator)
        {
            decorator.DecoratedObject = decoratable;
            return decorator;
        }
    }
}
