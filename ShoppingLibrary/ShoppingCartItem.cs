using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        protected string _itemName;
        protected decimal _priceTag;

        public ShoppingCartItem(string itemName, decimal priceTag)
        {
            _itemName = itemName;
            _priceTag = priceTag;
        }

        public virtual string Items()
        {
            return _itemName;
        }

        public virtual decimal Price()
        {
            return _priceTag;
        }

    }
}
