using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    
    public class IComparableDemo 
    {
       

        public void Displaly()
        {
            List<Product> products = new List<Product>()
            {
                new Product {ID = 2, Name = "P2" },
                new Product {ID = 1, Name = "P1" },
                new Product {ID = 3, Name = "P2" },
                new Product {ID = 3, Name = "P1" }
            };

            Console.WriteLine("Unsorted products");
            foreach (var item in products)
            {
                Console.WriteLine("Product Id:{0}, Name:{1}", item.ID, item.Name);
            }

            products.Sort();
            Console.WriteLine("Sorted products");
            foreach (var item in products)
            {
                Console.WriteLine("Product Id:{0}, Name:{1}", item.ID, item.Name);
            }

            ProductSort sortBy = new ProductSort();
            sortBy.SortFeild = SortOrder.Name;
            products.Sort(sortBy);
            Console.WriteLine("Sorted by Name products");
            foreach (var item in products)
            {
                Console.WriteLine("Product Id:{0}, Name:{1}", item.ID, item.Name);
            }
        }
    }

    public class Product : IComparable<Product>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Product other)
        {
            //return other.ID.CompareTo(ID);
            return ID.CompareTo(other.ID);
        }
    }

    public class ProductSort : IComparer<Product>
    {
        public SortOrder SortFeild { get; set; }
        public int Compare(Product x, Product y)
        {
            switch(SortFeild)
            {
                case SortOrder.ID:
                    return x.ID.CompareTo(y.ID);
                case SortOrder.Name:
                    return x.Name.CompareTo(y.Name);
                default:
                    return x.ID.CompareTo(y.ID); //(x> y) 1, else if (y > x) -1 else 0
            }
        }
    }

    public enum SortOrder
    {
        ID
        ,Name
    }

}
