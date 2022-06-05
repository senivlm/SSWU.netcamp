using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    static class Check
    {
        public static void ShowCheck(Buy List)
        {
            for (int i = 0; i < List.GetSize(); i++)
            {
                Console.Write(List.GetProduct(i));
                Console.WriteLine("- Counts: " + List.GetCount(i));
            }
            Console.WriteLine("Weight: " + List.GetWeight());
            Console.WriteLine("Price: " + List.GetPrice());
        }
    }
}
