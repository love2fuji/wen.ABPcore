using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using wen.ABPcore.Controllers;

namespace wen.ABPcore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPcoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
