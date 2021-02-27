using System.Linq;

namespace ElectricShopWebApp.Models
{
    public class OrderModel : ElectricShopWebApp.Order
    {

        public decimal TotalPayment
        {
            get
            {
                return this.Order_Products.Sum(p => p.TotalSale);
            }
        }
    }
}