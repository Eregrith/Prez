namespace DesignPatterns.AbstractFactory.Solution
{
    public class ColorlessChameleonFactory : ChameleonFactory
    {
        public override Body ConstructBody()
        {
            return new Body();
        }

        public override Head ConstructHead()
        {
            return new Head();
        }

        public override Leg ConstructLeftLeg()
        {
            return new Leg();
        }

        public override Leg ConstructRightLeg()
        {
            return new Leg();
        }
    }
}