class ShoppingCartList
{
    public readonly List<ShoppingCartEntry> _shopingCart;
    public ShoppingCartList()
    {
        _shopingCart = new List<ShoppingCartEntry>();
    }
    public void AddToCart(ShoppingCartEntry product)
    {
        _shopingCart.Add(product);
    }
    public void PrintCart()
    {
        foreach (var item in _shopingCart)
        {
            Console.WriteLine(item);
        }
    }
    public double TotalPriceCalculation()
    {
        double total = 0.0;
        foreach (var item in _shopingCart)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
}