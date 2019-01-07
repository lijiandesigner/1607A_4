using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;
using ERP_DAL;

namespace ERP_BLL
{
    public class Dimissionbll
    {
        Dimissiondal dal = new Dimissiondal();
        /// <summary>
        /// /请假添加
        /// </summary>
        /// <param name="lea"></param>
        /// <returns></returns>
        public int AddDim(DimissionModel dim)
        {
            return dal.AddDim(dim);
        }
        //请假信息显示
        public List<DimissionModel> ShowDim()
        {
            return dal.ShowDim();
        }
        //请假删除
        public int DelDim(int id)
        {
            return dal.DelDim(id);
        }
        /// <summary>
        /// /根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DimissionModel GetShow(int id)
        {
            return dal.GetShow(id);

        }
        //请假修改
        public int UpdLeave(DimissionModel lea)
        {
            return dal.UpdLeave(lea);

        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<DimissionModel> TShowDim(DateTime StartDate, string Name)
        {
            return dal.TShowDim(StartDate,  Name);
        }
    }
}
