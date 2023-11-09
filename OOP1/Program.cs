using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.Name = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2= new Product()
{
    Id = 2,
    CategoryId = 1,
    Name = "Kalem",
    UnitsInStock = 5,
    UnitPrice = 35
};

ProductManager productManager = new ProductManager();
productManager.Add(product2);
productManager.Update(product1);

/*
int toplamSonucu = productManager.Topla(3,9);
Console.WriteLine(toplamSonucu * 2);*/