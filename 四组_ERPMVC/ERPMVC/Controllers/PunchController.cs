using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using ERPMVC;
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
            string str = HttpClientHelper.Send("get", "/api/CheckApi?id=" + list.StaffId + "&time=" + DateTime.Now.Date, null);

            if (list != null)
            {
               
                Eck.StaffId = list.StaffId;

                var Time = DateTime.Now.Hour;
                if (Time >= 8 && Time <= 9)
                {
                 
                    if (str == "null")
                    {
                        Eck.MorningHours = DateTime.Now;
                        Eck.AfternoonHours = Convert.ToDateTime("9999/01/01 00:00:00");
                        Eck.StaffState = "早上打卡正常";
                        AddCheck(Eck);
                        Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");
                    }
                    else
                    {
                        Response.Write($"<script>alert('您上午已经打过卡了');</script>");
                    }
                   
                }
                else if (Time > 9 && Time <= 12)
                {
                    if (str == "null")
                    {
                        Eck.MorningHours = DateTime.Now;
                        Eck.StaffState = "早上迟到";
                        Eck.AfternoonHours = Convert.ToDateTime("9999/01/01 00:00:00");
                        AddCheck(Eck);
                        Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");
                    }
                    else
                    {
                        Response.Write($"<script>alert('您上午已经打过卡了');</script>");
                    }
                   
                }
                else if (Time > 12 && Time <= 17)
                {
                   

                    if (str=="null")
                    {
                        Eck.MorningHours = Convert.ToDateTime("9999/01/01 00:00:00");
                        Eck.AfternoonHours = DateTime.Now;
                        Eck.StaffState = "上午旷工,下午早退";
                        AddCheck(Eck);
                        Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");
                    }
                    else
                    {
                        Response.Write($"<script>alert('您下午打过卡了');</script>");
                    }
                       
                }
                else if (Time > 20 && Time <= 22)
                { 
                    if (str == "null")
                    {
                        
                        Eck.MorningHours = Convert.ToDateTime("9999/01/01 00:00:00");
                        Eck.AfternoonHours = DateTime.Now;
                        Eck.StaffState = "上午旷工";
                        AddCheck(Eck);
                        Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");
                    }
                    else
                    {

                        CheckViewModel check = JsonConvert.DeserializeObject<CheckViewModel>(str);
                        check.AfternoonHours = DateTime.Now;
                        string str1 = JsonConvert.SerializeObject(check);
                        string reulst = HttpClientHelper.Send("put", "/api/CheckApi", str1);
                        Response.Write($"<script>alert('恭喜员工{list.StaffName}打卡成功');</script>");

                    }
                   
                }
            }
            else
            {

                Response.Write("<script>alert('对不起,您的工号或密码输入错误');</script>");

            }
            return View();
        }
        private static void AddCheck(CheckViewModel Eck)
        {
            string str = JsonConvert.SerializeObject(Eck);
            string reulst = HttpClientHelper.Send("post", "/api/CheckApi/", str);
        }
    }
}