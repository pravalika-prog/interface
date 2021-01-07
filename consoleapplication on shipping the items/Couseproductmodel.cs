using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping3
{
    public class Couseproductmodel : Iproductmodel
    {
        public string Title { get; set; }

        public bool hasordercompleted { get; private set; }
        public void shipitem(Customermodel customer)
        {
            if (hasordercompleted == false)
            {
                Console.WriteLine($"   stimulate shipping to {Title} course to{customer.Firstname}");
                hasordercompleted = true;
            }
        }
    }
}
