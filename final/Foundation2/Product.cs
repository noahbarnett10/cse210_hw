

class Product
{
    private string _productName;
    private string _productID;
    private float _productPrice;
    private int _productQuantity;

    public Product(string productName, string productID, float productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public float TotalCost()
    {
        float totalProductCost = _productPrice * _productQuantity;
        return totalProductCost;
    }

    public string ProductName
    {
        get {return _productName;}
    }
   public int ProductQuantity
    {
        get {return _productQuantity;}
    }
    public string ProductID
    {
        get {return _productID;}
    }
     public float ProductPrice
    {
        get {return _productPrice;}
    }

}