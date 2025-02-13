public class Customer
{

    private string _name;
    private Address _address = new Address();

    public Customer() { }
    public Customer(Address address, string name)
    {
        _address = address;
        _name = name;
    }
    public string GetDisplayInfo()
    {
        string info = _name + " | " + _address.FullAddress();
        return info;
    }

}