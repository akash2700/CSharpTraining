using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ConstructorDemo
    {
        public int Num1 { get; set; }
        static int StaticInt;
        public int Num2 { get; set; }
        public string Name { get; set; }
        public string Demo { get; set; }
        public ConstructorDemo()
        {
            Demo = "You are in DEMO";
        }
        static ConstructorDemo()
        {
            StaticInt = 22;
            
        }
        
        public ConstructorDemo(string a) : this()
        {
            Name = a;
        }
        public ConstructorDemo(int a, int b) : this("Chandrasen")
        {
            Num1 = a;
            Num2 = b;
        }
    }

    class Demo
    {

        static void Main(string[] args)
        {
            ConstructorDemo cDemo = new ConstructorDemo();
            cDemo.Num1 = 1;
            cDemo.Num2 = 2;
            ConstructorDemo cDemoStatic = new ConstructorDemo();
            cDemo.Num1 = 1;
            cDemo.Num2 = 2;
            ConstructorDemo cDemoParm = new ConstructorDemo("test");
            ConstructorDemo cDemoParm1 = new ConstructorDemo(1,2);

            string s = "My Name";
            DateTime date = DateTime.Now;
            Console.WriteLine("DateTime demo: " + date);

            date = date.AddDays(-7);
            date = date.AddHours(2);
            date = date.AddYears(2);

            Console.WriteLine("DateTime addYear demo: " + date.Year);
            Console.WriteLine("Is current year leap year " + DateTime.IsLeapYear(date.Year));
            Console.WriteLine("DateTime add days demo: " + date.ToLongDateString());
            Console.WriteLine("DateTime add days demo: " + date.ToShortDateString());
            Console.WriteLine("DateTime add days demo: " + date.ToLongTimeString());
            Console.WriteLine("DateTime add days demo: " + date.ToShortTimeString());

            Console.ReadKey();
        }


    }

}
