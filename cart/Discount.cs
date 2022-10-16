using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cart;

class Discount {
    public String name { get; set; }
    public double discount { get; set; }
    public int quantity { get; set; }

    public double getDiscount(List<Product> basket) {
        double discounts = Math.Floor((double)basket.Count(x => x.name == name) / quantity);
        return (discounts * discount);
    }
}