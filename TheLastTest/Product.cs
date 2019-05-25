using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastExam
{
    public abstract class Product
    {
        String productId;
        String name;
        int price;
        String producer;

        public Product(string productId, string name, int price, string producer)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public String ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                this.productId = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }

        public String Producer
        {
            get
            {
                return producer;
            }
            set
            {
                this.producer = value;
            }
        }

        public abstract double computeTax();
    }
}
