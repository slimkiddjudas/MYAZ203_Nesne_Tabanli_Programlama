using Hafta_3_Odev;

Product product = new Product
{
    ProductId = 3,
    ProductName = "JBL Kulaklık",
    Price = 1250
};
CartItem cartItem = new CartItem
{
    CartId = 3,
    Product = product,
    Quantity = 5
};
ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Add(cartItem);
shoppingCart.GetList();
shoppingCart.GetBalance();
Console.WriteLine("--------");
shoppingCart.Remove(3);
shoppingCart.GetList();
Console.WriteLine("--------");
shoppingCart.Remove(5);
shoppingCart.GetList();