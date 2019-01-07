using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using ERP_DAL;

namespace ERP_BLL
{
    public class StaffBll
    {
        StaffDal dal = new StaffDal();
        //添加
        public int AddStaff(StaffModel Sta)
        {
            return dal.AddStaff(Sta);

        }
        public List<StaffModel> Quan()
        {
            return dal.Quan();
        }
        //显示
        public List<StaffModel> ShowStaff(int pageindex, int pagesize)
        {
            return dal.ShowStaff(pageindex,pagesize);
        }
        //删除
        public int DelStaff(int id)
        {
            return dal.DelStaff(id);

        }
        //根据Id查询做一个反填效果
        public StaffModel GetShow(int id)
        {

            return dal.GetShow(id);
        }
        //修改
        public int UpdStaff(StaffModel Sta)
        {

            return dal.UpdStaff(Sta);
        }

        public List<StaffModel> TShowStaff(string Name, string JobNumber)
        {
            return dal.TShowStaff(Name, JobNumber);
        }
        public int Login(string username, string password)
        {
            return dal.Login(username, password);
        }
        public StaffModel JudgeSraff(string JobNumber, string StaffPassword)
        {
            return dal.JudgeSraff(JobNumber, StaffPassword);
        }
    }
}
