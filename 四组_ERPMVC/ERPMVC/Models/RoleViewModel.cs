using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMVC.Models
{
    public class RoleViewModel
    {
        public int RoleId { get; set; } //角色Id
        public int DepartmentId { get; set; }//部门Id
        public string RoleName { get; set; }//角色名称
        public double RoleSalary { get; set; }//角色工资
        public int Rolejurisdiction { get; set; }//角色权限  // 员工 0，,经理 1 ，老板 2
        public DepartmentViewModel departmens { get; set; }
    }
}