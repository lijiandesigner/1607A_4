using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_DAL;
using ERP_MODEL;

namespace ERP_BLL
{
    public class LeaveBll
    {
        LeaveDal dal = new LeaveDal();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        public int AddLeave(LeaveModel lea)
        {
            return dal.AddLeave(lea);
        }
        //请假信息显示
        public List<LeaveModel> ShowLeave()
        {
            return dal.ShowLeave();
        }
        //请假删除
        public int DelLeave(int id)
        {
            return dal.DelLeave(id);
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LeaveModel GetShow(int id)
        {
            return dal.GetShow(id);

        }
        //请假修改
        public int UpdLeave(LeaveModel lea)
        {
            return dal.UpdLeave(lea);

        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="name">姓名</param>
        /// <returns></returns>
        public List<LeaveModel> TShowLeave(DateTime StartDate, DateTime EndDate, string name = "")
        {
            return dal.TShowLeave(StartDate, EndDate, name);
        }

    }
}
