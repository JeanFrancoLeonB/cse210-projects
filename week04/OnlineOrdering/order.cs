public class Order
{
    private static List<Product> _products;
    private Customer _customer;

    /*La lista no la consideramos para los constructores, 
    debido al tañano, se inicializa como vacía y luego se
     adicionan los datos*/
    public Order(Customer customer)
    {
        _customer = customer;
        /*Se inicializa la Lista*/
        _products = new List<Product>();
    }
    public void AddProducts(Product productos)
    {
        _products.Add(productos);
    }
    public double TotalCostOrder()
    {
        double ordenesoperaciones = 0;

        foreach (Product x in _products)
        {
            ordenesoperaciones += x.TotalCostProduct();
        }

        if (_customer.IsinUSa())
        {
            ordenesoperaciones = ordenesoperaciones + 5;
        }
        else
        {
            ordenesoperaciones = ordenesoperaciones + 35;
        }

        return ordenesoperaciones;
    }
    public string PackingLabel()
    {
        string Packinglbl = "Lista de Productos \n";

        foreach (Product listaenproducto in _products)
        {
            Packinglbl += listaenproducto.DisplayProduct() + "\n";
        }

        return Packinglbl;
    }
    public string ShippingLabel()
    {
        string Shippinglbl = "Entregar a : " + _customer.DisplayDataCustomer();

        return Shippinglbl;
    }
}