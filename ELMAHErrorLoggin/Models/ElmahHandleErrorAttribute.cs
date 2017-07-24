using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELMAHErrorLoggin.Models
{
    /// <summary>
    /// Create a class inherited by System.Web.Mvc.HandleErrorAttribute.
    /// </summary>
    public class ElmahHandleErrorAttribute : HandleErrorAttribute
    {
        /// <summary>
        /// Overriding OnException method to log error occurring in MVC application
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
            var e = context.Exception;
            var httpcontext = HttpContext.Current;

            var signal = ErrorSignal.FromContext(httpcontext);
            if (signal != null)
            {
                signal.Raise(e, httpcontext);
            }
        }
    }
}