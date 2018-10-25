using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Eight.Solution
{
    public class FaxingHealthChecker : AbstractSystemHealthChecker
    {
        private readonly ISystemHealthProvider _systemHealthProvider;
        private readonly IFaxSender _faxSender;

        public FaxingHealthChecker(ISystemHealthProvider systemHealthProvider, IFaxSender faxSender)
        {
            _systemHealthProvider = systemHealthProvider;
            _faxSender = faxSender;
        }

        protected override double GetSystemHealth()
        {
            return _systemHealthProvider.GetHealth();
        }

        protected override void HandleSystemHealthLevel(double systemHealthLevel)
        {
            if (systemHealthLevel < 50)
            {
                _faxSender.SendFaxTo("1281289412", "Oulala boum");
            }
        }
    }
}
