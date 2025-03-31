using System.ComponentModel;

public class Customer
{
    private string _name;
    /*La clase Address ahora es una variable AssressCustomer*/
    private Address _addressCustomer;
    public Customer(string name, Address addressCustomer)
    {
        _name = name;
        _addressCustomer = addressCustomer;
    }
    public bool IsinUSa()
    {
        /*Ya es un verdadero o un falso*/
         return _addressCustomer.IsinUSa();
    }
       public string DisplayDataCustomer()
    {
         string texto = $"Nombre : {_name}, Dirección : {_addressCustomer.Display()}";
        return texto;
    }

}