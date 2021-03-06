﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_MODEL;
using ERP_BLL;

namespace ERP_Api.Controllers
{
    public class StaffApiController : ApiController
    {
        StaffBll bll = new StaffBll();
        [HttpPost]
        public int AddStaff(StaffModel Sta)
        {
            return bll.AddStaff(Sta);

        }
        //显示
        [HttpGet]
        public List<StaffModel> ShowStaff(int pageindex,int pagesize)
        {
            return bll.ShowStaff(pageindex,pagesize);
        }

        [HttpGet]
        public List<StaffModel> Quan()
        {
            return bll.Quan();
        }

        //删除
        [HttpDelete]
        public int DelStaff(int id)
        {
            return bll.DelStaff(id);

        }
        //根据Id查询做一个反填效果
        [HttpGet]
        public StaffModel GetShow(int id)
        {

            return bll.GetShow(id);
        }
        //修改
        [HttpPut]
        public int UpdStaff(StaffModel Sta)
        {

            return bll.UpdStaff(Sta);
        }
        [HttpGet]
        public int Login(string username, string password)
        {
            int result = bll.Login(username, password);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        [HttpGet]
        public List<StaffModel> TShowStaff(string Name, string JobNumber)
        {
            return bll.TShowStaff(Name, JobNumber);
        }
        [HttpGet]
        public StaffModel JudgeSraff([FromUri]string JobNumber, string StaffPassword)
        {
            return bll.JudgeSraff(JobNumber,StaffPassword);
        }
    }
}
