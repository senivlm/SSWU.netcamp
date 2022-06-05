using Products;

Product[] products = new  Product[2];
Product product = new("Salt", 50, 1);
products[0] = product;
products[1] = new Product("Sugar", 40, 2);
Console.WriteLine(products[1]);
DairyProduct[] dairyproducts = new DairyProduct[1];
dairyproducts[0] = new DairyProduct("Milk", 30, 0.5, 7);
Meat[] meats = new Meat[1];
meats[0] = new Meat("Chicken Breast", 100, 0.9, Meat.Category.HighSort, Meat.Type.chicken);
meats[0].ChangePrice(50);
Console.WriteLine(meats[0]);    
Buy List = new();
Storage.Interface(ref products ,ref dairyproducts, ref meats, ref List);    

