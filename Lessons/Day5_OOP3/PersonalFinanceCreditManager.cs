using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    class PersonalFinanceCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit Calculate.");
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
