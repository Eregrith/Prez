using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class FaxingHealthChecker
    {
        private readonly ISystemHealthProvider _systemHealthProvider;
        private readonly IFaxSender _faxSender;

        public FaxingHealthChecker(ISystemHealthProvider systemHealthProvider, IFaxSender faxSender)
        {
            _systemHealthProvider = systemHealthProvider;
            _faxSender = faxSender;
        }

        public void HealthCheck()
        {
            DoSomeWorkOnTheSystem();
            DoSomePreparation();

            double systemHealthLevel = _systemHealthProvider.GetHealth();

            if (systemHealthLevel <= 90)
            {
                _faxSender.SendFaxTo("0742658235", "Oulala cépété");
            }

            DoSomeCleanup();
            FinishUp();
        }

        private void FinishUp()
        {
            //osef
        }

        private void DoSomeCleanup()
        {
            //osef
        }

        private void DoSomePreparation()
        {
            //osef
        }

        private void DoSomeWorkOnTheSystem()
        {
            //osef
        }
    }
}
