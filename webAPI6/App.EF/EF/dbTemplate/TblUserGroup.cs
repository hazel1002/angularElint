using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    /// <summary>
    /// 使用者群組
    /// </summary>
    public partial class TblUserGroup
    {
        /// <summary>
        /// 使用者群組編號
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 群組名稱
        /// </summary>
        public string? CName { get; set; }
        /// <summary>
        /// 狀態(0:停用, 1:啟用)
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int? CCreator { get; set; }
        /// <summary>
        /// 建立日期時間
        /// </summary>
        public DateTime? CCreateDt { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public int? CUpdator { get; set; }
        /// <summary>
        /// 更新日期時間
        /// </summary>
        public DateTime? CUpdateDt { get; set; }
        public int? CBuid { get; set; }
    }
}
