using System;

class Program
{

    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._company = "BV Ingenieros Sac";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1993;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Nantucket Hotel";
        job2._jobTitle = "Chief Maintance";
        job2._startYear = 2000;
        job2._endYear = 2050;

        Console.WriteLine("Hello World! This is the Resumes Project.");
        /*Console.WriteLine(job1._company); 
        Console.WriteLine(job2._company); */
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Franco Leon CV";


        /*Console.WriteLine(myResume._name);
        Se agrega los trabajos a la variable jobs en la clase Resume*/

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        /*Se verifica en la lista a la variable jobs en la clase Resume*/
        Console.WriteLine(myResume._jobs[1]._jobTitle);

        myResume.Display();
    }
}