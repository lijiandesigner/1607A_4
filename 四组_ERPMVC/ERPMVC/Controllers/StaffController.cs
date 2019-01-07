using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ERPMVC.Models;

namespace ERPMVC.Controllers
{
    public class StaffController : Controller
    {
        int id = 3;
        // GET: Staff
        public ActionResult Index()
        {
            id = 3;   // 假设登陆人Id
            string str = HttpClientHelper.Send("get","api/CheckApi/",null);
            List<CheckViewModel> list = JsonConvert.DeserializeObject<List<CheckViewModel>>(str);
            ViewBag.KQ = from a in list.AsEnumerable()
                         where a.StaffId==id
                         select a;  // 该员工考勤的表显示
            ViewBag.KQlast =Math.Ceiling(list.Count *1.0/ 5);

            string str1 = HttpClientHelper.Send("get", "/api/StaffApi?pageindex=0&pagesize=1", null);
            List<StaffViewModel> list1 = JsonConvert.DeserializeObject<List<StaffViewModel>>(str1);
            StaffViewModel aa= (from a in list1.AsEnumerable()
                          where a.StaffId == id
                          select new StaffViewModel
                          {
                              HandImg = a.HandImg,
                              StaffName=a.StaffName
                          }).FirstOrDefault();
            ViewBag.img = aa.HandImg;
            ViewBag.name = aa.StaffName;    // 头像显示

            string str2 = HttpClientHelper.Send("get","/api/LeaveApi",null);
            List<LeaveViewModel> list2 = JsonConvert.DeserializeObject<List<LeaveViewModel>>(str2);
            ViewBag.qj = from a in list2.AsEnumerable()
                         where a.StaffId == id
                         select a;   // 该员工的请假信息表
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            string str = HttpClientHelper.Send("get", "api/DepartmentApi", null);
            List<DepartmentViewModel> list = JsonConvert.DeserializeObject<List<DepartmentViewModel>>(str);
            ViewBag.dep = from d in list.AsEnumerable()
                          select new SelectListItem
                          {
                              Text = d.DepartmentName,
                              Value = d.DepartmentId.ToString()
                          };
            ViewBag.a = new List<SelectListItem>();
            return View();
        }

        [HttpPost]
        public ActionResult Add(StaffViewModel m,HttpPostedFileBase file)
        {
            string jue = Server.MapPath("/Image/");
            string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
            file.SaveAs(jue + filename);

            m.HandImg = "/Image/" + filename;

            m.StaffPassword = m.Identitycard.Substring(10, 8);
            m.StaffEntryDate = DateTime.Now.Date;

            string str = JsonConvert.SerializeObject(m);

            string result = HttpClientHelper.Send("post","api/StaffApi",str);

            return View();
        }

        public ActionResult Wan(int pid)
        {
            string str= HttpClientHelper.Send("get", "api/RoleApi", null);
            List<RoleViewModel> list = JsonConvert.DeserializeObject<List<RoleViewModel>>(str);
            ViewBag.role = from r in list.AsEnumerable()
                           where r.DepartmentId==pid
                           select new SelectListItem
                           {
                               Text = r.RoleName,
                               Value = r.RoleId.ToString()
                           };
            return PartialView("Role");
        }

        public ActionResult QJ(string start,string end,string rem)
        {
            LeaveViewModel l = new LeaveViewModel();
            l.StartTime =Convert.ToDateTime(start);
            l.EndTime = Convert.ToDateTime(end);
            l.LeaveState = "待审核";
            l.LeaveCause = rem;
            l.StaffId = id;
            string json = JsonConvert.SerializeObject(l);
            string str = HttpClientHelper.Send("post", "api/LeaveApi", json);
            if (str == "1")
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }
        }






















        public ActionResult fenye1(int pageindex)
        {
            ViewBag.page = pageindex;
            string str = HttpClientHelper.Send("get", "api/CheckApi/", null);
            List<CheckViewModel> list = JsonConvert.DeserializeObject<List<CheckViewModel>>(str);
            list = list.Skip((pageindex - 1) * 4).Take(4).ToList();
            return PartialView("FenYeKQ", list);
        }

        public ActionResult fenye2(int pageindex)
        {
            ViewBag.page1 = pageindex;
            string str2 = HttpClientHelper.Send("get", "/api/LeaveApi", null);
            List<LeaveViewModel> list2 = JsonConvert.DeserializeObject<List<LeaveViewModel>>(str2);
            list2 = list2.Skip((pageindex - 1) * 1).Take(1).ToList();
            return PartialView("FenYeQJ", list2);
        }
    }
}