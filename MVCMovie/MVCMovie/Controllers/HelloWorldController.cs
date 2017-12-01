using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// Get: /HelloWorld
        /// </summary>
        /// <returns></returns>
        public String Index()
        {
            return "This is my <b>default</b> action ...";
        }

        /// <summary>
        /// Get: /HelloWorld/Welcome
        /// </summary>
        /// <returns></returns>
        public string Welcome()
        {
            return "This is the welcome action method ...";
        }
    }
}