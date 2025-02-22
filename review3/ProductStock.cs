using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review3
{
    internal class ProductStock
    {

        // Product Availability
        //Write a program for an e-commerce application where:
        //      If the product stock is 0, throw a ProductOutOfStockException.

        public int stocks;
         public ProductStock(int stock) { 
            stocks = stock;  
          }

        public void GetStockProduct(int product)
        {
            if (stocks == 0) {

                throw new ProductOutOfStockException("Product out of stock ");
                
            }

            Console.WriteLine(product + "available product");
        }


    }
}
