using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class ShoppingCart
    {
        private Product[] products;
        private int pointer = 0;

        public ShoppingCart()
        {
            products = new Product[pointer];
        }

        public decimal TotalPrice
        {
            get 
            {
                decimal overallPrice = 0;
                foreach (var product in products)
                {
                    overallPrice += product.Price;
                }
                return overallPrice;
            }
        }

        public void AddProduct(Product thing)
        {
            Product[] newProductList = new Product[++pointer];
            for (int i = 0; i < products.Length; i++)
            {
                if(products[i] != null)
                    newProductList[i] = products[i];
            }

            newProductList[newProductList.Length-1] = thing;
            products = newProductList;

            string logMessage = $"{thing.Name} was added to the shopping cart.";
            Logger.Instance.LogInfo(LogType.Info, logMessage); 
        }

        /// <summary>
        /// Return all products names and prices from the shopping cart.
        /// </summary>
        /// <returns></returns>
        public string ProductList()
        {
            string buf = "";
            foreach (Product product in products) 
            {                
                buf += $"Name: {product.Name}\tPrice: {product.Price}\n";
            }
            return buf;
        }
        
        /// <summary>
        /// Delete all elements of the shopping cart after making a purchase.
        /// </summary>
        public void Clear()
        {
            pointer = 0;
            products = new Product[pointer];
        }
    }
}
