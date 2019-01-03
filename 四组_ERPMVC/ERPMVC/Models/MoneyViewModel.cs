using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class MoneyViewModel
    {
        ///薪资表
        /// <summary>
        /// 薪资数据Id
        /// </summary>
        public int SalaryId { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        public int StaffId { get; set; }

        /// <summary>
        /// 五险一金
        /// </summary>
        public int Insurance { get; set; }

        /// <summary>
        /// 纳税费用
        /// </summary>
        public double Tax { get; set; }

        /// <summary>
        /// 基本工资
        /// </summary>
        public double Base { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// 实发工资
        /// </summary>
        public double Fsalary { get; set; }

        /// <summary>
        /// 员工状态
        /// </summary>
        public string StaffState { get; set; }

    }
}