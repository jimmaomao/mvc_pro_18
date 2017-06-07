using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_pro_18.Infrastructure;
namespace mvc_pro_18.Controllers
{
    public class CustomerController : Controller
    {
        [SimpleMessage(Message ="A",Order =2)]
        [SimpleMessage(Message = "B",Order =1)]
        // GET: Customer
        public string Index()
        {
            return "This is the customer controller";
        }
    }
}