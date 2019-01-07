using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ERPMVC.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ERPMVC.Controllers
{
    public class StaffController : Controller
    {
        public ActionResult Index()
        {
            int id = 3;
            string str = HttpClientHelper.Send("get","api/CheckApi/",null);
            List<CheckViewModel> list = JsonConvert.DeserializeObject<List<CheckViewModel>>(str);
            ViewBag.a = list;
            string str1 = HttpClientHelper.Send("get", "/api/StaffApi", null);
            List<StaffViewModel> list1 = JsonConvert.DeserializeObject<List<StaffViewModel>>(str1);
            StaffViewModel aa= (from a in list1.AsEnumerable()
                          where a.StaffId == id
                          select new StaffViewModel
                          {
                              HandImg = a.HandImg,
                              StaffName=a.StaffName
                          }).FirstOrDefault();
            ViewBag.img = aa.HandImg;
            ViewBag.name = aa.StaffName;

            string str2 = HttpClientHelper.Send("get","/api/LeaveApi",null);
            List<LeaveViewModel> list2 = JsonConvert.DeserializeObject<List<LeaveViewModel>>(str2);
            ViewBag.qj = from a in list2.AsEnumerable()
                         where a.StaffId == id
                         select a;
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
        [HttpGet]
        public ActionResult StaffUpd(int id)
        {
            Uri uri = new Uri("http://localhost:56425/");
            HttpClient client = new HttpClient();
            client.BaseAddress = uri;//赋值API地址
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//转换成json字符串格式
            HttpResponseMessage response = client.GetAsync("/api/StaffApi/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string jie = response.Content.ReadAsStringAsync().Result;
                var list = JsonConvert.DeserializeObject<StaffViewModel>(jie);
                return View(list);
            }
            else
            {
                return View();
            }
           
        }
        public ActionResult StaffUpd(StaffViewModel Staff)
        {
            return View();
        }
    }
}