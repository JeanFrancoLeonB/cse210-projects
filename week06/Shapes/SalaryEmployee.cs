using System;
public class SalaryEmployee : Employee
{
    private float _salary = 0;

    public SalaryEmployee()
    {
    }
    public float GetSalary()
    {
        return _salary;
    }

    public void SetSalary(float salary)
    {
        _salary = salary;
    }

    public override float GetPay()
    {
        return _salary/12;
    }
}