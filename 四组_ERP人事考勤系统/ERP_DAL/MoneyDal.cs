using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class MoneyDal
    {
        DBContent content = new DBContent();
        public int Add(MoneyModel money)//添加
        {
            content.moneys.Add(money);
            return content.SaveChanges();
        }
        public int Delete(int Id)//删除
        {
            MoneyModel money = content.moneys.Where(s => s.SalaryId == Id).FirstOrDefault();
            content.moneys.Remove(money);
            return content.SaveChanges();
        }
        public List<MoneyModel> money()//显示
        {
            return content.moneys.ToList();
        }
        public MoneyModel Fan(int Id)//反填
        {
            var list = from s in content.moneys.ToList()
                       where s.SalaryId == Id
                       select s;
            return list.FirstOrDefault();
        }
        public int Update(MoneyModel money)//修改
        {
            content.Entry(money).State = System.Data.Entity.EntityState.Modified;
            return content.SaveChanges();
        }
        public List<MoneyModel> TShowMoney(string Name,DateTime date)
        {
            return content.moneys.Where(m => m.staffs.StaffName == Name || m.date == date).ToList();
        }
    }

}
