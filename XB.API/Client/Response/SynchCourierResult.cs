using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XB.API.Client.Response
{
    public class SynchCourierResult : BaseResponse, IResponse
    {
        /// <summary>
        /// 快递员权限信息
        /// </summary>
        [JsonProperty("courierAuthorityInfos")]
        public CourierAuthorityInfos CourierAuthorityInfos { get; set; }
    }

    public class CourierAuthorityInfos
    {
        [JsonProperty("ICourierAuthorityInfo")]
        public List<ICourierAuthorityInfo> ICourierAuthorityInfos { get; set; }
    }
    public class ICourierAuthorityInfo
    {
        /// <summary>
        /// 权限类型（1，派件寄存；2，寄件取件）
        /// </summary>
        [JsonProperty("authorityType")]
        public int AuthorityType { get; set; }

        /// <summary>
        /// 快递员信息
        /// </summary>
        [JsonProperty("courierInfo")]
        public ICourierInfo CourierInfo { get; set; }

        /// <summary>
        /// 快递员关联卡信息
        /// </summary>
        [JsonProperty("courierCardInfo")]
        public ICourierCardInfo CourierCardInfo { get; set; }
    }

    public class ICourierInfo
    {
        /// <summary>
        /// 快递员编号
        /// </summary>
        [JsonProperty("courierId")]
        public String CourierId { get; set; }

        /// <summary>
        ///  姓名
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        [JsonProperty("mobilePhone")]
        public String MobilePhone { get; set; }

        /// <summary>
        /// 所属公司Name
        /// </summary>
        [JsonProperty("excoName")]
        public String ExcoName { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class ICourierCardInfo
    {
        /// <summary>
        /// 卡的ID编号
        /// </summary>
        [JsonProperty("cardId")]
        public String CardId { get; set; }

        /// <summary>
        /// 卡的Code编号
        /// </summary>
        [JsonProperty("cardCode")]
        public String CardCode { get; set; }

        /// <summary>
        /// 卡绑定的密码
        /// </summary>
        [JsonProperty("cardPwd")]
        public String CardPwd { get; set; }

        /// <summary>
        /// 快递员ID编号
        /// </summary>
        [JsonProperty("courierId")]
        public String CourierId { get; set; }

        /// <summary>
        /// 卡的描述信息
        /// </summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [JsonProperty("cardType")]
        public int CardType { get; set; }

        /// <summary>
        /// 颁发机构
        /// </summary>
        [JsonProperty("issuedAgency")]
        public String IssuedAgency { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 是否有效（0，无效；1，有效）
        /// </summary>
        [JsonProperty("validFlag")]
        public int ValidFlag { get; set; }
    }
}