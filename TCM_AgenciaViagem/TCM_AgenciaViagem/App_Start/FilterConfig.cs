using System.Web;
using System.Web.Mvc;

namespace TCM_AgenciaViagem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
