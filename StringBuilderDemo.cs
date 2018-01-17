using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class StringBuilderDemo
    {
        public void Print()
        {
            string s = "Training";
            s = "new training";
            s = "new " + "traing";

            StringBuilder str = new StringBuilder();
            str.Append("Hello");
            str.Append("New text");

            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;

            int[] b = new int[5];
            //using For loop copy a[] value to b[]
            //a[0] =b[0];

            //a[5] = 6; Array outofRangeException


            string[] strArray = new string[3] { "first", "second", "third" };

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
