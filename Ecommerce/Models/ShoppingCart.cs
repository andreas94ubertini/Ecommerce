using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public static class ShoppingCart
    {
        public static List<Product> Cart= new List<Product>();

        public static void addToCart(Product toAdd)
        {
          
            Cart.Add(toAdd);
        }
        public static void removeCart()
        {
            Cart.Clear();
        }
        public static void removeOne(int index) {
            
            Cart.RemoveAt(GetId(index));
        }
        private static int GetId(int Id)
        {
            int toDelete = 0;
            for (int i = 0; i < Cart.Count; i++)
            {
                
                if (Cart[i].CartIndex == Id)
                {
                    toDelete = i;
                    
                }
            }
            return toDelete;
        }

        public static double GetTotal()
        {
            double total = 0;
            foreach (Product product in Cart)
            {
                total += product.Price;
            }
            return total;
        }

    }
}