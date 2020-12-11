using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class EmployeeBal
    {
        public IEmployeeDaL employeedal;
        public EmployeeBal(IEmployeeDaL employeedal)
        {
            this.employeedal = employeedal;
        }
        public List<Employee> getallemployees()
        {
            return employeedal.selectallemployees();




        }



    }
}

