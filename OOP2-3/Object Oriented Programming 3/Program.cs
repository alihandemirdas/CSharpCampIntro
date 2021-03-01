using System;
using System.Collections.Generic;

namespace ObjectOriantedP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager carCreditManager = new CarCreditManager();
            ICreditManager tradesCreditManager = new TradesCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.Apply(tradesCreditManager, new List<ILoggerService> { smsLoggerService, databaseLoggerService, fileLoggerService });

            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager,carCreditManager,houseCreditManager };
            //appealManager.CreditPreinformation(credits);
        }
    }
}
