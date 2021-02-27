using System.Collections.Generic;
using System.Linq;

namespace ElectricShopWebApp
{
    public partial class Product
    {
        private ElectricShopEntities _ctx = new ElectricShopEntities();
        public List<Product> All
        {
            get
            {
                return _ctx.Products.ToList<Product>();

            }
        }
    }
}