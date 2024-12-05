

class Customer
{
    private string _customerName;
    private Address _customerAddress; 

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string CustomerInfo()
    {
        return $"{_customerName}\n---------------\nAddress:\n{_customerAddress.GetAddress()}";
    }

     public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }

}