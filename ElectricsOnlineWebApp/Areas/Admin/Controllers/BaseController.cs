using System.Web.Mvc;

namespace ElectricShopWebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {
        protected ElectricShopEntities _ctx = new ElectricShopEntities();
    }
}