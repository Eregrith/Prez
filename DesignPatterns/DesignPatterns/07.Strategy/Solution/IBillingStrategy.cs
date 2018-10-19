namespace DesignPatterns.Strategy.Solution
{
    public interface IBillingStrategy
    {
        double GetActPrice(double rawPrice);
    }
}
