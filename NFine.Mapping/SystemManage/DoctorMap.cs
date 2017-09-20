using NFine.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    /// <summary>
    /// 医生表
    /// </summary>
    public class DoctorMap : EntityTypeConfiguration<DoctorEntity>
    {
        public DoctorMap()
        {
            this.ToTable("Doctor");
            this.HasKey(t => t.Id);
            /// <summary>
            /// 医生ID
            /// </summary>
            this.Property(t => t.DoctorId);
            /// <summary>
            /// 医生姓名
            /// </summary>
            this.Property(t => t.DoctorName);
            /// <summary>
            /// 专长
            /// </summary>
            this.Property(t => t.GootAt);
            /// <summary>
            /// 头像
            /// </summary>
            this.Property(t => t.Avatar);
            /// <summary>
            /// 职称
            /// </summary>
            this.Property(t => t.Title);
            /// <summary>
            /// 简介
            /// </summary>
            this.Property(t => t.Introduction);
            /// <summary>
            /// 预约周期
            /// </summary>
            this.Property(t => t.OrderCycle);
            /// <summary>
            /// 性别
            /// </summary>
            this.Property(t => t.Gender);
            /// <summary>
            /// 预约类型 1:依次 2:分时段预约
            /// </summary>
            this.Property(t => t.OrderType);
            /// <summary>
            /// 
            /// </summary>
            this.Property(t => t.AddDate);
        }
    }
}