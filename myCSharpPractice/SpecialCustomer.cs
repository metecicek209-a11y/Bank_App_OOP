using System;
using System.Collections.Generic;
using System.Text;

namespace myCSharpPractice
{
    class SpecialCustomer : Customer
    {
        public SpecialCustomer(string name, string sirname, int balance, string username, string password)
            : base(name, sirname, balance, username, password)
        {

        }
        public int payment = 0;
        public void TakeCredit()
        {
            Console.WriteLine("To take a mortgage desired amount");
            int desiredAmount = Convert.ToInt32(Console.ReadLine());
            if (desiredAmount > 0)
            {
                Balance = Balance + desiredAmount;
                payment = payment + desiredAmount;
            }

        }    
        public void ShowDebt()
        {
            Console.WriteLine($"Your debt is {payment}");
        }
    }
}
