using Methods2;

string productName = "Elma";
double price = 1;
string description = "Amasya elması";

string[] fruits = new string[] { };

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya elması";

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır karpuzu";

Product[] products = new Product[] { product1 , product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
}

Console.WriteLine("----------------");

CartManager cartManager = new CartManager();
cartManager.Add(product1);
cartManager.Add(product2);