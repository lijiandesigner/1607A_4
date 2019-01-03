using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_MODEL
{
    public class CheckModel
    {
        //员工考勤表
        /// <summary>
        /// 考勤ID  主键
        /// </summary>
        [Key]
        public int CheckID { get; set; }
        /// <summary>
        /// 员工工号   外键
        /// </summary>
        [ForeignKey("staffs")]
        public int StaffId { get; set; }
        /// <summary>
        /// 上午上班时间
        /// </summary>
        public DateTime MorningHours { get; set; }
        /// <summary>
        /// 下午上班时间
        /// </summary>
        public DateTime AfternoonHours { get; set; }
        /// <summary>
        /// 员工状态
        /// </summary>
        public string StaffState { get; set; }

        public StaffModel staffs { get; set; }
    }
}
