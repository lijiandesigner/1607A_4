using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; } //部门ID
        public string DepartmentJobNumber { get; set; }//部门编号
        public string DepartmentName { get; set; }//部门名称
        public string DepartmentRemark { get; set; }//部门备注
    }
}