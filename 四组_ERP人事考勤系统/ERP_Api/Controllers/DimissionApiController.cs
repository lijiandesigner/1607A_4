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
    public class DimissionApiController : ApiController
    {
        Dimissionbll bll = new Dimissionbll();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddDim(DimissionModel dim)
        {
            return bll.AddDim(dim);
        }
        //请假信息显示
        [HttpGet]
        public List<DimissionModel> ShowDim()
        {
            return bll.ShowDim();
        }
        [HttpDelete]
        //请假删除
        public int DelDim(int id)
        {
            return bll.DelDim(id);
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public DimissionModel GetShow(int id)
        {
            return bll.GetShow(id);

        }
        //请假修改
        [HttpPut]
        public int UpdLeave(DimissionModel lea)
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
        public List<DimissionModel> TShowDim(DateTime StartDate, string Name)
        {
            return bll.TShowDim(StartDate, Name);
        }
    }
}
