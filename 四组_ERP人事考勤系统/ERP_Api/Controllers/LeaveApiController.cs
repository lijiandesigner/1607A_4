using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_BLL;
using ERP_MODEL;

namespace ERP_Api.Controllers
{
    public class LeaveApiController : ApiController
    {
        LeaveBll bll = new LeaveBll();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddLeave(LeaveModel lea)
        {
            return bll.AddLeave(lea);
        }
        //请假信息显示
        [HttpGet]
        public List<LeaveModel> ShowLeave()
        {
            return bll.ShowLeave();
        }
        [HttpDelete]
        //请假删除
        public int DelLeave(int id)
        {
            return bll.DelLeave(id);
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public LeaveModel GetShow(int id)
        {
            return bll.GetShow(id);

        }
        //请假修改
        [HttpPut]
        public int UpdLeave(LeaveModel lea)
        {
            return bll.UpdLeave(lea);

        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpGet]
        public List<LeaveModel> TShowLeave(DateTime StartDate,DateTime EndDate,string Name)
        {
            return bll.TShowLeave(StartDate,EndDate,Name);
        }
    }
}
