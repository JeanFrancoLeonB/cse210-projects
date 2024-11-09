using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("PLease enter your grade: ");

        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        string letter = "";

        if (x>= 90){
            letter = "A";
        }
        else if (x>= 80) {
            letter = "B";
        }
           else if (x>= 70) {
            letter = "C";
        }
           else if (x>= 60) {
            letter = "D";
        }
            else {
            letter = "F";
        }

            Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course !");
        }
         else{
            Console.WriteLine("You Failed the course, You can try again, you can do it !");
        }
    }
       
}