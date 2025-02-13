using System.Runtime.InteropServices;

public class Order
{

    private Customer _customer = new Customer();
    private Product _products = new Product();

    public Order() { }

    public Order(Customer cust, Product prod)
    {
        _customer = cust;
        _products = prod;
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        return totalPrice;
    }
    public string PackingLabel()
    {
        return _products.DisplayProductDetails();
    }
    public string ShippingLabel()
    {
        return _customer.GetDisplayInfo();
    }
}