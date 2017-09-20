using NFine.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    /// <summary>
    /// 分时间预约
    /// </summary>
    public class SegmentationOrderMap : EntityTypeConfiguration<SegmentationOrderEntity>
    {
        public SegmentationOrderMap()
        {
            this.ToTable("SegmentationOrder");
            this.HasKey(t => t.Id);
            /// <summary>
            /// 分时间预约Id
            /// </summary>
            this.Property(t => t.SegmentationOrderId);
            /// <summary>
            /// 预约时间类型 1:上午 2:下午 3:晚上
            /// </summary>
            this.Property(t => t.OrderTimeType);
            /// <summary>
            /// 开始时间
            /// </summary>
            this.Property(t => t.BeginTime);
            /// <summary>
            /// 结束时间
            /// </summary>
            this.Property(t => t.EndTime);
            /// <summary>
            /// 预约数量
            /// </summary>
            this.Property(t => t.OrderCount);
            /// <summary>
            /// 添加时间
            /// </summary>
            this.Property(t => t.AddDate);
        }
    }
}