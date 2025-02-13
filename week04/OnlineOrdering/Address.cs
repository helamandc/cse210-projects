public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address() { }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string FullAddress()
    {
        string fullAddress = char.ToUpper(_street[0]) + _street.Substring(1) + ", " + char.ToUpper(_city[0]) + _city.Substring(1) + ", " + char.ToUpper(_state[0]) + _state.Substring(1) + ", " + char.ToUpper(_country[0]) + _country.Substring(1);
        return fullAddress;
    }

}