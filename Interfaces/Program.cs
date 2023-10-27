using Interfaces;

PersonManager personManager = new PersonManager();
personManager.Add(new Customer
{
    Id = 1,
    FirstName = "Zehra",
    LastName = "Kul",
    Address = "İstanbul"
});

Student student = new Student
{
    Id = 1,
    FirstName = "Ela",
    LastName = "Kul",
    Departmant = "Computer Sciences"
};

personManager.Add(student);

IPerson person = new Customer();

//Demo();

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}