using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// GET: /HelloWorld/
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: /HellowWorld/Welcome
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = $"Hello {name}";
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}