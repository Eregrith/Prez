using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class ShippingCompany
    {
        public bool AreContainersTooHeavyForShit(List<Container> containers, double maxWeight)
        {
            double sumWeight = SumWeightForContainers(containers);
            if (sumWeight > maxWeight)
                return true;
            return false;
        }

        private double SumWeightForContainers(List<Container> containers)
        {
            double sumWeight = 0;
            foreach (Container container in containers)
            {
                if (container is NormalContainer)
                    sumWeight += container.Weight;
                else if (container is HeavyContainer)
                    sumWeight += container.Weight * 2;
                else if (container is ContainerOfContainers)
                {
                    sumWeight += SumWeightForContainers((container as ContainerOfContainers).Containers);
                }
                else if (container is PaperContainer)
                    sumWeight += container.Weight / 2;
            }
            return sumWeight;
        }
    }
}
