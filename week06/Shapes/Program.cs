using System;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {/*
        Console.WriteLine("Hello World! This is the Shapes Project.");

        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("Jhon");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456def");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);


        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }
    */

    // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }

    /*
    public static void DisplayEmployeeInformation(Employee employee)
    {


        float pay = employee.GetPay();
        Console.WriteLine($"{employee.Getname()} will be paid ${pay}");
    }
    */
    

}