using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("A Wonderful Picture Book");
        book2.SetIlustrator("Burton");

        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edwards", "Another Book");
        Console.WriteLine(book3.GetBookInfo());


        PictureBook book4 = new PictureBook("Edwards", "Another Book", "Ilustratorx");
        Console.WriteLine(book4.GetPictureBookInfo());


            
            /*Segundo Ejercicio*/



        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}

