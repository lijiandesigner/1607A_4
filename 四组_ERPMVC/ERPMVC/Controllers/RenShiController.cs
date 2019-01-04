using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERPMVC.Controllers
{
    public class RenShiController : Controller
    {
        // GET: RS
        public ActionResult EntryIndex()
        {
            return View();
        }

        public ActionResult dimissionIndex()
        {
            return View();
        }

        public ActionResult LeaveIndex()
        {
            return View();
        }
    }
}