using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastExam
{
    public class Book : Product
    {
        private int tax;
        public Book(string productId, string name, int price, string producer) : base(productId, name, price, producer)
        {
        }

        public override double computeTax()
        {
            this.tax = this.Price * 8 / 100;
            return this.tax;
        }
    }
}
