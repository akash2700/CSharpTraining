using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class QueueDemo
    {
        static void Main()
        {
            HashTableDemo demo = new HashTableDemo();
            demo.HashDemo();
            Queue st = new Queue();
            st.Enqueue("one");
            st.Enqueue(2);
            st.Enqueue(3.0);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            
            var i = st.Dequeue(); //Value will be removed from stack
            Console.WriteLine("Dequeue value " + i.ToString());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            var j = st.Peek(); //Value will be there in stack
            Console.WriteLine("peeked value " + j.ToString());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Queue<string> strQueue = new Queue<string>();
            strQueue.Enqueue("one");
            strQueue.Enqueue("two");
            //ListDemo li = new ListDemo();
            Console.ReadKey();

            int x = 10, y = 20;
            var result = (x > y) ? "x is greater" : "y is greater";


            var k = 10; // k type is Int here 
            int l = 10; // above line and these line of code are equal
            //l = "test"; // Errors out as l is int type. 
            // Var dataType is defined by first assignemt operation and it stays for the entire scope

            dynamic d = 1;
            d = "one";


            object aa = new object();
            aa = "123";
            aa = 123;
            object bb = 234;
            object emp = new Employee{ EmpID = 1, EmpName = "Test" };

        }
    }

    class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
