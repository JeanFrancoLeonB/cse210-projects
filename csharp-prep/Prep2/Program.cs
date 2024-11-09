using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number for X: ");
        string valueforx = Console.ReadLine();
        Console.Write("Enter Number for Y: ");
        string valuefory = Console.ReadLine();
        int x = int.Parse(valueforx);

        int y = int.Parse(valuefory);

        if (x>y)
        {
        Console.WriteLine("Greater");
        }
            else if (x<y)
            {
            Console.WriteLine("Less");
            }
            else
            {
                Console.WriteLine("equal");
            }
        

    }
       
}