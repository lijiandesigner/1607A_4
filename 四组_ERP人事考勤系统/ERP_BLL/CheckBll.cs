using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using ERP_DAL;

namespace ERP_BLL
{
    public class CheckBll
    {
        CheckDal dal = new CheckDal();
        //增加
        public int Add(CheckModel check)
        {
            return dal.Add(check);
        }
        //删除
        public int Del(int Id)
        {
            return dal.Del(Id);
        }
        //修改
        public int Upd(CheckModel check)
        {
            return dal.Upd(check);
        }
        //查询
        public List<CheckModel> Show()
        {
            return dal.Show();
        }
        //反填
        public CheckModel Fan(int id)
        {
            return dal.Fan(id);
        }

        public List<CheckModel> TShowCheck(string Name, DateTime date)
        {
            return dal.TShowCheck(Name, date);
        }
    }
}
