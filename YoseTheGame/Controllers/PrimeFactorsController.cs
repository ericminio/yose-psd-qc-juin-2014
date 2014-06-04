using System.Web.Mvc;
using YoseTheGame.PrimeFactors;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        public ActionResult Index(string number)
        {
            return Json(new PrimeFactorsRouter().Response(number), JsonRequestBehavior.AllowGet);            
        }
    }
}