using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriantedP3
{
    class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödendi.");
        }
    }
}
