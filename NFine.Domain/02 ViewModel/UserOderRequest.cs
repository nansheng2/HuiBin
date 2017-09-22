
using NFine.Domain.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.ViewModel
{
    /// <summary>
    /// 用户预约请求参数
    /// </summary>
    public class UserOderRequest
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CredentialInformation
        {
            get;
            set;
        }

        /// <summary>
        /// 证件号码
        /// </summary>
        public CredentialTypeEnum CredentialType
        {
            get;
            set;
        }

        /// <summary>
        /// 全名
        /// </summary>
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// 就诊卡号
        /// </summary>
        public string VisitingCardNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderEnum Gender
        {
            get;
            set;
        }


        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber
        {
            get;
            set;
        }


        /// <summary>
        /// E-mail
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// 症状
        /// </summary>
        public string SymptomDescription
        {
            get;
            set;
        }

        /// <summary>
        /// 国籍
        /// </summary>
        public int Nationality
        {
            get;
            set;
        }
    }
}
