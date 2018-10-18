namespace DesignPatterns.AbstractFactory.Solution
{
    public class RedChameleonFactory : ChameleonFactory
    {
        public override Body ConstructBody()
        {
            return new RedBody("what");
        }

        public override Head ConstructHead()
        {
            return new RedHead();
        }

        public override Leg ConstructLeftLeg()
        {
            return new RedLeftLeg();
        }

        public override Leg ConstructRightLeg()
        {
            return new RedRightLeg();
        }
    }
}