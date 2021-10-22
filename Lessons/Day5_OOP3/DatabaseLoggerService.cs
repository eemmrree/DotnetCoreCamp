using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    class DatabaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database Log");
        }
    }
}
