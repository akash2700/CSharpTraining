

using System;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            short sCount = short.MaxValue;
            //Console.WriteLine("short max value " + sCount);


            //Console.WriteLine("short min value " + short.MinValue + " short max value " + short.MaxValue);
            //Console.WriteLine("int min value " + int.MinValue + " int max value " + int.MaxValue);
            //Console.WriteLine("long min value " + long.MinValue + " long max value " + long.MaxValue);


            //Console.WriteLine("long min value " + double.MinValue + " long max value " + double.MaxValue);
            //Console.WriteLine("long min value " + decimal.MinValue + " long max value " + decimal.MaxValue);

            string str = "CSharp Training";
            bool isTrue = true;
            //isTrue = (1 == 2);
            //Console.WriteLine(isTrue);


            //Console.Write("Enter first Value: ");
            //short firstValue = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Enter second Value: ");
            //short secondValue = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Addition of two values " + (firstValue + secondValue));


            /*
             * short, int, long, double, decimal => Value types => Memory allocated in Stack
             * string or objects => Reference types => Memory allocated in Heap, pointer to heap is on stack
             * 
             */
            int testValueTypes = 10;
            Console.WriteLine("int type is " + testValueTypes.GetType());
            Console.WriteLine("is int IsValueType " + testValueTypes.GetType().IsValueType);

            string testType = "test";
            Console.WriteLine("is string IsValueType " + testType.GetType().IsValueType);

            Employee emp = new Employee();
            Console.WriteLine("class type is " + emp.GetType());
            Console.WriteLine("is Class IsValueType " + emp.GetType().IsValueType);

            Employee emp2 = new Employee();
            Employee emp1;
            emp1 = emp; //Both pointers on stack point to same memory allocation on heap.

            Console.WriteLine("emp id " + emp.EmpID);

            emp1.EmpID = 10;
            Console.WriteLine("emp id " + emp.EmpID);
            //As the both pointers to the memory are same emp.EmpID value also gets changes to 10

            Console.WriteLine("emp2 id " + emp2.EmpID);


            //Boxing and Unboxing

            object obj;
            int boxingEx = 10; string strEx = "10";
            obj = boxingEx;

            Console.WriteLine("obj of int type " + obj.GetType());

            obj = strEx;

            int unBox = Convert.ToInt32(obj);
            short sValue = 1; // 8 bytes
            int intValue; // 16 bytes
            Console.WriteLine("unboxed value of int " + unBox);
            intValue = sValue; //Implicit conversion
            Console.WriteLine("value of int " + intValue);
            sValue = (short)(intValue); // Explicit conversion

            sValue = Convert.ToInt16(intValue); //other way of writing the above code

            Int16.TryParse("1", out sValue);

            //int empName = 10; // for integers 1, 2,
            //short shorVar = 1111; // for small values
            //float tes = 10; // decimal; 11.1
            //decimal dec = 10.11111111M;
            //string str = "test";
            //bool booleanValues = true; // or false;
            //double holdint = 20.1;
            //empName = Convert.ToInt32(str);
            //Console.WriteLine(empName);
            //Console.ReadLine();
            // char > int > double > decimal 
            Console.ReadKey();

        }
    }
    
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
    }
}
