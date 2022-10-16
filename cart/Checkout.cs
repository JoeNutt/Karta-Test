using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cart.interfaces;

namespace cart
{
    public class Checkout 
    {
    
        private double _total;
        private List<Product> _basket;

        public Checkout() {
            _total = 0;
            _basket = new List<Product>();
        }

        public void Scan(Product product) {
            _basket.Add(product);
            _total += product.price; // Add the price of the product to the total
        }

        public double GetTotal() {
            return CalculateDiscount();
        }

        private double CalculateDiscount() {
            var returnValue = _total; // Set the return value to the total

            var appleDiscount = new Discount() {
                name = "A99",
                quantity = 3,
                discount = 1.30
            };

            returnValue -= appleDiscount.getDiscount(_basket);

            var biscutDiscount = new Discount {
                name = "B15",
                quantity = 2,
                discount = 0.45
            };

            returnValue -= biscutDiscount.getDiscount(_basket);

            return returnValue;
        }

    }
}
 
