Person[] persons = new Person[3]
{
    new Person {FirstName = "Nida"}, new Customer {FirstName = "Ela"}, new Student{FirstName = "Zehra"}
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departmant { get; set; }
}