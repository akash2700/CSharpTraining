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

            Console.ReadKey();
        }
    }

    class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
