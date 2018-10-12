namespace DesignPatterns.AbstractFactory.Solution
{
    public class GreenChameleonFactory : ChameleonFactory
    {
        public override Body ConstructBody()
        {
            return new GreenBody();
        }

        public override Head ConstructHead()
        {
            return new GreenHead();
        }

        public override Leg ConstructLeftLeg()
        {
            return new GreenLeftLeg();
        }

        public override Leg ConstructRightLeg()
        {
            return new GreenRightLeg();
        }
    }
}