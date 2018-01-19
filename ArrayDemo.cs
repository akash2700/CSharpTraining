using System;

namespace CSharpTraining
{
    public class ArrayDemo
    {
        static void Main(string[] args)
        {

            int[] a = new int[5];
            int[] b = { 11, 22, 323, 12, 21 };
            int[] c = new int[5] { 11, 22, 323, 12, 21 };

            a[0] = 12;
            a[1] = 233;
            a[2] = 211;
            a[3] = 2;
            a[4] = 54;
            Console.WriteLine("Array values");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Array.Reverse(a);
            
            Console.WriteLine();
            Console.WriteLine("Reversed Array values");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Array.Copy(a, b, 5);
            Console.WriteLine();
            Console.WriteLine("Copied to Array 'b' values");

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Array.Sort(b);
            Console.WriteLine();
            Console.WriteLine("Sorted Array values");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.WriteLine(Array.IndexOf(a, 12));

            Console.ReadKey();
        }
    }
}
