using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Loops
    {
        static void Main(string[] args)
        {
            Addition:
            Console.Write("Enter first number: ");
            string a = Console.ReadLine();
            Console.Write("Enter second number: ");
            string b = Console.ReadLine();

            int addition = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine("Addition of two numers is " + addition);

            Console.Write("Enter # to calcualte again. Press anyother key to exit ");
            string c = Console.ReadLine();
            if (c == "#")
                goto Addition;

            string cc = "#";
            do
            {
                Console.Write("Enter first number: ");
                string aa = Console.ReadLine();
                Console.Write("Enter second number: ");
                string bb = Console.ReadLine();

                int addition1 = Convert.ToInt32(aa) + Convert.ToInt32(bb);

                Console.WriteLine("Addition of two numers is " + addition1);

                Console.Write("Enter # to calcualte again. Press anyother key to exit ");
                cc = Console.ReadLine();
            } while (cc == "#");

            while (cc == "#")
            {
                Console.Write("Enter first number: ");
                string aa = Console.ReadLine();
                Console.Write("Enter second number: ");
                string bb = Console.ReadLine();

                int addition1 = Convert.ToInt32(aa) + Convert.ToInt32(bb);

                Console.WriteLine("Addition of two numers is " + addition1);

                Console.Write("Enter # to calcualte again. Press anyother key to exit ");
                cc = Console.ReadLine();
            }

        }
    }
}
