using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class MethodOverloading
    {
        private int _demo;
        public int MyDetailsProp
        {
            get
            {
                return _demo;
            }
            set
            {
                _demo = value;
            }
        }
        public MethodOverloading()
        {
            MyIntProperty = 10;
            MyDetailsProp = 2;
        }
        public void Display()
        {
            //MyIntGetProperty = 10; //Errors out, as SET is not defined
        }
        public int MyIntProperty { get; set; }

        public int MyIntGetProperty { get; }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }
        public double Add(double a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class BaseClass
    {
        public int MyProperty { get; set; }
        public void BaseDisplay()
        {
            Console.WriteLine("Base Class");
        }
    }
    class DerivedClass : BaseClass
    {
        public int DerivedProp { get; set; }
        public void DerivedDisplay()
        {
            MyProperty = 2;
            base.MyProperty = 2;

            BaseDisplay();
            base.BaseDisplay();

            Console.WriteLine("Derived Class");
        }
    }
    class SeconsLevelInheritence : DerivedClass
    {
        public void Demo()
        {
            base.BaseDisplay();
            base.DerivedDisplay();
        }
        public void DerivedDisplay()
        {
            //
        }
    }
}
