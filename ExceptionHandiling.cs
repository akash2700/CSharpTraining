using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ExceptionHandiling
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;

            Console.WriteLine("Enter one number");

            string s = Console.ReadLine();
            try
            {
                Console.WriteLine("Try block");
                try
                {
                    Console.WriteLine("Nested try block");
                    
                    b = Convert.ToInt32(s);
                    int c = a / b;
                }
                catch(Exception ex)
                {
                    throw new UserDefinedException(ex.Message);
                }
                finally
                {
                    Console.WriteLine("nested finally");
                }
                Console.WriteLine("After nested exception");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("this is divisible by zero exception block");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Catch block");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genral Catch block");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }


            try
            {
                Console.WriteLine("Another try block");
                int aa = 10;
                int bb = 0;
                int cc = aa / bb;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genral Catch block");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }


            Console.ReadKey();
        }
    }

    public class UserDefinedException : Exception
    {
        public UserDefinedException(string message) : base(message)
        {

        }
    }
}
