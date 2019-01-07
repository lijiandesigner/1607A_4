using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class CheckDal
    {
        DBContent content = new DBContent();
        //增加
        public int Add(CheckModel check)
        {
            content.checks.Add(check);
            return content.SaveChanges();
        }
        //删除
        public int Del(int Id)
        {

            CheckModel c1 = content.checks.Where(s => s.CheckID == Id).FirstOrDefault();
            content.checks.Remove(c1);

            //content.Entry(c1).State = System.Data.Entity.EntityState.Deleted;
            return content.SaveChanges();
        }
        //修改
        public int Upd(CheckModel check)
        {
            content.checks.Attach(check);
            content.Entry(check).State = System.Data.Entity.EntityState.Modified;
            return content.SaveChanges();
        }
        //查询
        public List<CheckModel> Show()
        {
            return content.checks.ToList();
        }
        //反填
        public CheckModel Fan(int id)
        {
            return content.checks.FirstOrDefault(c => c.CheckID == id);
        }
        /// <summary>
        /// 根据姓名和打卡时间进行查询
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<CheckModel> TShowCheck(string Name, DateTime date)
        {
            return content.checks.Where(m => m.staffs.StaffName == Name || m.MorningHours > date).ToList();


        }
        public CheckModel PunchShow(int id,DateTime time)
        {
            return content.checks.Where(s => s.StaffId == id && s.MorningHours > time).FirstOrDefault();
        }
    }
}
