double number5 = 10.4;
decimal number6 = 10.4m;
char character = 'A';
string city = "Ankara";
bool condition = false;
byte number4 = 0; //8 bit
short number3 = -32768; //16 bit
int number1 = 10; //32 bit
long number2 = 2; //64 bit
var number7 = 10;
number7 = 'A';

Console.WriteLine("Number is {0}",number1);
Console.WriteLine("Number is {0}", number2);
Console.WriteLine("Number is {0}", number3);
Console.WriteLine("Number is {0}", number4);
Console.WriteLine("Number is {0}", number5);
Console.WriteLine("Number is {0}", number6);
Console.WriteLine("Number is {0}", number7);
Console.WriteLine("Character is {0}",(int) character);
Console.WriteLine((int)Days.Friday); 

Console.ReadLine();

enum Days
{
    Monday=10,Tuesday,Wednesday, Thursday, Friday,Saturday,Sunday
}