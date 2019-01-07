using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class DimissionModel
    {
        [Key]
        public int DimId { get; set; }
        [ForeignKey("staffs")]
        public int StaffId { get; set; }        // 连接员工Id
        public DateTime StartTime { get; set; }  //离职开始时间 
        public string DimCause { get; set; }   // 离职原因
        public string DimState { get; set; }   // 离职状态
        public virtual StaffModel staffs { get; set; }
    }
}
