using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class AccessSpecifiersBase
    {
        public void PublicMethod()
        {
            PrivateMethod();
            Console.WriteLine("This is a public method");
        }
        private void PrivateMethod()
        {
            ProtectedMethod();
            Console.WriteLine("This is a private method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("This is a internal method");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method");
        }
    }

    public class AccessSpecDerived : AccessSpecifiersBase
    {
        public void DerivedMethod()
        {
            base.PublicMethod();
            base.ProtectedMethod();
            base.InternalMethod();
            base.ProtectedInternalMethod();
        }
    }


    class MyClass 
    {
        public  void  Test()
        {
            AccessSpecDerived test = new AccessSpecDerived();
            test.InternalMethod();
            test.ProtectedInternalMethod();
            test.PublicMethod();
            test.DerivedMethod();
        }
    }

    public class AccessTest
    {
        static void Main(string[] args)
        {
            AccessSpecDerived testObj = new AccessSpecDerived();
            testObj.PublicMethod();
            
        }

    }
}
