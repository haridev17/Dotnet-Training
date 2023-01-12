//shopping cart
int option = 0;

Console.WriteLine("Enter item to purchase");
Console.WriteLine("1. laptop: Press 1");
Console.WriteLine("2. bag: Press 2");
Console.WriteLine("3. mobile: Press 3");
Console.WriteLine("4. Quit: Press 4");
option = Convert.ToInt32(Console.ReadLine());

ShoppingCartList shoppingCartList = new ShoppingCartList();

switch (option)
{
    case 1:

        ShoppingCartEntry item1 = new ShoppingCartEntry("laptop", 5000, 1);
        shoppingCartList.AddToCart(item1);
        break;

    case 2:
        ShoppingCartEntry item2 = new ShoppingCartEntry("bag", 1500, 1);
        shoppingCartList.AddToCart(item2);
        break;

    case 3:
        ShoppingCartEntry item3 = new ShoppingCartEntry("mobile", 400, 1);
        shoppingCartList.AddToCart(item3);
        break;

    case 4:
        break;

    default:
        Console.WriteLine("invalid choice");
        break;

}



void TotalPrice()
{
    Order order = new Order();
    double totalPrice = shoppingCartList.TotalPriceCalculation();
    Console.WriteLine(order.GetTotalPrice(totalPrice));
}
try
{
    shoppingCartList.PrintCart();
    TotalPrice();
}
catch (Exception e)
{

    Console.WriteLine($"Something went wrong{e.Message}");
}
finally
{
    Console.WriteLine("Shop with us again");
}