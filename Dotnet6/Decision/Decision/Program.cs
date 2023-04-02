// See https://aka.ms/new-console-template for more information
using Decision;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int num = 2;
        if (num <= 5)
        {
            Console.WriteLine("{0} is less than 6", num);
        }
        else if (num <= 8)
        {
            Console.WriteLine("{0} is greater than 5 but less than 9", num);
        }
        else
        {
            Console.WriteLine("{0} is greater than 8", num);
        }

        try
        {
            int b = 1;
            int a = 5 / b;
            Console.WriteLine(a);
        }
        catch (Exception)
        {
            Console.WriteLine("you cannot divide number by zero");
        }

        string s = "123x";
        int n;
        bool bo = int.TryParse(s, out n);
        Console.WriteLine(bo);
        Console.WriteLine(n);
        if (bo)
        {
            Console.WriteLine("Parsing successful");
        }
        else
        {
            Console.WriteLine("Parsing Unsuccessful");
        }

        Console.WriteLine("Enter the temperature please");
        string temperature = Console.ReadLine();
        int temp;
        int numb;
        if (int.TryParse(temperature, out temp))
        {
            numb = temp;

        }
        else
        {
            numb = 0;
        }

        Console.WriteLine(numb);



        Class1 obj = new Class1();
        obj.data();

        Loops obj1 = new Loops();
        obj1.forloop();
        obj1.doWhile();
        obj1.breakContinue();

        Human name = new Human("abhishek", "sinha");
        name.firstname = "Abhishek";
        name.intro();
        name.firstname = "Ayush";
        name.intro();
        Human details = new Human("abhishek", "sinha", "black", 23);
        details.introduction();
    }
}