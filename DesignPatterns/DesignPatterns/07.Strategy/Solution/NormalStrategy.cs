namespace DesignPatterns.Strategy.Solution
{
    public class NormalStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice;
        }
    }
}
