using System;
public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;


    public HourlyEmployee()
    {
    }
    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }
    public int GetHoursWorked
    {
        return _hoursWorked;
    }
    public void SetHoursWorked(int hoursworked)
    {
        _hoursWorked = hoursworked;
    }
}