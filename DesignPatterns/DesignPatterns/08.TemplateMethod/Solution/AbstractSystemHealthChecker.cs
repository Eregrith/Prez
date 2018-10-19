using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Solution
{
    public abstract class AbstractSystemHealthChecker
    {
        public void HealthCheck()
        {
            DoSomeWorkOnTheSystem();
            DoSomePreparation();

            double systemHealthLevel = GetSystemHealth();

            HandleSystemHealthLevel(systemHealthLevel);

            DoSomeCleanup();
            FinishUp();
        }

        protected abstract void HandleSystemHealthLevel(double systemHealthLevel);

        protected abstract double GetSystemHealth();

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
