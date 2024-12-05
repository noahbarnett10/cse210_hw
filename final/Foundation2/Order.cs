

class Order
{
    private float _shippingCost;
    private List<Product> products = new List<Product>();
    private Customer _customer; 

    public Order(Customer customer)
    {
        _customer = customer;
        _shippingCost = _customer.IsInUSA() ? 5.00f : 35.00f;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product product in products)
        {
            total += product.TotalCost();
        }
        total += _shippingCost;
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel= "";
        for (int i = 0; i < products.Count; i++)
        {
            packingLabel += $"Product: {products[i].ProductName}, Qty {products[i].ProductQuantity} (ID: {products[i].ProductID}) @ ${products[i].ProductPrice} each";
        
            if (i < products.Count - 1)
            {
                packingLabel += "\n";
            }
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer:\n{_customer.CustomerInfo()}\n---------------\nShipping Cost: ${_shippingCost}\n---------------";
    }

}