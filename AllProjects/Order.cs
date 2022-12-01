using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public delegate double BonusProvider(double amount);
    public class Order
    {
        private List<Product> products = new List<Product>();
        public BonusProvider Bonus;

        public Order() { }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double total = 0;
            foreach(Product p in products) {
                total += p.Value;
            }
            return total;
        }
        public double GetBonus()
        {
            if (Bonus != null) { return Bonus(GetValueOfProducts()); }
            else { return 0.0; }
        }
        public double GetTotalPrice()
        {
            return(GetValueOfProducts()-GetBonus());
        }
    }
}
