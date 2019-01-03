using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_MODEL
{
    public class MoneyModel
    {
        ///薪资表
        /// <summary>
        /// 薪资数据Id
        /// </summary>
        [Key]
        public int SalaryId { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [ForeignKey("staffs")]
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

        public StaffModel staffs { get; set; }
    }
}
