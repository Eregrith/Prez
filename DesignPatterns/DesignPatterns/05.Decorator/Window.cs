using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Five
{
    public class Window
    {
        public void Draw()
        {
            //Stuff
            //[...]
        }
    }

    public class WindowWithVerticalScrollBar : Window
    {
        public void Draw()
        {
            //Stuff about vertical scrollbar
            //[...]

            base.Draw();
        }
    }

    public class WindowWithBorder : Window
    {
        public void Draw()
        {
            //Stuff about the border
            //[...]

            base.Draw();
        }
    }

    public class WindowWithHorizontalScrollBar : Window
    {
        public void Draw()
        {
            //Stuff about horizontal scollbar
            //[...]

            base.Draw();
        }
    }

    public class WindowWithVerticalAndHorizontalScrollBar
        : Window
    //Or : WindowWithVerticalScrollBar + redo the horizontal process ?
    //Or : WindowWithHorizontalScrollBar + redo the vertical process ?
    {
        public void Draw()
        {
            //Stuff about horizontal scollbar
            //[...]
            //Stuff about vertical scrollbar
            //[...]

            base.Draw();
        }
    }

    public class WindowWithVerticalAndHorizontalScrollBarAndBorder
        : Window
    //Or : WindowWithVerticalScrollBar + redo the horizontal process and the border ?
    //Or : WindowWithHorizontalScrollBar + redo the vertical process and the border ?
    //Or ...
    {
        public void Draw()
        {
            //Stuff about horizontal scollbar
            //[...]
            //Stuff about vertical scrollbar
            //[...]

            base.Draw();
        }
    }

    //What about Window with horizontal scrollbar and border ?
    //What about Window with vertical scrollbar and border ?
    //What if we add a drop-shadow ?
    //What if we add something else ?
}
