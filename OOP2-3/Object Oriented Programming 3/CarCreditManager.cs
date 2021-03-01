using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriantedP3
{
    class CarCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödendi.");
        }
    }
}
