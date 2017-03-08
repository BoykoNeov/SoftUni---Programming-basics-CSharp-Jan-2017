using System.Web;
using System.Web.Mvc;

namespace web_app_1_from_the_first_lesson
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
