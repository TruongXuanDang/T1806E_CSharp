using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> arrayList = new List<Product>();
            double totalTax = 0;

            arrayList.Add(new Book("b1", "Harry Potter", 80000, "JK Rowling"));
            arrayList.Add(new Book("b2", "Doraemon", 6000, "Fujiko"));
            arrayList.Add(new Book("b3", "One Punch Man", 8000, "Mirataku"));

            arrayList.Add(new MobilePhone("m1", "SamsungS6", 5000000, "Samsung"));
            arrayList.Add(new MobilePhone("m2", "Iphone6", 8000000, "Apple"));
            arrayList.Add(new MobilePhone("m3", "BPhone3", 10000000, "BKAV"));

            foreach (var product in arrayList)
            {
               if(product is Book)
                {
                    totalTax += product.computeTax();
                    Console.WriteLine("Tax of "+product.ProductId+"--"+product.computeTax());
                }
                else if (product is MobilePhone)
                {
                    totalTax += product.computeTax();
                    Console.WriteLine("Tax of " + product.ProductId + "--"+product.computeTax());
                }
            }

            Console.WriteLine("Total Tax: "+totalTax);
            Console.ReadKey();
        }
    }
}
