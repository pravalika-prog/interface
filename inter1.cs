using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface inter1
    {
        void display();
    }


    class testClass : inter1
    {


        public void display()
        {
            Console.WriteLine("Sudo Placement GeeksforGeeks");
        }

        
        public static void Main(String[] args)
        {
            testClass t = new testClass();

            // calling method 
            t.display();
        }
    }
}
       