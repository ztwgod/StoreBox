using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XB.API.Client.Response
{
    public class SynchSysUserResult : BaseResponse, IResponse
    {
        /// <summary>
        /// 维护人员权限信息
        /// </summary>
        [JsonProperty("sysUserAuthorityInfos")]
        public List<ISysUserAuthorityInfo> SysUserAuthorityInfos { get; set; }
    }

    public class ISysUserAuthorityInfo
    {
        /// <summary>
        /// 权限类型（1，可开启任意物箱；2，只允许开启特定状态物箱；3，只允许开启某一个物箱、或多个指定物箱）一期只支持第三种
        /// </summary>
        [JsonProperty("authorityType")]
        public int AuthorityType { get; set; }

        /// <summary>
        /// 维护人员员信息
        /// </summary>
        [JsonProperty("sysUserInfo")]
        public ISysUserInfo SysUserInfo { get; set; }

        /// <summary>
        /// 维护人员关联卡信息
        /// </summary>
        [JsonProperty("sysUserCardInfo")]
        public ISysUserCardInfo SysUserCardInfo { get; set; }

        /// <summary>
        /// 运行状态：1，空闲、2，占用、3，占用超时、4，弃件（占用超期）、5，开启、6，故障、7，租用、8，预留、9，闭塞、10，未关闭、11，被破坏、12，维修
        /// </summary>
        [JsonProperty("boxRunStatus")]
        public List<int> BoxRunStatus { get; set; }

        /// <summary>
        /// 维护人员可维护的箱子code列表
        /// </summary>
        [JsonProperty("boxCodes")]
        public List<String> BoxCodes { get; set; }
    }

    public class ISysUserInfo
    {
        /// <summary>
        /// 维护人员ID编号
        /// </summary>
        [JsonProperty("sysUserId")]
        public String SysUserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        [JsonProperty("mobilePhone")]
        public String MobilePhone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        /// <summary>
        ///  电子邮箱
        /// </summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public String Status { get; set; }
    }

    public class ISysUserCardInfo
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
        /// 维护人员ID编号
        /// </summary>
        [JsonProperty("userId")]
        public String UserId { get; set; }

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
        /// 有效期 （格式：yyyy-MM-dd）
        /// </summary>
        [JsonProperty("expirationDate")]
        public String ExpirationDate { get; set; }

        /// <summary>
        /// 是否有效（0，无效；1，有效）
        /// </summary>
        [JsonProperty("validFlag")]
        public int ValidFlag { get; set; }
    }
}