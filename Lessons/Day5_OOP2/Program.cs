using System;

namespace Day5_OOP2
{
    class Program
    {
        static void Main()
        {
            var ındividualCustomer1 = new IndividualCustomer
            {
                Id = 1,
                CustomerNumber = "1213123",
                CustomerName = "Emre",
                CustomerLastName = "Bayrak",
                IdentityNumber = "21211213"
            };
            var corporateCustomer1 = new CorporateCustomer
            {
                Id = 1,
                CustomerNumber = "1213123",
                CompanyName = "Deneme",
                TaxNumber = "121211",
            };

            var cm = new CustomerManager();

            cm.Add(ındividualCustomer1);
            cm.Add(corporateCustomer1);
        }
    }
}
