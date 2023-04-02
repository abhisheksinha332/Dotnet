// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
const string name1 = "Shreya", name2 = "Mitu", name3 = "Gurnoor";

// Exception

/*
Console.WriteLine("Enter first number");
string s1 = Console.ReadLine();
Console.WriteLine("Enter second number");
string s2 = Console.ReadLine();

try
{
    int a1 = int.Parse(s1);
}
catch (ArgumentNullException)
{
    Console.WriteLine("The value was empty");
}
catch (FormatException)
{
    Console.WriteLine("Wrong format");
}
catch (OverflowException)
{
    Console.WriteLine("Number too long");
}


int a2 = int.Parse(s2);


*/

// Methods 


static void iAmWriting()
{
    insideMethods("I am Abhishek Sinha");
    Console.WriteLine("This is inside method");
    insideMethod();
    Console.WriteLine(add(4, 5));
    Console.WriteLine(Greet(name1));
    Console.WriteLine(Greet(name2));
    Console.WriteLine(Greet(name3));
    Console.WriteLine(UserInput());
    Console.ReadKey();
}
//iAmWriting();
static void insideMethod()
{
    Console.WriteLine(" This is method inside method");
}
static void insideMethods(string iAmText)
{
    Console.WriteLine(" This is method inside method part 2");
    Console.WriteLine(iAmText);
}

static int add(int a, int b)
{
    int sum = a + b;
    return sum;
}


static string Greet(string name)
{
    return $"Hi {name}, How are you";
}
//Console.WriteLine(Greet(name1)); 

static int UserInput()
{
    int C1 = 34;
    int C2 = 45;
   /* Console.WriteLine("Enter first number");
    string x1 = Console.ReadLine();
    Console.WriteLine("Enter second number");
    string x2 = Console.ReadLine();


    try
    {
        int f1 = int.Parse(x1);
    }
    catch (Exception)
    {
        Console.WriteLine("Wrong format");
    }

    int f2 = int.Parse(x2);*/
    return C1 + C2;
}

int num1 = 5, num2 = 3, num3;
bool isSunny = true;
Console.WriteLine(!isSunny);
Console.WriteLine(++num1);
Console.WriteLine(num1++);
Console.WriteLine(++num1);
Console.WriteLine(num1++);
Console.WriteLine(num1 + ++num1);


Console.ReadKey();