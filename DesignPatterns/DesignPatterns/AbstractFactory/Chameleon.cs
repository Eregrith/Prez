using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public enum ColorType
    {
        Red,
        Blue,
        Green
    }

    public class Chameleon
    {
        public Body Body { get; set; }
        public Head Head { get; set; }
        public Leg RightLeg { get; set; }
        public Leg LeftLeg { get; set; }

        public void ChangeColorTo(ColorType color)
        {
            ChangeLegColorsTo(color);
            ChangeHeadColorsTo(color);
            ChangeBodyColorsTo(color);
        }

        private void ChangeLegColorsTo(ColorType color)
        {
            switch (color)
            {
                case ColorType.Red:
                    RightLeg = new RedRightLeg();
                    LeftLeg = new RedLeftLeg();
                    break;
                case ColorType.Green:
                    RightLeg = new GreenRightLeg();
                    LeftLeg = new GreenLeftLeg();
                    break;
                case ColorType.Blue: // this one has two left legs!
                    RightLeg = new BlueLeftLeg();
                    LeftLeg = new BlueLeftLeg();
                    break;
            }
        }

        private void ChangeHeadColorsTo(ColorType color)
        {
            switch (color)
            {
                case ColorType.Red:
                    Head = new RedHead();
                    break;
                case ColorType.Green:
                    Head = new GreenHead();
                    break;
                case ColorType.Blue:
                    Head = new BlueHead();
                    break;
            }
        }

        private void ChangeBodyColorsTo(ColorType color)
        {
            switch (color)
            {
                case ColorType.Red:
                    Body = new RedBody("I have special needs");
                    break;
                case ColorType.Green:
                    Body = new GreenBody();
                    break;
                case ColorType.Blue:
                    Body = new BlueBody();
                    break;
            }
        }
    }
}
