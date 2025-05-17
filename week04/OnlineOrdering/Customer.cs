

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool AddressInUSA()
    {
        return _address.InUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }
}