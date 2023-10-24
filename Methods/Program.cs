using System;

class Program
{
    static void Main()
{


Add();
var result = Add2(2);

int number1 = 20;
int number2 = 100;
var result2 = Add3(ref number1, number2);


//Console.WriteLine(result2);
//Console.WriteLine(number1);
int result1 = Multiply(2, 4); 
int result3 = Multiply(2, 4, 3);

Console.WriteLine(result1);
Console.WriteLine(result3);

        Console.WriteLine(Add4(7,2,3,4,3,1,5));
}

static void Add()
    {
        Console.WriteLine("Added");
    }



static int Add2(int number1, int number2=30)
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2; 
}

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}
    static int Add4(int number ,params int[] numbers)
    {
        return numbers.Sum();
    }
}