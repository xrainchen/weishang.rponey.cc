using System.Web.Mvc;

namespace admin.weishang.rponey.cc.Controllers
{
    public class ProductUserController : BaseController
    {
        // GET: ProductUser
        public ActionResult Manage()
        {
            return List();
        }

        ActionResult List()
        {
            return View("List");
        }
    }
}