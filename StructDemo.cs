using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class StructDemo
    {
        static void Main()
        {
            int a = 10;
            string s = a.ToString();
            s = Convert.ToString(a);
            a = s.ToInt32();

            Console.Write("enter some value:");
            a = Console.ReadLine().ToInt32();

            Console.WriteLine(a);
            Console.ReadKey();
        }
        public void print()
        {
            

            Employee e = new Employee();
            Samples _struct;
            //_struct.SProp = 10;
            _struct.d1 = 10;
            _struct.f1 = 10.1F;
           
        }
    }

    public struct Samples
    {
        public int S1;
        public float f1;
        public double d1;
        private int a;
        public int SProp { get { return a; } set { a = value; } }

    }
}
