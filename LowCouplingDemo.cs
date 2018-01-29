using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class LowCouplingDemo : Demo1
    {
        public void Test()
        {

        }
        //public void Print()
        //{
        //    Demo1 d1 = new Demo1();
        //    d1.Print();
        //}
    }
    public class Demo1
    {
        public void Print()
        {

        }
    }

    class DemoTest
    {
        public void Tester()
        {
            LowCouplingDemo demo = new LowCouplingDemo();
            demo.Print();
        }
    }
}
