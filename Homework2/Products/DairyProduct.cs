using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Products
{
    internal class DairyProduct:Product
    {
        int expirationdate;
       
        public DairyProduct(string name, double price, double weight, int date)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
            this.expirationdate = date;   
        }
        public void ChangePrice(int percent, int date)
        {
            price *=  1 - (percent + (date / expirationdate) * 0.2 )/ 100;
        }
    }
}
