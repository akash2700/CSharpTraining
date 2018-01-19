using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class StackDemo
    {
        static void Main()
        {
            Stack st = new Stack();
            st.Push("one");
            st.Push(2);
            st.Push(3.0);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            var i = st.Pop(); //Value will be removed from stack
            Console.WriteLine("poped value " + i.ToString());
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
}
