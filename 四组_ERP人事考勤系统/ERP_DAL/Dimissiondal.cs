using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using System.Data.Entity;

namespace ERP_DAL
{
    public class Dimissiondal
    {
        DBContent content = new DBContent();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        public int AddDim(DimissionModel dim)
        {
            content.dimission.Add(dim);
            return content.SaveChanges();
        }
        //请假信息显示
        public List<DimissionModel> ShowDim()
        {
            List<DimissionModel> q = content.dimission.ToList();
            return q;
        }
        //请假删除
        public int DelDim(int id)
        {
            var jie = content.dimission.Where(s => s.DimId == id).FirstOrDefault();
            content.Entry(jie).State = EntityState.Deleted;
            return content.SaveChanges();
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DimissionModel GetShow(int id)
        {
            return content.dimission.Where(s => s.DimId == id).FirstOrDefault();

        }
        //请假修改
        public int UpdLeave(DimissionModel lea)
        {
            content.Entry(lea).State = EntityState.Modified;
            return content.SaveChanges();

        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<DimissionModel> TShowDim(DateTime StartDate, string name = "")
        {
            return content.dimission.Where(m => m.staffs.StaffName == name || m.StartTime == StartDate ).ToList();
        }
    }
}
