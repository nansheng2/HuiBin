using NFine.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    /// <summary>
    /// 预约表
    /// </summary>
    public class OrderMap : EntityTypeConfiguration<OrderEntity>
    {
        public OrderMap()
        {
            this.ToTable("Order");
            this.HasKey(t => t.Id);
            /// <summary>
            /// 预约Id
            /// </summary>
            this.Property(t => t.OrderId);
            /// <summary>
            /// 预约医生Id
            /// </summary>
            this.Property(t => t.OrderDoctorId);
            /// <summary>
            /// 预约时间
            /// </summary>
            this.Property(t => t.OrderDate);
            /// <summary>
            /// 预约午别 1:上午 2:下午 3:晚上
            /// </summary>
            this.Property(t => t.OrderType);
            /// <summary>
            /// <div style="border-style: none; position: relative; z-index: 1; left: 7px; width: 689px; ">医生号别 1:普通号 </div>2:专家号
            /// </summary>
            this.Property(t => t.DorderType);
            /// <summary>
            /// 添加时间
            /// </summary>
            this.Property(t => t.AddDate);
        }
    }
}