using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Solution
{
    public class CompositeShippingCompany
    {
        public bool AreContainersTooHeavyForShip(CompositeContainer mainContainer, double maxWeight)
        {
            if (mainContainer.Weight > maxWeight)
                return true;
            return false;
        }
    }
}
