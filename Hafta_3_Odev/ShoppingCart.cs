using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3_Odev
{
    internal class ShoppingCart
    {
        List<CartItem> cartItems = new List<CartItem>
        {
            new CartItem
            {
                CartId = 1,
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "iPhone",
                    Price = 14000
                },
                Quantity = 1
            },
            new CartItem
            {
                CartId = 2,
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Asus Laptop",
                    Price = 19500
                },
                Quantity = 2
            }
        };

        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public void Remove(int id)
        {
            var productById = cartItems.FirstOrDefault(e => e.CartId == id);
            if (productById != null)
            {
                cartItems.RemoveAt(id - 1);
            }
            else
            {
                Console.WriteLine("Bu ID'ye ait sepette ürün bulunamadı.");
            }
        }

        public void GetBalance()
        {
            int totalPrice = 0;
            for (int i = 0; i < cartItems.Count; i++)
            {
                totalPrice += cartItems[i].Quantity * this.cartItems[i].Product.Price;
            }

            Console.WriteLine("Sepetinizin toplam fiyatı: " + totalPrice);
        }

        public void GetList()
        {
            foreach (var cartItem in cartItems)
            {
                Console.WriteLine(cartItem.CartId + " - " + cartItem.Product.ProductName + " - Fiyatı: " + cartItem.Product.Price + " - Miktarı: " + cartItem.Quantity);
            }
        }
    }
}
