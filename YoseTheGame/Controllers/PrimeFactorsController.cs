using System;
using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        public ActionResult Index(string number)
        {
            int value = Convert.ToInt32(number);
            var decomposition = Genius.Decompose(value);
            return Json(new DecompositionResponse
            {
                number = value, 
                decomposition = decomposition
            }, JsonRequestBehavior.AllowGet);
        }

        public Genius Genius = new Mathematician();
    }
}