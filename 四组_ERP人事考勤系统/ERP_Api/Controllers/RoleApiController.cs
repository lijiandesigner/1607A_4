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
    public class RoleApiController : ApiController
    {
        RoleBll bllRole = new RoleBll();
        [HttpPost]
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public int AddRole(RoleModel role)
        {
            return bllRole.AddRole(role);
        }
        [HttpDelete]
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <returns></returns>
        public int DelRole(int Roleid)
        {
            return bllRole.DelRole(Roleid);
        }
[HttpPut]
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(RoleModel role)
        {
            return bllRole.UpdRole(role);
        }
        [HttpGet]
        /// <summary>
        /// 显示角色
        /// </summary>
        /// <returns></returns>
        public List<RoleModel> ShowRole()
        {
            return bllRole.ShowRole();
        }
    }
}
