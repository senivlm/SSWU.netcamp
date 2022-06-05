using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Buy
    {
        int[] Counts = new int[0];
        Product[] Products = new Product[0];
        double weight = 0;
        double price;

        public Buy()
        {

        }

        public void AddProduct(Product product, int count)
        {
            Array.Resize(ref this.Counts, Counts.Length + 1);
            Counts[Counts.Length - 1] = count;
            Array.Resize(ref this.Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
            weight += product.weight * count;
            price += product.price * count;
        }

        public void RemoveProduct(int n, int count)
        {
            if (count < Counts[n])
            {
                Counts[n] -= count;
                weight -= count * Products[n].weight;
                price -= count * Products[n].price;
            }
            else
            {   
                weight -= Products[n].weight * count;
                price -= Products[n].price * count;
                for(int i = n + 1; i < Counts.Length; i++)
                {
                    Products[i - 1] = Products[i];
                    Counts[i - 1] = Counts[i];
                }
                Array.Resize(ref this.Counts, Counts.Length - 1);
                Array.Resize(ref this.Products, Products.Length - 1);

            }

            
        }

        public void Show()
        {
            for(int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(i +".  " + Products[i].name + "- counts:" + Counts[i]);

            }
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Weight: " + weight);
        }

        public int GetSize()
        {
            return Counts.Length;
        }

        public Product GetProduct(int n)
        {
            return Products[n];
        }

        public int GetCount(int n)
        {
            return Counts[n];
        }

        public double GetWeight()
        {
            return weight;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
