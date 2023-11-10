using System;
namespace OOP3
{
    public class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Loglandı");
        }
    }
}

