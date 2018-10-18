using DesignPatterns.Composite.Solution;

namespace DesignPatterns.Composite
{
    public class CompositeHeavyContainer : CompositeContainer
    {
        private readonly double _internalWeight = 123;
        public override double Weight => _internalWeight * 2;
    }
}