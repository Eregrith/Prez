using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Eight
{
    public class SystemHealthChecker
    {
        private readonly ISystemHealthProvider _systemHealthProvider;
        private readonly IMailSender _mailSender;

        public SystemHealthChecker(ISystemHealthProvider systemHealthProvider, IMailSender mailSender)
        {
            _systemHealthProvider = systemHealthProvider;
            _mailSender = mailSender;
        }

        public void HealthCheck()
        {
            DoSomeWorkOnTheSystem();
            DoSomePreparation();

            double systemHealthLevel = _systemHealthProvider.GetHealth();

            if (systemHealthLevel <= 50)
            {
                _mailSender.SendMailTo("client@entreprise.com", "Oulala cépété");
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
