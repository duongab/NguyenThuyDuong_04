using System.Web;
using System.Web.Mvc;

namespace NguyenThuyDuong_1721050422_LTQL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
