using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblAccessLog
    {
        public int CId { get; set; }
        public int? CUserId { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:1,
        ///   &quot;type&quot;:&quot;dropdownlist&quot;,
        ///   &quot;options&quot;:[{&quot;text&quot;:&quot;功能1&quot;,&quot;value&quot;:&quot;1&quot;},{&quot;text&quot;:&quot;功能2&quot;,&quot;value&quot;:&quot;2&quot;},{&quot;text&quot;:&quot;功能3&quot;,&quot;value&quot;:&quot;3&quot;}],
        ///   &quot;columnDesc&quot;:&quot;功能&quot;
        /// }
        /// </summary>
        public int? CFunctionId { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:1,
        ///   &quot;isRequire&quot;:1,
        ///   &quot;columnDesc&quot;:&quot;動作名稱&quot;
        /// }
        /// </summary>
        public string? CActionName { get; set; }
        /// <summary>
        /// API
        /// </summary>
        public string? CApiname { get; set; }
        /// <summary>
        /// 請求參數
        /// </summary>
        public string? CRequest { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string? CUrl { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string? CRemark { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        public string? CIp { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime? CCreateDt { get; set; }
        /// <summary>
        /// 建立者Id
        /// </summary>
        public int? CCreator { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? CUpdateDt { get; set; }
        /// <summary>
        /// 更新者Id
        /// </summary>
        public int? CUpdator { get; set; }
    }
}
