using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_MODEL;
using ERP_BLL;

namespace ERP_Api.Controllers
{
    public class CheckApiController : ApiController
    {
        CheckBll bll = new CheckBll();
        //增加
        [HttpPost]
        public int Add(CheckModel check)
        {
            return bll.Add(check);
        }
        //删除
        [HttpDelete]
        public int Del(int Id)
        {
            return bll.Del(Id);
        }
        //修改
        [HttpPut]
        public int Upd(CheckModel check)
        {
            return bll.Upd(check);
        }
        //查询
        [HttpGet]
        public List<CheckModel> Show()
        {
            return bll.Show();
        }
        //反填
        [HttpGet]
        public CheckModel Fan(int id)
        {
            return bll.Fan(id);
        }
        // 条件查询
        //[HttpGet]
        //public List<CheckModel> TShowCheck(string Name,DateTime date)
        //{
        //    return bll.TShowCheck(Name, date);
        //}
        [HttpGet]
        public CheckModel PunchShow(int id, DateTime time)
        {
            return bll.PunchShow(id, time);
        }
    }
}
