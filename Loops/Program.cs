DoWhileLoop();

string[] students = new string[3] { "Engin", "Derin", "Salih" };
foreach (var student in students)
{
    Console.WriteLine(student);
}

static void ForLoop()
{
    for (int i = 1; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }

    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;
    while (number > 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now Number is {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}