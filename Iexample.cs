using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface Iexample
    {
        void add(int a, int b);
    }
    interface people : Iexample
    {
        void sub(int c, int d);

    }
    class buy : people
    {
      public  void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    public    void sub(int c, int d)
        {
            Console.WriteLine(c - d);  
        }
    
    
        static void Main()
        {
          buy b= new buy();
            b.add(100, 200);
            b.sub(100,
                
                
                78);
        }
    }
}
