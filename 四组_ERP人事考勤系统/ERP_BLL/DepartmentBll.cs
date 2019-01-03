using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using ERP_DAL;

namespace ERP_BLL
{
    public class DepartmentBll
    {
        DepartmentDal daldePart = new DepartmentDal();
        public int AddDepart(DepartmentModel department)
        {
            return daldePart.AddDepart(department);
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <returns></returns>
        public int DelDepart(int Departid)
        {
            return daldePart.DelDepart(Departid);
        }
        /// <summary>
        /// 反填部门
        /// </summary>
        /// <returns></returns>
        public DepartmentModel FanTian(int departid)
        {
            return daldePart.FanTian(departid);
        }
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="Roleid"></param>
        /// <returns></returns>
        public int UpdRole(DepartmentModel department)
        {
            return daldePart.UpdRole(department);
        }
        /// <summary>
        /// 显示部门
        /// </summary>
        /// <returns></returns>
        public List<DepartmentModel> ShowRole()
        {
            return daldePart.ShowRole();
        }
    }
}
