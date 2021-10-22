using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    class RecourseManager
    {
        //Method injection
        public void Recourse(ICreditManager creditManager , ILoggerService loggerService)
        {

            creditManager.Calculate();
            loggerService.Log();

            //var housingCredit = new HousingCreditManager();
            //housingCredit.Calculate();
        }

        public void CreditPreliminaryInformation(List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();
            }
        }
    }
}
