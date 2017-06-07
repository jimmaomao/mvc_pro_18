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

        //[RangeExceptionAttributes]
        [HandleError(ExceptionType =typeof(ArgumentOutOfRangeException),View ="RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is:{0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        //[CustomAction]
        [ProfileAction]
        [ProfileResult]
        [ProfileALL]
        public string FilterTest()
        {
            return "This is the FilterTest action";
        }

        //空白虚拟实现 无须注解
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}