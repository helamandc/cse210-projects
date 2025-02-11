using System.Runtime.InteropServices;

public class Order
{

    private string _customer;
    private string _products;

    public Order() { }

    public double TotalCost()
    {
        double totalCost = 0;
        return totalCost;
    }
    public string PackingLabel()
    {
        return _customer;
    }
    public string ShippingLabel()
    {
        return _customer;
    }
    public void GetDisplayText()
    {

    }

}