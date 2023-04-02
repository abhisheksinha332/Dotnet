// See https://aka.ms/new-console-template for more information
internal class Loops
{
    public Loops()
    {
    }
    public void forloop()
    {
        Console.WriteLine("====================This is for loop=================");
        for(int i=0; i<10;i++)
        {
            Console.WriteLine("The number is " + i);
        }
    }
    public void doWhile()
    {
        Console.WriteLine("====================This is DoWhile loop=================");
        int a = 0;
        do
        {
            Console.Write(a);
            a++;
        }while (a < 4) ;
    }

    public void breakContinue()
    {
        Console.WriteLine("====================This is Break and Continue=================");
        for(int i=0; i <= 10; i++)
        {
           
            if(i == 3)
            {
                Console.WriteLine("Damn.... I don't like 3");
                continue;
            }
            if(i == 5)
            {
                Console.WriteLine("I am getting out of this loop..5 is enough for me");
                break;
            }
            Console.WriteLine(i);
        }
    }
}