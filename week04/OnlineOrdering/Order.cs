

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double OrderTotalPrice()
    {
        double totalPrice = 0;

        foreach(Product product in _products)
        {
            totalPrice += product.TotalCost();
        }

        return totalPrice + OneTimeShippingCost();
    }

    private double OneTimeShippingCost()
    {
        if(_customer.AddressInUSA())
        {
            return 5;
        } else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        packingLabel += $"Customer name: {_customer.GetCustomerName()}\r\n";
        foreach(Product product in _products)
        {
            packingLabel += $"Product id: {product.GetProductId()}\r\n";
        }
        return packingLabel;
    }

    public string ShipingLabel()
    {
        return $"{_customer.GetCustomerName()}\r\n{_customer.GetCustomerAddress().AddressInfo()}";
    }

    
}