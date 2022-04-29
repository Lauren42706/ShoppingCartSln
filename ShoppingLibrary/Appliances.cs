using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class Appliances : ShoppingCartItem
    {
        public Appliances(string itemName, decimal priceTag) : base(itemName, priceTag)
        {

        }

        public override string Items()
        {
            return _itemName;
        }

        public override decimal Price()
        {
            return _priceTag;
        }
    }
}
