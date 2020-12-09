using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ExplicitInterface
    {
        void print();
    }
    interface i2
    {
        void print();
    }
    class gfh: ExplicitInterface,i2
    {
        

        void ExplicitInterface.print()
        {
            Console.WriteLine("present");
        }
        void i2.print()
        {
            Console.WriteLine("people");
        }
    }

     static void Main(string[] args)
    {
       ExplicitInterface  i1 = new gfh();
        i2 h = new gfh();
        i1.print();


        h.print();
    }
}
