// See https://aka.ms/new-console-template for more information
//Console.BackgroundColor = ConsoleColor.Red;
//Console.ForegroundColor = ConsoleColor.White;
//Console.Clear();
Console.WriteLine("Hello, World! I am starting learning C#");
Console.WriteLine("I am abhishek sinha");
int a = 15;
Console.WriteLine(a);
float b = 5.45f;
Console.WriteLine(b);
string c = "35";
int cs = Int32.Parse(c);
Console.WriteLine("The String Parced is "+(cs+cs));
string fl = b.ToString();
Console.WriteLine("The string is "+fl);
int sum = a +(int) b;
float sum2 = a + b;
int sum3 = (int)(a+b);
Console.WriteLine(sum);
Console.WriteLine(sum2);
Console.ReadKey();
Console.WriteLine(sum3);
Console.Write("Hello");
Console.WriteLine("Enter a string");
int asc = Console.Read();
Console.WriteLine("ASCII value is {0}",asc);
void hello()
{
    Console.WriteLine("It's a function");
    string str = "AbhishekSinha";
    string domain = Console.ReadLine();
    Console.WriteLine("Hi {0}, you have entered {1}", str,domain);
    char a = '@';
    Console.WriteLine(str + a+domain);
    string up = str.ToUpper();
    Console.WriteLine(up);
    string ab = str.Replace('i', 'x');
    Console.WriteLine(ab);
} 

hello();