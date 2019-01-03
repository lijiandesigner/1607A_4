using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class LeaveDal
    {
        DBContent content = new DBContent();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        public int AddLeave(LeaveModel lea)
        {
            content.leaves.Add(lea);
            return content.SaveChanges();
        }
        //请假信息显示
        public List<LeaveModel> ShowLeave()
        {
            return content.leaves.ToList();
        }
        //请假删除
        public int DelLeave(int id)
        {
            var jie = content.leaves.Where(s => s.LeaveId == id).FirstOrDefault();
            content.Entry(jie).State = EntityState.Deleted;
            return content.SaveChanges();
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LeaveModel GetShow(int id)
        {
            return content.leaves.Where(s => s.LeaveId == id).FirstOrDefault();

        }
        /// <summary>
        /// 请假修改
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        public int UpdLeave(LeaveModel lea)
        {
            content.Entry(lea).State = EntityState.Modified;
            return content.SaveChanges();

        }
        /// <summary>
        /// 根据条件查询 
        /// 员工姓名  请假开始时间  请假结束时间
        /// </summary>
        /// <returns></returns>
        public List<LeaveModel> TShowLeave(DateTime StartDate,DateTime EndDate, string name = "")
        {
            return content.leaves.Where(m => m.staffs.StaffName == name || m.StartTime == StartDate || m.EndTime == EndDate).ToList();
        }
    }
}
