using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class RefAndOutDemo
    {
        static int RefValueTest(int k)
        {
            k++; // k = k+1;
            return k;
        }
        static int RefTest(ref int k)
        {
            k++; // k = k+1;
            return k;
        }
        static int OutTest(out int k)
        {
            k = 11;
            k++;
            return k;
        }
        static void Main()
        {
            int i = 10;
            int a;
            Console.WriteLine("i value is:" + i);
            i = RefValueTest(i); //
            var j = RefTest(ref i);
            //RefTest(a); //As 'a' doesn't have any memory we can not pass by reference

            var l = OutTest(out i);
            OutTest(out a);
            Console.WriteLine("i value after method call is:" + i);

            /*
             * Access static class
             * 
             */

            StaticDemo.EmpId = 10;
            StaticDemo.GetAllEmployeese();
            //StaticDemo s = new StaticDemo(); //Object can not be created on static class

            NonStaticClass.GetAllEmployeese();

            NonStaticClass test = new NonStaticClass();
            
            NonStaticClass.StaticProp = 11;

            Console.ReadKey();
        }
    }


    public static class StaticDemo
    {
        public static int EmpId;

        public static void GetAllEmployeese()
        {

        }
        //public int MyProperty { get; set; }
        //public void Print()
        //{

        //}
    }
    public class NonStaticClass
    {
        public int MyProperty { get; set; }
        public static int StaticProp { get; set; }

        public void Print()
        {

        }
        public static void GetAllEmployeese()
        {
            StaticProp = 10;
            //MyProperty = 10;
        }
    }
}
