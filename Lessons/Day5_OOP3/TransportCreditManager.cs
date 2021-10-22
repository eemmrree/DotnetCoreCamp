using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    class TransportCreditManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport Credit Calculate.");
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
