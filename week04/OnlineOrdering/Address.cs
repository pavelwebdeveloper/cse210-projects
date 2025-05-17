

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA()
    {        
            if (_country == "USA")
            {
                return true;
            }
        
                return false;
    }

    public string AddressInfo()
    {
        return $"{_streetAddress}\r\n{_city}, {_state}\r\n{_country}";
    }

}