using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Solution
{
    public class IntelligentChameleon
    {
        public Body Body { get; set; }
        public Head Head { get; set; }
        public Leg RightLeg { get; set; }
        public Leg LeftLeg { get; set; }

        public void ChangeColorTo(ColorType color)
        {
            ChameleonFactory factory = GetFactoryForColor(color);

            RebuildLegs(factory);
            RebuildBody(factory);
            RebuildHead(factory);
        }

        private void RebuildLegs(ChameleonFactory factory)
        {
            RightLeg = factory.ConstructRightLeg();
            LeftLeg = factory.ConstructLeftLeg();
        }

        private void RebuildBody(ChameleonFactory factory)
        {
            Body = factory.ConstructBody();
        }

        private void RebuildHead(ChameleonFactory factory)
        {
            Head = factory.ConstructHead();
        }

        private ChameleonFactory GetFactoryForColor(ColorType color)
        {
            switch (color)
            {
                case ColorType.Red:
                    return new RedChameleonFactory();
                case ColorType.Green:
                    return new GreenChameleonFactory();
                case ColorType.Blue:
                    return new BlueChameleonFactory();
                default:
                    return new ColorlessChameleonFactory();
            }
        }
    }
}
