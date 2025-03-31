public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsinUSa()
    {
        /*Se retornan _country.ToUpper() == "USA" debido a que el resultado puede ser true o false (Boolean)*/
        /*.toupper vuelve el valor a mayusculas para compararlo*/
        return _country.ToUpper() == "USA";

    }
    public string Display()
    {
        string texto = $"{_street}, {_city}, {_state}, {_country}.";
        return texto;
    }

}