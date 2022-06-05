using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal static class Storage
    {
        public static void Interface( ref Product[] products, ref DairyProduct[] dairyproducts,ref  Meat[] meats, ref Buy List)
        {
            int action;
            
            bool act = true;
            while (act)
            {
                Console.WriteLine(" 1. Add Product \n 2. Show Check \n 3. Create Product \n 4. Show Meat \n 5. Change Price");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine(" 1. Product \n 2. Meat \n 3. DairyProduct");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                for (int i = 0; i < products.Length; i++)
                                {
                                    Console.WriteLine(i + ". " + products[i]);
                                }
                                Console.WriteLine("Enter number and count od product");
                                List.AddProduct(products[int.Parse(Console.ReadLine())], int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                for (int i = 0; i < meats.Length; i++)
                                {
                                    Console.WriteLine(i + ". " + meats[i]);
                                }
                                Console.WriteLine("Enter number of meat and count:");
                                List.AddProduct(meats[int.Parse(Console.ReadLine())], int.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                for (int i = 0; i < dairyproducts.Length; i++)
                                {
                                    Console.WriteLine(i + ". " + dairyproducts[i]);
                                }
                                Console.WriteLine("Enter number of dairy product and count:");
                                List.AddProduct(dairyproducts[int.Parse(Console.ReadLine())], int.Parse(Console.ReadLine()));
                                break;

                            default:
                                Console.WriteLine("Erorr!!");
                                break;

                        }
                        break;
                    case 2:
                        List.Show();
                        break;

                    case 3:
                        Console.WriteLine(" 1. Product \n 2. Meat \n 3. DairyProduct");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                for (int i = 0; i < products.Length; i++)
                                {
                                    Console.WriteLine(i + ". " + products[i]);
                                }
                                Console.WriteLine("Enter name, price and weight of product:");
                                Array.Resize(ref products, products.Length + 1);
                                products[products.Length - 1] = new(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Enter name, price, weight, category and type of meat:");
                                Array.Resize(ref meats, meats.Length + 1);
                               //Meat.Category ctg = Enum.TryParse(Meat.Category, Console.ReadLine());
                               //Meat.Type tp = Enum.Parse(Meat.Type, Console.ReadLine());
                               //meats[meats.Length - 1] = new(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), ctg, tp);
                                break;
                            case 3:
                                Console.WriteLine("Enter number of dairy product and count:");
                                Array.Resize(ref dairyproducts, dairyproducts.Length + 1);
                                dairyproducts[dairyproducts.Length - 1] = new(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                                break;
                            

                            default:
                                Console.WriteLine("Erorr;");
                                break;
                        }
                        break;
                    case 4:
                        for (int i = 0; i < meats.Length; i++)
                        {
                            Console.WriteLine(meats[i]);
                        }
                        break;
                    case 5:
                        Console.WriteLine(" 1. Products \n 2. Meats \n 3. Dairy Products ");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                for (int i = 0; i < products.Length; i++)
                                {
                                    Console.WriteLine(i + 1 + "." + products[i]);
                                }
                                products[int.Parse(Console.ReadLine())].ChangePrice(int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                for (int i = 0; i < meats.Length; i++)
                                {
                                    Console.WriteLine((i + 1 + "." + meats[i]));
                                }
                                meats[int.Parse(Console.ReadLine())].ChangePrice(int.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                for (int i = 0; i < dairyproducts.Length; i++)
                                {
                                    Console.WriteLine((i + 1 + "." + dairyproducts[i]));
                                }
                                dairyproducts[int.Parse(Console.ReadLine())].ChangePrice(int.Parse(Console.ReadLine()));
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Change correct action");
                
                break;
                }
            }
            }
        }
    }
