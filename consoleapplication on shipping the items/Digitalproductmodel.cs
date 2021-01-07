using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping3
{
    public class Digitalproductmodel : Iproductmodel, IDigitalproductmodel
    {
        public string Title { get; set; }
        public bool hasordercompleted { get; private set; }
        public int downloadsleft { get; private set; } = 5;
        public void shipitem(Customermodel customer)
        {
            if (hasordercompleted == false)
            {
                Console.WriteLine(

                      $"Simulating emailing { Title} to {customer.emailadress} ");
                downloadsleft = -1;
                if (downloadsleft < 1)
                {
                    hasordercompleted = true;
                    downloadsleft = 0;

                }
            }
        }
    }
}
