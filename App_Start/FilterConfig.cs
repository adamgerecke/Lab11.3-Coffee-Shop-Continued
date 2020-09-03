using System.Web;
using System.Web.Mvc;

namespace Lab_11._3_Coffee_Shop_Registration_Continued
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
