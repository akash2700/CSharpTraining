using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public interface ITraining
    {
        //int a = 10;
        int InterfaceProp { get; set; }
        void Web();
       void ClassRom();
    }

    public interface IInterface
    {
        void Web();
    }

    public class Chandrasen : ITraining, IInterface
    {
        private int _test;
        public int InterfaceProp
        {
            get
            {
                return _test;
            }

            set
            {
                _test = value;
            }
        }

        public void ClassRom()
        {
            Console.WriteLine("This is class room training");
        }

        public void Web()
        {
            Console.WriteLine("This is class Web training");
        }
        void ITraining.Web()
        {
            Console.WriteLine("This is class Web training");
        }

        public static int NewStaticValue = 10;
        public static void Print()
        {
            Console.WriteLine("Static print method");
        }
    }
    public class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Chandrasen.NewStaticValue = 10;
            Chandrasen.Print();

            Chandrasen _c = new Chandrasen();
            _c.ClassRom();
            _c.Web();


            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                    continue;
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
