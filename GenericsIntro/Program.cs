using GenericsIntro;

MyList<string> names = new MyList<string>();
names.Add("Nida");

Console.WriteLine(names.Length);

names.Add("Engin");

Console.WriteLine(names.Length);

foreach (var item in names.Items)
{
    Console.WriteLine(item);
}