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
    public class MoneyApiController : ApiController
    {
        MoneyBll bll = new MoneyBll();
        [HttpPost]
        public int Add(MoneyModel money)
        {
            int result = bll.Add(money);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        [HttpDelete]
        public int Delete(int Id)
        {
            int result = bll.Delete(Id);
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
        public List<MoneyModel> money()
        {
            return bll.money();
        }
        [HttpGet]
        public MoneyModel Fan(int Id)
        {
            return Fan(Id);
        }
        [HttpPut]
        public int Update(MoneyModel money)
        {
            int result = bll.Update(money);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 根据时间和姓名查询
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet]
        public List<MoneyModel> TShowMoney(string Name, DateTime date)
        {
            return bll.TShowMoney(Name, date);
        }
    }
}
