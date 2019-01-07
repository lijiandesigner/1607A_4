using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERPMVC.Models;
using Newtonsoft.Json;

namespace ERPMVC.Controllers
{
    public class DepBossController : Controller
    {
        // GET: DepBoss
        public ActionResult Index(int pageindex=1)
        {
            ViewBag.page = pageindex;
            string str = HttpClientHelper.Send("get", "/api/StaffApi?pageindex="+pageindex+"&pagesize=3", null);
            List<StaffViewModel> list = JsonConvert.DeserializeObject<List<StaffViewModel>>(str);
            string str1 = HttpClientHelper.Send("get", "/api/StaffApi", null);
            List<StaffViewModel> list1 = JsonConvert.DeserializeObject<List<StaffViewModel>>(str1);
            ViewBag.count =Math.Ceiling(list1.Count*1.0/3);
            return View(list);
        }

        public ActionResult Zhu()
        {
            return View();
        }
    }
}