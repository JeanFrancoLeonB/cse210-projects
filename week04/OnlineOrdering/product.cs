public class Product
{
    private string _name;
    private int _ID;
    private double _price;
    private int _cuantity;

    public Product(string name, int ID , double price, int cuantity )
    {
   _name = name;
   _ID = ID;
   _price = price;
   _cuantity = cuantity;
    }
    public double TotalCostProduct()
    {
        double operacion = _cuantity * _price;
        return operacion;
    }
      public string DisplayProduct()
    {
         string texto = $"{_name}, {_ID}.";
        return texto;
    }
}