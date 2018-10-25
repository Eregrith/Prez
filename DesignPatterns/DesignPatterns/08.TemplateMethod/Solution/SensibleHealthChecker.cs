using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Eight.Solution
{
    public class SensibleHealthChecker : AbstractSystemHealthChecker
    {
        private readonly ISystemHealthProvider _systemHealthProvider;

        public SensibleHealthChecker(ISystemHealthProvider systemHealthProvider)
        {
            _systemHealthProvider = systemHealthProvider;
        }

        protected override double GetSystemHealth()
        {
            return _systemHealthProvider.GetHealth();
        }

        protected override void HandleSystemHealthLevel(double systemHealthLevel)
        {
            if (systemHealthLevel <= 90)
            {
                //...
            }
        }
    }
}
