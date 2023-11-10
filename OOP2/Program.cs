using OOP2;

GercekMusteri customer1 = new GercekMusteri();
customer1.Id = 1;
customer1.TcNo = "243131";

TuzelMusteri customer2 = new TuzelMusteri();
customer2.Id = 2;
customer2.CustomerNumber = "1312321";
customer2.TaxId = "38292";

Customer customer3 = new GercekMusteri();
Customer customer4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);