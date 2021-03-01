using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriantedP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödendi.");
        }
    }
}
