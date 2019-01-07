using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class DBContent:DbContext
    {
        public DBContent() : base("DB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<StaffModel> staffs { get; set; }
        public virtual DbSet<CheckModel> checks { get; set; }
        public virtual DbSet<RoleModel> roles { get; set; }
        public virtual DbSet<LeaveModel> leaves { get; set; }
        public virtual DbSet<DepartmentModel> departments { get; set; }
        public virtual DbSet<MoneyModel> moneys { get; set; }
        public virtual DbSet<DimissionModel> dimission { get; set; }
    }
}
