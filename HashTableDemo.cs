using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class HashTableDemo
    {
        public HashTableDemo()
        {
            
        }
        public void HashDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add("two", 2222);
            ht.Add(2.3, 2121);
            Console.WriteLine(ht[1]);
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //Dictornary Demo

            Dictionary<int, string> dictonary = new Dictionary<int, string>();
            dictonary.Add(1, "test");
            dictonary.Add(2, "two");

            Console.WriteLine(dictonary[1]);

            Dictionary<int, Employee> d1 = new Dictionary<int, Employee>();

            d1.Add(3, new Employee { EmpID = 1, EmpName = "test3" });
            d1.Add(4, new Employee { EmpID = 2, EmpName = "test4" });

            foreach (var item in d1)
            {
                Console.WriteLine("Key " + item.Key + " EmpID " + item.Value.EmpID + " EmpName:" + item.Value.EmpName);
            }

            Console.ReadKey();

        }
    }
}
