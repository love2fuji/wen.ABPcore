using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using wen.ABPcore.Controllers;

namespace wen.ABPcore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ABPcoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
