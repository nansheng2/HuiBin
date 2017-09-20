using NFine.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    /// <summary>
    /// 会员表
    /// </summary>
    public class MemberMap : EntityTypeConfiguration<MemberEntity>
    {
        public MemberMap()
        {
            this.ToTable("Member");
            this.HasKey(t => t.Id);
            /// <summary>
            /// 会员Id
            /// </summary>
            this.Property(t => t.MemberId);
            /// <summary>
            /// 证件号码
            /// </summary>
            this.Property(t => t.CredentialInformation);
            /// <summary>
            /// 证件类型 1:护照 2:身份证
            /// </summary>
            this.Property(t => t.CredentialType);
            /// <summary>
            /// 全名
            /// </summary>
            this.Property(t => t.FullName);
            /// <summary>
            /// 就诊卡号
            /// </summary>
            this.Property(t => t.VisitingCardNumber);
            /// <summary>
            /// 性别 1:男 2:女
            /// </summary>
            this.Property(t => t.Gender);
            /// <summary>
            /// 出生年月
            /// </summary>
            this.Property(t => t.DateOfBirth);
            /// <summary>
            /// 联系电话
            /// </summary>
            this.Property(t => t.ContactNumber);
            /// <summary>
            /// E-mail
            /// </summary>
            this.Property(t => t.Email);
            /// <summary>
            /// 国籍
            /// </summary>
            this.Property(t => t.Nationality);
            /// <summary>
            /// 添加时间
            /// </summary>
            this.Property(t => t.AddDate);
        }
    }
}