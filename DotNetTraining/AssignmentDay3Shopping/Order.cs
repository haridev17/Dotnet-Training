class Order
{
    private double _tax = 0.01;//10 percent
    public double GetTotalPrice(double productPrice)
    {
        double totalPrice = productPrice + productPrice * _tax;
        return totalPrice;
    }
}

public record ShoppingCartEntry(string Name, int Price, int Quantity);