using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ArithmeticOps
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            num1 = num1++ + ++num1;
            num1++; // num1 = num1+1
            int assignAndIncrement = num1++; //Value assigns value and increments itself, simillary for -- (which substracts)

            int incrementAndAssign = ++num1; //Increments itself and assigns the value, simillary for -- (which substracts)

            Console.Write("Enter a number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num1 += num2; //The above line of code and this does the same thing


            int add = num1 + num2;
            Console.WriteLine("Addition of "+num1 + " , " + num2 + " : " + add);

            int sub = num1 - num2;
            Console.WriteLine("Sub of " + num1 + " , " + num2 + " : " + sub);

            int mul = num1 * num2;
            Console.WriteLine("Multiplication of " + num1 + " , " + num2 + " : " + mul);

            int divQou = num1/num2; //Gives only quotent. Ex. 11/3 = 3
            Console.WriteLine("Quotent of " + num1 + " , " + num2 + " : " + divQou);

            int divRem = num1 % num2; //Gives only reminder ex: 11/3 = 2
            Console.WriteLine("Reminder of " + num1 + " , " + num2 + " : " + divRem);

            bool con = num1/ num2 == 0;
            


            bool num1Greate = num1 >= num2;

            bool num2Greater = num1 <= num2;

            bool logicalAnd = num1Greate && num2Greater ; // Logical And Gate, if both are true result is true else false
            bool logicalOr = num1Greate || num2Greater; // Logical OR Gate, if any one is true result is true else false

            bool logocalNot = !logicalOr; //Converts true to false and vice versa

            Console.ReadKey();
        }
    }
}
