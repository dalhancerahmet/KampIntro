﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglama yapıldı.");
        }
    }
}
