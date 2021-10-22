using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    class HousingCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Credit Calculate.");
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
