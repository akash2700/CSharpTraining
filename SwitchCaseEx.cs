using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class SwitchCaseEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select books category");
            Console.WriteLine("Please enter 'C' for Computer");
            Console.WriteLine("Please enter 'M' for Maths");

            string option = Console.ReadLine().ToUpper();
            char charOption = Convert.ToChar(option.Substring(0, 1));

            switch (charOption)
            {
                case 'C':
                    Console.WriteLine("C by Balaguruswamy");
                    break;
                case 'D':
                case 'M':
                    Console.WriteLine("Randam Math book");
                    break;
                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
            Console.ReadKey();

        }
    }
}
