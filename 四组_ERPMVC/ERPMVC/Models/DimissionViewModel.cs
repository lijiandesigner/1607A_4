using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class DimissionViewModel
    {
        public int DimId { get; set; }
        public int StaffId { get; set; }        // 连接员工Id
        public DateTime StartTime { get; set; }  //离职开始时间 
        public string DimCause { get; set; }   // 离职原因
        public string DimState { get; set; }   // 离职状态
        public virtual StaffViewModel staffs { get; set; }
    }
}