using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
 public   interface IEmployeeDaL
    {
        List<Employee> selectallemployees();
    }
    public class EmployeeDaL
        : IEmployeeDaL
    {
        public List<Employee> selectallemployees()
        {
            List<Employee> listemployees = new List < Employee>();
            listemployees.Add(new Employee() { ID = 1, Name = "pravalika", Department = "ece" });
            listemployees.Add(new Employee() { ID = 2, Name = "manasa", Department = "blue" });
            listemployees.Add(new Employee(){ ID=3,Name="priyanka",Department="maths"});
            return listemployees;
        }
    }
}
