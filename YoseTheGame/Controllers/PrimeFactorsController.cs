using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        private readonly HappyPath happyPath = new HappyPath();

        public ActionResult Index(string number)
        {
            return Json(happyPath.Response(number), JsonRequestBehavior.AllowGet);
        }               
    }
}