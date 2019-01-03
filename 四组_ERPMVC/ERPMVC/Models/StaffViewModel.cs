using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERPMVC.Models
{
    public class StaffViewModel
    {
        public int StaffId { get; set; }
        [Display(Name = "工号")]
        [RegularExpression(@"\d", ErrorMessage = "只能为数字！")]
        public string JobNumber { get; set; }
        [Display(Name = "员工姓名")]
        public string StaffName { get; set; }
        [Display(Name = "员工性别")]
        public string StaffSex { get; set; }
        [Display(Name = "身份证")]
        [RegularExpression(@"\d{18}", ErrorMessage = "身份证号为18位")]
        public string Identitycard { get; set; }
        [Display(Name = "手机号")]
        [RegularExpression(@"\d{11}", ErrorMessage = "手机号格式不正确")]
        public string StaffPhone { get; set; }
        [Display(Name = "邮箱")]
        public string StaffEmail { get; set; }
        [Display(Name = "入职日期")]
        public DateTime StaffEntryDate { get; set; }
        [Display(Name = "头像")]
        public string HandImg { get; set; }
        [Display(Name = "角色")]
        public string RoleId { get; set; }
        [Display(Name ="部门")]
        public string Dep { get; set; }
        [Display(Name = "密码")]
        public string StaffPassword { get; set; }
    }
}