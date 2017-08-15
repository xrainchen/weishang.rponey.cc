using System.Web.Mvc;

namespace weishang.rponey.cc.Areas.Saller.Controllers
{
    /// <summary>
    /// 平台用户后台首页
    /// </summary>
    public class MainController : BaseController
    {
        // GET: Saller/Main
        public ActionResult Index()
        {
            return View();
        }
    }
}