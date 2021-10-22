using System;
using System.Collections.Generic;

namespace Day5_OOP3
{
    class Program
    {
        static void Main()
        {
            ICreditManager personalFinanceCredit = new PersonalFinanceCreditManager();
            ICreditManager housingCredit = new HousingCreditManager();
            ICreditManager transportCredit = new TransportCreditManager();
            
            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            
            var recourseManager = new RecourseManager();

            recourseManager.Recourse(housingCredit,fileLogger);
            //recourseManager.Recourse(personalFinanceCredit);
            //recourseManager.Recourse(transportCredit);

            //var credits = new List<ICreditManager>() {personalFinanceCredit , housingCredit , transportCredit };

            //recourseManager.CreditPreliminaryInformation(credits);


        }
    }
}
