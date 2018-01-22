using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ListDemo
    {
        public ListDemo()
        {
            Employee emp = new Employee();
            emp.EmpID = 2;
            emp.EmpName = "Chandrasen";

            Employee emp2 = new Employee();
            emp2.EmpName = "Akash";
            emp2.EmpID = 1;


            List<Employee> empList = new List<Employee>();
            empList.Add(emp);
            empList.Add(emp2);
            empList.Add(new Employee { EmpID = 3, EmpName = "Test Name" });

            foreach (var empObj in empList)
            {
                Console.WriteLine("Emp details: ID={0},Name={1}", empObj.EmpID, empObj.EmpName);
            }

            var i = empList[0];
            empList.Contains<Employee>(emp);
            var count = empList.Count;
        }
        
    }
   
}
