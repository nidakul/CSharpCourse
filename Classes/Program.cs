
using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1; 
customer.City = "Ankara";
customer.FirstName = "Nida";
customer.LastName = "Kul";

Customer customer2 = new Customer
{
    Id = 2,
    City = "İstanbul",
    FirstName = "Engin",
    LastName = "Demiroğ"
};

Console.WriteLine(customer2.FirstName);