using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriantedP3
{
    class AppealManager
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void CreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
