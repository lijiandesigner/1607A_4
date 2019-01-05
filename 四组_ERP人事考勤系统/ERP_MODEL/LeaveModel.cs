using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_MODEL
{
    public class LeaveModel
    {
        [Key]
        public int LeaveId { get; set; }
        [ForeignKey("staffs")]
        public int StaffId { get; set; }        // 连接员工Id
        public DateTime StartTime { get; set; }  //请假开始时间 
        public DateTime EndTime { get; set; }    // 请假结束时间
        public string LeaveCause { get; set; }   // 离开原因
        public string LeaveState { get; set; }   // 请假状态
        public virtual StaffModel staffs { get; set; }
    }
}
