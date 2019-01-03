using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_DAL;
using ERP_MODEL;

namespace ERP_BLL
{
    public class RoleBll
    {
        RoleDal dalRole = new RoleDal();
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public int AddRole(RoleModel role)
        {
            return dalRole.AddRole(role);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <returns></returns>
        public int DelRole(int Roleid)
        {
            return dalRole.DelRole(Roleid);
        }
        /// <summary>
        /// 反填内容
        /// </summary>
        /// <returns></returns>
        public RoleModel FanTian(int Roleid)
        {
            return dalRole.FanTian(Roleid);
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(RoleModel role)
        {
            return dalRole.UpdRole(role);
        }
        /// <summary>
        /// 显示角色
        /// </summary>
        /// <returns></returns>
        public List<RoleModel> ShowRole()
        {
            return dalRole.ShowRole();
        }
    }
}
