using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ArrayListDemo
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(11);
            arrayList.Add("test string value");
            arrayList.Add(12.23);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            if(arrayList.Contains(11))
            {
                Console.WriteLine("Has 11");
            }
            arrayList.Insert(0, "Inserted value");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
