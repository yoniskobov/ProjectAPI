using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectZaemMVC.Controllers
{
    public class ConverterController : Controller
    {
        public ActionResult Index()
        {
            Zaemdll.Zaem.Calculate(123m, 1m, 32m);
            return View();
        }

        [HttpPost]
        public ActionResult Calculate()
        {

            try
            {
                decimal amount = decimal.Parse(Request["value1"]);
                decimal deadline = decimal.Parse(Request["value2"]);
                decimal interest = decimal.Parse(Request["value3"]);
                var values = Zaemdll.Zaem.Calculate(amount, deadline, interest);
                ViewBag.values = values;
                return View();
            }
            catch (FormatException ex)
            {
                ViewBag.error = "Грешно въведени стойности";
                return View();
            }


        }
    }
}