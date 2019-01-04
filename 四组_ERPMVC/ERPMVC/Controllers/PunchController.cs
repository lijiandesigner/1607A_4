using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using ERPMVC.Models;
using Newtonsoft.Json;
namespace ERPMvc.Controllers
{
    public class PunchController : Controller
    {
        // GET: Judge
        [HttpGet]
        public ActionResult Punch()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Punch(string JobNumber,string StaffPassword, CheckViewModel Eck)
        {
            Uri uri = new Uri("http://localhost:56425/");
            HttpClient client = new HttpClient();
            client.BaseAddress = uri;//赋值API地址
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//转换成json字符串格式
            HttpResponseMessage response = client.GetAsync("/api/StaffApi?JobNumber=" +JobNumber + "&StaffPassword=" +StaffPassword).Result;//判断用户名与密码
            StaffViewModel list = JsonConvert.DeserializeObject<StaffViewModel>(response.Content.ReadAsStringAsync().Result);
            if (list != null)
            {
                Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");
                Eck.StaffId = list.StaffId;
                var Time = DateTime.Now.Hour;
                if (Time >= 8 && Time <= 9)
                {
                    Eck.MorningHours = DateTime.Now;
                    Eck.StaffState = "早上打卡成功";
                }
                else if (Time > 9 && Time <= 12)
                {
                    Eck.MorningHours = DateTime.Now;
                    Eck.StaffState = "早上迟到";
                }
                else if (Time > 12 && Time <= 14)
                {
                    Eck.MorningHours = DateTime.Now;
                    Eck.StaffState = "下午打卡成功";

                }
                else if (Time > 14 && Time <= 18)
                {
                    Eck.MorningHours = DateTime.Now;
                    Eck.StaffState = "下午迟到";
                }



            }
            else
            {

                Response.Write("<script>alert('对不起,您的工号或密码输入错误');</script>");

            }
            return View();
        }
    }
}