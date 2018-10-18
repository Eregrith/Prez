using DesignPatterns.Composite.Solution;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite
{
    public class CompositeContainerOfContainers : CompositeContainer
    {
        public List<CompositeContainer> Containers { get; set; }

        public override double Weight => Containers.Sum(c => c.Weight);
    }
}