using System.Collections.Generic;

namespace DesignPatterns.Four
{
    public class ContainerOfContainers : Container
    {
        public List<Container> Containers { get; internal set; }
    }
}