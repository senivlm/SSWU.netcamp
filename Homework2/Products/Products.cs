using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        private string Name;
        private double Price;
        private double Weight;

        public Product(string name, double price, double weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public Product()
        {
            this.Name = "";
            this.Price = 0;
            this.Weight = 0;
        }

        public void ChangePrice( int percent)
        {
            this.Price *= (1 - (double)percent / 100);
        }

        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public double weight { get => Weight; set => Weight = value; }

        public override string ToString()
        {
            return Name + "; Price:" + price + "; Weight:" + weight;
        }
        

    }
}
