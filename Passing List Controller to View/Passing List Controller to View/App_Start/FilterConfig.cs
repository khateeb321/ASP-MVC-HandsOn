using System.Web;
using System.Web.Mvc;

namespace Passing_List_Controller_to_View
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}