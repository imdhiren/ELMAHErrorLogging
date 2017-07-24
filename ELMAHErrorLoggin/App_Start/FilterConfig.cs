using ELMAHErrorLoggin.Models;
using System.Web;
using System.Web.Mvc;

namespace ELMAHErrorLoggin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Below 1,2 is order to execute
            filters.Add(new ElmahHandleErrorAttribute(), 1);
            filters.Add(new HandleErrorAttribute(), 2);
        }
    }
}
