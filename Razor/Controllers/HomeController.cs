using Razor.Models;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductId = 1,
            Name = "Kayak",
            Description = "A boat for one person";
            Category = "Watersports',
            Price = 275M
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}