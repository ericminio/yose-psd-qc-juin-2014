using System.Web.Mvc;
using System.Web.WebPages;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        private readonly HappyPath happyPath = new HappyPath();
        private readonly StringGuard stringGuard = new StringGuard();

        public ActionResult Index(string number)
        {
            if (number.IsInt())
            {
                return Json(happyPath.Response(number), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(stringGuard.Response(number), JsonRequestBehavior.AllowGet);
            }
        }
    }
}