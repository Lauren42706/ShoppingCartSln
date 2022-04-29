using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
           
        }

        public void AddShoppingCartItem(ShoppingCartItem item)
        {
            _items.Add(item);
        }

        public List<ShoppingCartItem> CartItems()
        {
            return _items;
        }

        public decimal GetSubTotal()
        {
            decimal total = 0;

            foreach(ShoppingCartItem item in _items)
            {
                total += item.Price() ;
            }
            return (decimal)total;
        }

        public decimal GetVAT()
        {
            decimal vatAmount = 0.15m;

            decimal vat = GetSubTotal() * vatAmount + GetSubTotal();
            return vat;
        }
    }
}
