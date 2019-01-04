using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class StaffDal
    {
        DBContent content = new DBContent();
        //添加
        public int AddStaff(StaffModel Sta)
        {
            content.staffs.Add(Sta);
            return content.SaveChanges();

        }
        //显示
        public List<StaffModel> ShowStaff()
        {

            return content.staffs.ToList();
        }
        //删除
        public int DelStaff(int id)
        {
            var jie = content.staffs.Where(s => s.StaffId == id).FirstOrDefault();
            content.Entry(jie).State = System.Data.Entity.EntityState.Deleted;
            return content.SaveChanges();

        }
        //根据Id查询做一个反填效果
        public StaffModel GetShow(int id)
        {

            return content.staffs.Where(s => s.StaffId == id).FirstOrDefault();
        }
        //修改
        public int UpdStaff(StaffModel Sta)
        {

            content.Entry(Sta).State = System.Data.Entity.EntityState.Modified;
            return content.SaveChanges();
        }

        /// <summary>
        /// 根据工号和姓名进行查询
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="JobNumber"></param>
        /// <returns></returns>
        public List<StaffModel> TShowStaff(string Name,string JobNumber)
        {
            return content.staffs.Where(m => m.JobNumber == JobNumber || m.StaffName == Name).ToList();
        }
        public int Login(string username, string password)
        {
            var list = from s in content.staffs.Where(s => s.StaffPhone == username && s.StaffPassword == password) select s;
            return list.Count();
        }
    }
}
