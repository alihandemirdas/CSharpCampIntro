using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriantedP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
