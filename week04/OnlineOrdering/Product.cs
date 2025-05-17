

public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _productQuantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _productQuantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _productQuantity;
    }

    public int GetProductId()
    {
        return _productId;
    }

}