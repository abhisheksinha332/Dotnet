// See https://aka.ms/new-console-template for more information
internal class Class1
{
    public Class1()
    {
      
    }
    public void details()
    {
        Console.WriteLine("Hello ! I am Abhishek Sinha");
    }
    public void data()
    {
        Console.WriteLine("This is class1");
        int comp = 9;
        string data = comp > 10 ? "Greater than 10" : comp>8? "Greater than 8" : "Smaller than 8";
        Console.WriteLine(data);
        details();
    }
}