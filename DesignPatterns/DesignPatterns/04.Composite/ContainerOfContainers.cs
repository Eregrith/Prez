using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class ContainerOfContainers : Container
    {
        public List<Container> Containers { get; internal set; }
    }
}