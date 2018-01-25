using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class IEquatableDemo : IEquatable<IEquatableDemo>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Display()
        {
            IEquatableDemo d1 = new IEquatableDemo() { ID = 1, Name = "E1" };
            IEquatableDemo d2 = new IEquatableDemo() { ID = 1, Name = "E1" };

            if(d1.Equals(d2))
                Console.WriteLine("d1 and d2 are equal");
            else
                Console.WriteLine("d1 and d2 are NOT equal");

        }
        public bool Equals(IEquatableDemo other)
        {
            return Name == other.Name && ID == other.ID;
        }
    }
    
}
