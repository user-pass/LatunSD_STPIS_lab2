using System.Collections.Generic;

namespace ElectricShopWebApp
{
    public partial class Supplier
    {
        private ElectricShopEntities _ctx = new ElectricShopEntities();

        public IEnumerable<Supplier> All
        {
            get
            {
                return _ctx.Suppliers;
            }
        }
    }
}