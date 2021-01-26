using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglama yapıldı.");
        }
    }
}
