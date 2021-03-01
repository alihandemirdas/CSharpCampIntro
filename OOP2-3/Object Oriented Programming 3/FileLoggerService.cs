using System;

namespace ObjectOriantedP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
