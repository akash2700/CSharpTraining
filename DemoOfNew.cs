using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("A::Test()");
        }

        public virtual void Print()
        {
            Console.WriteLine("A::Print()");
        }
        public void Display()
        {
            Console.WriteLine("A::Display()");
        }
    }
    class B : A
    {
        public new void Test()
        {
            Console.WriteLine("B::Test()");
        }

        public override void Print()
        {
            Console.WriteLine("B::Print()");
        }
        public new virtual void Display()
        {
            Console.WriteLine("B::Display()");
        }
    }
    class C : B
    {
        public new void Test()
        {
            Console.WriteLine("C::Test()");
        }

        public override void Print()
        {
            Console.WriteLine("C::Print()");
        }
        public override void Display()
        {
            Console.WriteLine("C::Display()");
        }
    }
    class DemoOfNew
    {
        static void Main(string[] args)
        {
            A a = new A();            B b = new B();
            C c = new C();

            //a.Test(); // output --> "A::Test()"
            //b.Test(); // output --> "B::Test()"
            //c.Test(); // output --> "C::Test()"

            //a.Print(); // output --> "A::Print()"
            //b.Print(); // output --> "B::Print()"
            //c.Print(); // output --> "C::Print()"

            //a.Display(); // output --> "A::Display()"
            //b.Display(); // output --> "B::Display()"
            //c.Display(); // output --> "C::Display()"

            a = new B();
            a.Test(); // output --> "A::Test()"
            a.Print(); // output --> "B::Print()"
            a.Display(); // output --> "A::Display()"

            b = new C();
            b.Test(); // output --> "B::Test()"
            b.Print(); // output --> "C::Print()"
            b.Display(); // output --> "C::Display()"

            Console.ReadKey();
        }
    }
}
