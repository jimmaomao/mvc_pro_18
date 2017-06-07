using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_pro_18.Infrastructure
{
    public class ProfileResultAttribute : FilterAttribute, IResultFilter
    {
        private Stopwatch timer;
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write
                (
                string.Format("<div>Result elapsed time : {0:F6}</div>", timer.Elapsed.Milliseconds)
                );
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            timer = new Stopwatch();
        }
    }
}