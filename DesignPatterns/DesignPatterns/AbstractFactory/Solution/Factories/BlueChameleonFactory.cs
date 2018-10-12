namespace DesignPatterns.AbstractFactory.Solution
{
    public class BlueChameleonFactory : ChameleonFactory
    {
        public override Body ConstructBody()
        {
            return new BlueBody();
        }

        public override Head ConstructHead()
        {
            return new BlueHead();
        }

        public override Leg ConstructLeftLeg()
        {
            return new BlueLeftLeg();
        }

        public override Leg ConstructRightLeg()
        {
            return new BlueLeftLeg();
        }
    }
}