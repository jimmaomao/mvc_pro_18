using mvc_pro_18.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_pro_18.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [Authorize(Users = "admin")]
        //[CustomAuth(true)]
        public string Index()
        {
            return "hello world";
        }

        [GoogleAuth]
        public string List()
        {
            return "this is list";

        }
    }
}