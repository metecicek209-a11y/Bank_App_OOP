using System;
using System.Collections.Generic;
using System.Text;

namespace myCSharpPractice
{
    class SpecialCustomer : Customer
    {
        public SpecialCustomer(string name, int balance, int password, string username)
            : base(name, balance,password,username)
        {
        }
    }
}
