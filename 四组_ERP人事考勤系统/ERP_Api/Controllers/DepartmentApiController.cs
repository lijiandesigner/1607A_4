using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ERP_BLL;
using ERP_MODEL;
using System.Web.Http;

namespace ERP_Api.Controllers
{
    public class DepartmentApiController : ApiController
    {

        DepartmentBll blldePart = new DepartmentBll();
        [HttpPost]
        public int AddDepart(DepartmentModel department)
        {
            return blldePart.AddDepart(department);
        }

        [HttpDelete]
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <returns></returns>
        public int DelDepart(int Departid)
        {
            return blldePart.DelDepart(Departid);
        }


        [HttpPut]
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(DepartmentModel department)
        {
            return blldePart.UpdRole(department);
        }

        [HttpGet]
        /// <summary>
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        public List<DepartmentModel> ShowRole()
        {
            return blldePart.ShowRole();
        }
    }
}
