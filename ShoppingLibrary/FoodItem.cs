using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class FoodItem : ShoppingCartItem
    {
        public FoodItem(string itemName, decimal priceTag) : base(itemName, priceTag)
        {

        }

        public override string Items()
        {
            //return base.Items();
            return _itemName;
        }

        public override decimal Price()
        {
            //return base.Items();
            return _priceTag;
        }
    }
}
