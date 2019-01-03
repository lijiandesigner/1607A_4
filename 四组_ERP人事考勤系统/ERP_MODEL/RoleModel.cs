using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ERP_MODEL
{
    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; } //角色Id
        [ForeignKey("departmens")]
        public int DepartmentId { get; set; }//部门Id
        public string RoleName { get; set; }//角色名称
        public double RoleSalary { get; set; }//角色工资
        public int Rolejurisdiction { get; set; }//角色权限  // 员工 0，,经理 1 ，老板 2
        public DepartmentModel departmens { get; set; }
        [JsonIgnore]
        public ICollection<StaffModel> sta { get; set; }
    }
}
