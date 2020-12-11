using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class Program
    {
        static void Main()
        {
            EmployeeBal empf = new EmployeeBal(new EmployeeDaL());
      List<Employee>listemployee=      empf.getallemployees();
            foreach(Employee emp in listemployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
        }
            
        }
    }



