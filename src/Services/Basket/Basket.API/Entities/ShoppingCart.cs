using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (ShoppingCartItem item in Items)
                {
                    totalPrice += item.Quantity * item.Price;
                }

                return totalPrice;
            }
        }

        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

    }
}
