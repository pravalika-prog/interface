using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping3
{
 public   interface Iproductmodel
    {
         string Title { get; set; }
         bool hasordercompleted { get;  }
         void shipitem(Customermodel customer);
    }
}
