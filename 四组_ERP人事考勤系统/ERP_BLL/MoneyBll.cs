using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using ERP_DAL;

namespace ERP_BLL
{
    public class MoneyBll
    {
        MoneyDal dal = new MoneyDal();
        public int Add(MoneyModel money)//添加
        {
            return dal.Add(money);
        }
        public int Delete(int Id)//删除
        {
            return dal.Delete(Id);
        }
        public List<MoneyModel> money()//显示
        {
            return dal.money();
        }
        public MoneyModel Fan(int Id)//反填
        {
            return Fan(Id);
        }
        public int Update(MoneyModel money)//修改
        {
            return dal.Update(money);
        }
        public List<MoneyModel> TShowMoney(string Name, DateTime date)
        {
            return dal.TShowMoney(Name, date);
        }

    }
}
