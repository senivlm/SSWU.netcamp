using Products;

Product Salt = new Product("Salt", 50, 1);
Product Meat = new Product("Meat", 100, 2);

Buy List1 = new();

List1.AddProduct(Meat, 3);

List1.AddProduct(Salt, 4);

//List1.RemoveProduct(1, 4);

Check.ShowCheck(List1);


