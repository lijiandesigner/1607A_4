using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERPMVC.Models;
using Newtonsoft.Json;

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
            var LeaveResult = HttpClientHelper.Send("get","api/LeaveApi",null);
            List<LeaveViewModel> list = JsonConvert.DeserializeObject<List<LeaveViewModel>>(LeaveResult);
            ViewBag.Leave = list.Where(a=>a.LeaveState=="待审核");
            ViewBag.Leavecount = list.Where(a => a.LeaveState == "待审核").Count();
            return View();
        }
    }
}