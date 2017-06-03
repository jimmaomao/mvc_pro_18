using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvc_pro_18.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public void Index()
        {
            //return View();
           // FormsAuthentication.RedirectToLoginPage();
        }


    }
}