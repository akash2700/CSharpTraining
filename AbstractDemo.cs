using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class RandamBase
    {
        public RandamBase()
        {
            Console.WriteLine("From RandamBase class constructor");
        }
        public void RandamTest()
        {
            Console.WriteLine("From randam test method");
        }

        public virtual void VirtualDemo()
        {
            Console.WriteLine("From RandamBase class VirtualDemo method");
        }

        //Gives error. Abstract methods can only exist in Abstract class.
        //public abstract void RandamAbs();
    }
    public abstract class AbstractDemo : RandamBase
    {
        public int MyProperty { get; set; }
        public AbstractDemo()
        {
            Console.WriteLine("From abstract class constructor");
        }

        public abstract void TestAbstract();
        public void NoramlMethod()
        {
            Console.WriteLine("From abstract class NoramlMethod");
        }
        //public void NoramlMethodTest(); Gives error
    }

    public class AbstractDerivedClass : AbstractDemo
    {
        public AbstractDerivedClass()
        {
            Console.WriteLine("From AbstractDerivedClass class constructor");
        }
        public override void TestAbstract()
        {
            Console.WriteLine("From AbstractDerivedClass and TestAbstract method");
        }
        public override sealed void VirtualDemo()
        {
            Console.WriteLine("From AbstractDerivedClass and VirtualDemo method");
        }

        //Method in the base class should be abstarct or virtual to be overriden
        //public override void NoramlMethod()
        //{
        //
        //}
    }

    public class SealedDemo : AbstractDerivedClass
    {
        public SealedDemo()
        {
            Console.WriteLine("From SealedDemo class constructor");
        }
        public override void TestAbstract()
        {
            Console.WriteLine("From SealedDemo and TestAbstract method");
        }
        
        //Can not ovveride sealed member
        //public override void VirtualDemo()
        //{
        //    Console.WriteLine("From SealedDemo and VirtualDemo method");
        //}
    }

    public sealed class NewSealedDemo
    {
        public NewSealedDemo()
        {

        }
    }

    //Sealed classes can not be inherited
    //public class NewSelaedTest : NewSealedDemo
    //{

    //}


    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("From Animal class constructor");
        }

        public virtual void Food()
        {
            Console.WriteLine("Eats anything");
        }
    }

    public class Cow : Animal
    {
        public Cow()
        {
            Console.WriteLine("From Cow class constructor");
        }

        public override void Food()
        {
            Console.WriteLine("Eats grass");
        }
    }

    public class AnimalTest
    {
        public void TestAnimal(Animal a)
        {
            a.Food();
        }
    }

    public class AbstarctTest
    {
        static void Main(string[] args)
        {

            AnimalTest test = new AnimalTest();
            Animal animal = new Animal();
            Cow cow = new Cow();
            test.TestAnimal(animal);
            test.TestAnimal(cow);
            //Can not create object for Abstract class.
            //AbstractDemo _absDem0 = new AbstractDemo();

            //AbstractDerivedClass demo = new AbstractDerivedClass();
            //demo.NoramlMethod();
            //demo.RandamTest();
            //demo.TestAbstract();
            //demo.VirtualDemo();

            Console.ReadKey();
        }
    }
}
