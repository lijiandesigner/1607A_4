using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class RoleDal
    {
        DBContent content = new DBContent();
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public int AddRole(RoleModel role)
        {
            content.roles.Add(role);
            return content.SaveChanges();
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <returns></returns>
        public int DelRole(int Roleid)
        {
            var id = content.roles.Where(a => a.RoleId == Roleid).FirstOrDefault();
            content.Entry(id).State = EntityState.Deleted;
            content.roles.Remove(id);
            return content.SaveChanges();
        }
        /// <summary>
        /// 反填内容
        /// </summary>
        /// <returns></returns>
        public RoleModel FanTian(int Roleid)
        {
            return content.roles.Where(a => a.RoleId == Roleid).FirstOrDefault();
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(RoleModel role)
        {
            content.Entry(role).State = EntityState.Modified;
            return content.SaveChanges();
        }
        /// <summary>
        /// 显示角色
        /// </summary>
        /// <returns></returns>
        public List<RoleModel> ShowRole()
        {
            return content.roles.ToList();
        }
    }
}
