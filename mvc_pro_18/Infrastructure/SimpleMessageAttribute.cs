using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace mvc_pro_18.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple =true)]
    public class SimpleMessageAttribute : FilterAttribute, IActionFilter
    {
        public string Message { get; set; }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format("<div>[after action:{0}]</div>", Message)
                );
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
         string.Format("<div>[before action:{0}]</div>", Message)
         );
        }
    }
}