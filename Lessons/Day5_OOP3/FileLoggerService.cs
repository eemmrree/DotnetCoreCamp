using System;

namespace Day5_OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File Log");
        }
    }
}