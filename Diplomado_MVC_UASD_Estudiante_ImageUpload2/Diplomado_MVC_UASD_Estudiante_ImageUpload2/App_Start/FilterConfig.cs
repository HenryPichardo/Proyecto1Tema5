using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_UASD_Estudiante_ImageUpload2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
