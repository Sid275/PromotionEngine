using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class PromotionEngine
    {
        static void Main(string[] args)
        {
        }

        public int GetTotalUnitsPrice()
        {
            List<Product> products = new List<Product>();

            List<string> lstString = new List<string>();
            lstString.Add("A");
            lstString.Add("B");
            lstString.Add("C");
            foreach (var item in lstString)
            {
                Product p = new Product(item);
                products.Add(p);
            }
            int totalPrice = GetTotalPrice(products);

            return totalPrice;
        }

        private static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
