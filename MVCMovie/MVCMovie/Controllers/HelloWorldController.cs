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
        public string Welcome(string name, int ID = 1)
        {
            // HttpUtility.HTMLEncode protects script exploits
            return HttpUtility.HtmlEncode($"Hello {name}, NumTimes is: {ID}");
        }
    }
}