using System.Web;
using System.Web.Mvc;

namespace WarriorCombatAcademyTrainer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
