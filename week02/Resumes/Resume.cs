using System;

public class Resume
{

    public string _name = "";

    public List<Job> _jobs = new List<Job>();


    public Resume()
    {
    }


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

/* ALineas clase Job, luego todotrabajos nombre cualquiera, lista _jobs*/
        foreach (Job todostrabajoscv in _jobs)
        {
            todostrabajoscv.DisplayJobDetails();
        }


    }
}