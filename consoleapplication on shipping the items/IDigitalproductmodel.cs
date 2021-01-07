using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping3
{
  public  interface IDigitalproductmodel:Iproductmodel
    {
        public int downloadsleft { get;  }
    }
}
