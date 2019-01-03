using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class DepartmentDal
    {
        DBContent content = new DBContent();
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <returns></returns>
        public int AddDepart(DepartmentModel department)
        {
            content.departments.Add(department);
            return content.SaveChanges();
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <returns></returns>
        public int DelDepart(int Departid)
        {
            var id = content.departments.Where(a => a.DepartmentId == Departid).FirstOrDefault();
            content.Entry(id).State = EntityState.Deleted;
            content.departments.Remove(id);
            return content.SaveChanges();
        }
        /// <summary>
        /// 反填部门
        /// </summary>
        /// <returns></returns>
        public DepartmentModel FanTian(int departid)
        {
            return content.departments.Where(a => a.DepartmentId == departid).FirstOrDefault();
        }
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(DepartmentModel department)
        {
            content.Entry(department).State = EntityState.Modified;
            return content.SaveChanges();
        }
        /// <summary>
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        public List<DepartmentModel> ShowRole()
        {
            return content.departments.ToList();
        }
    }
}
