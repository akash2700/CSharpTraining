using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ConstReadOnlyDemo
    {
        public ConstReadOnlyDemo(int i)
        {
            Login = i; // Read-only values can be changes only in constructor of the containing class.
        }
        public const int AdminRole = 1;
        public const int EmployeeRole = 3;
        public const int ManagerRole = 2;

        public readonly int Access = 4;
        public readonly int Login = 5;
    }
    public class ConstReadOnlyTest
    {
        static void Main()
        {
            ConstReadOnlyDemo obj = new ConstReadOnlyDemo(10);
            //obj.Login = 4; //Errors out can not assign value to read only property(member)
            var i = ConstReadOnlyDemo.EmployeeRole;
            var j = obj.Access;
            var k = obj.Login;
            //ConstReadOnlyDemo.EmployeeRole = 2; //Can not assign value to const variables
        }
    }

}
