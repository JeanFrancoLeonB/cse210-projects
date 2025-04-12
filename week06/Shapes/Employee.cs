using System;
public abstract class Employee
{
    protected string _name;
    protected string _idnumber;

    public Employee()
    {
    }

    public string Getname()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetIdNumber()
    {
        return _idnumber;
    }

    public void SetIdNumber(string idNumber)
    {
        _idnumber = idNumber;
    }

    public abstract float GetPay();
    
}