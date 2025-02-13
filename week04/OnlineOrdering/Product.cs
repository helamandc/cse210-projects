public class Product
{

    private string _name;
    private string _productId;
    private double _price;
    private int _qty;

    public Product() { }

    public Product(string name, string prodID, double price, int qty)
    {
        _name = name;
        _productId = prodID;
        _price = price;
        _qty = qty;
    }

    public double TotalCost()
    {
        double totalCost = _price * _qty;
        return totalCost;
    }

    public string DisplayProductDetails()
    {
        string prodDetails = _productId + " | " + _name + " | " + "$ " + _price + " | " + _qty + "pcs";
        return prodDetails;
    }

}