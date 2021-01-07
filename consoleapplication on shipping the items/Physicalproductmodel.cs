using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping3
{
 public   class Physicalproductmodel: Iproductmodel
    {
        public string  Title { get; set; }
        public bool hasordercompleted { get;  private set; }
        public void shipitem(Customermodel customer)
        {
            if (hasordercompleted == false)
                Console.WriteLine( 
                    
                    $"Simulating shipping { Title} to {customer.Firstname} in {customer.city}");
                hasordercompleted = true;
            }

        }
    }



