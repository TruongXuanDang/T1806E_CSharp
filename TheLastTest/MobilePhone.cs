using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastExam
{
    class MobilePhone : Product
    {
        private int tax;
        public MobilePhone(string productId, string name, int price, string producer) : base(productId, name, price, producer)
        {

        }
        public override double computeTax()
        {
            this.tax = this.Price * 10 / 100;
            return this.tax;
        }
    }
}
