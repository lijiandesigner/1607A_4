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
        public ActionResult Index()
        {
            string str = HttpClientHelper.Send("get","/api/StaffApi",null);
            List<StaffViewModel> list = JsonConvert.DeserializeObject<List<StaffViewModel>>(str);
            return View(list);
        }

        public ActionResult Zhu()
        {
            return View();
        }
    }
}