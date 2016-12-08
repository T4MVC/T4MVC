using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvc5App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters )
        {
            filters.Add( new HandleErrorAttribute() );
        }
    }
}
