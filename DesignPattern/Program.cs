using DesignPattern;

Customer customer = new Customer();
Customer customerVIP = new Customer { Orders = new int[50] };

IVIPShoppingFactory factory1 = GetFactory(customer);
IVIPShoppingFactory factory2 = GetFactory(customerVIP);

ShoppingCart shoppingCart1 = new ShoppingCart(factory1);
Console.WriteLine("Shopping Cart 1");
shoppingCart1.PasserCommande();

ShoppingCart shoppingCart2 = new ShoppingCart(factory2);
Console.WriteLine("Shopping Cart 2");
shoppingCart2.PasserCommande();

IVIPShoppingFactory GetFactory(Customer customer)
{
    if (customer.Orders.Length > 20) return new VIPShoppingFactory();
    return new StandardShoppingFactory();
}
