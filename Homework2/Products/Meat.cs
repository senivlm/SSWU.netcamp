using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Meat : Product
    {
        public enum Category {HighSort, SecondSort};
        public enum Type {mutton, veal,pork, chicken };

        private Category category;
        private Type type;

        public Meat()
        {

        }
        public Meat(string name, double price, double weight, Category category, Type type)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
            this.category = category;
            this.type = type;
        }

        public override string ToString()
        {
            return name + "Category: " + category + "Type: " + type + "; Price:" + price + "; Weight:" + weight;
        }

        public new void ChangePrice(int percent)
        {
            switch (category)
            {
                case Category.HighSort:
                    this.price *= (1 -((double)(percent + 15) / 100));
                    break;
                case Category.SecondSort:
                    this.price *= 1 - ((double)(percent + 5) / 100);
                    break;
            }
        }

    }
}
