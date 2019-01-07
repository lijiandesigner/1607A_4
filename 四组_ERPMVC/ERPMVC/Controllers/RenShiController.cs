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

        //以下是审核离职
        public ActionResult dimissionIndex()
        {
            return View();
        }




        //以下是审核请假
        public ActionResult LeaveIndex()
        {
            var LeaveResult = HttpClientHelper.Send("get","api/LeaveApi",null);
            List<LeaveViewModel> list = JsonConvert.DeserializeObject<List<LeaveViewModel>>(LeaveResult);
            ViewBag.Leave = list.Where(a=>a.LeaveState== "未审核");
            ViewBag.Leavecount = list.Where(a => a.LeaveState == "未审核").Count();
            return View();
        }
        public ActionResult ShenResult()
        {
            var LeaveResult = HttpClientHelper.Send("get", "api/LeaveApi", null);
            List<LeaveViewModel> list = JsonConvert.DeserializeObject<List<LeaveViewModel>>(LeaveResult);
            ViewBag.Leave = list.Where(a => a.LeaveState != "未审核");
            ViewBag.Leavecount = list.Where(a => a.LeaveState == "未审核").Count();
            return View();
        }
        public ActionResult Pass(int Id,string State,DateTime  Stime, DateTime Etime, string Cause,int staffid)
        {
            var leaveResult = Shen(Id, State, Stime, Etime, Cause, staffid);
            if (Convert.ToInt32(leaveResult) > 0)
            {
                return Content("<script>alert('审核成功');location.href='/RenShi/LeaveIndex'</script>");
            }
            else
            {
                return Content("<script>alert('审核失败');location.href='/RenShi/LeaveIndex'</script>");
            }
        }

        private string Shen(int Id, string State, DateTime Stime, DateTime Etime, string Cause, int staffid)
        {
            LeaveViewModel leaveView = new LeaveViewModel();
            leaveView.LeaveId = Id;
            leaveView.LeaveState = State;
            leaveView.StartTime = Stime;
            leaveView.EndTime = Etime;
            leaveView.LeaveCause = Cause;
            leaveView.StaffId = staffid;
            string leaStr = JsonConvert.SerializeObject(leaveView);
            return HttpClientHelper.Send("put", $"api/LeaveApi", leaStr);
        }

        public ActionResult Reject(int Id, string State, DateTime Stime, DateTime Etime, string Cause, int staffid)
        {
            var leaveResult = Shen(Id,State,Stime,Etime,Cause,staffid);
            if (Convert.ToInt32(leaveResult) > 0)
            {
                return Content("<script>alert('审核成功');location.href='/RenShi/LeaveIndex'</script>");
            }
            else
            {
                return Content("<script>alert('审核失败');location.href='/RenShi/LeaveIndex'</script>");
            }
        }
    }
}