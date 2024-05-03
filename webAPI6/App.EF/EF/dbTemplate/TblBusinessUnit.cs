using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    /// <summary>
    /// 企業主檔
    /// </summary>
    public partial class TblBusinessUnit
    {
        /// <summary>
        /// BUID
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// BU代碼
        /// </summary>
        public string? CBucode { get; set; }
        /// <summary>
        /// BU名稱
        /// </summary>
        public string? CName { get; set; }
        /// <summary>
        /// 說明
        /// </summary>
        public string? CDescription { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CUpdator { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string? CRemark { get; set; }
        /// <summary>
        /// 使用者上限
        /// </summary>
        public int? CUserLimit { get; set; }
        /// <summary>
        /// 是否支援
        /// </summary>
        public bool? CPlatformIsSupport { get; set; }
        /// <summary>
        /// 1 平台 2 商戶
        /// </summary>
        public int? CType { get; set; }
    }
}
