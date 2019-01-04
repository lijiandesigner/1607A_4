using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class CheckViewModel
    {
        //员工考勤表
        /// <summary>
        /// 考勤ID  主键
        /// </summary>
        public int CheckID { get; set; }
        /// <summary>
        /// 员工id
        /// </summary>
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

        public StaffViewModel staffs { get; set; }
    }
}