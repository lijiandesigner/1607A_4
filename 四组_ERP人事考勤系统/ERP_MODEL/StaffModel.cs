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
    public class StaffModel
    {
        [Key]
        public int StaffId { get; set; }
        // 工号
        public string JobNumber { get; set; }
        // 姓名
        public string StaffName { get; set; }
        // 性别
        public bool StaffSex { get; set; }
        // 身份证
        public string Identitycard { get; set; }
        // 电话
        public string StaffPhone { get; set; }
        // 邮箱
        public string StaffEmail { get; set; }
        // 入职时间
        public DateTime StaffEntryDate { get; set; }
        // 头像
        public string HandImg { get; set; }

        // 连接角色Id
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public string StaffPassword { get; set; }  // 员工密码
        public RoleModel Roles { get; set; }
        [JsonIgnore]
        public ICollection<LeaveModel> lea { get; set; }
        [JsonIgnore]
        public ICollection<CheckModel> che { get; set; }
    }
}
