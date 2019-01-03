using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ERP_MODEL
{
    public class DepartmentModel //部门模型类
    {
        [Key]
        public int DepartmentId { get; set; } //部门ID
        public string DepartmentJobNumber { get; set; }//部门编号
        public string DepartmentName { get; set; }//部门名称
        public string DepartmentRemark { get; set; }//部门备注
        [JsonIgnore]
        public ICollection<RoleModel> Ro { get; set; }
    }
}
