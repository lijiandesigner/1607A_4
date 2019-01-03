using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class LeaveViewModel
    {
        public int LeaveId { get; set; }
        public int StaffId { get; set; }        // 连接员工Id
        public DateTime StartTime { get; set; }  //请假开始时间 
        public DateTime EndTime { get; set; }    // 请假结束时间
        public string LeaveCause { get; set; }   // 离开原因
        public string LeaveState { get; set; }   // 请假状态
        public StaffViewModel staffs { get; set; }
    }
}