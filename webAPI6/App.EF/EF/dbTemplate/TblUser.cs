using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    /// <summary>
    /// 使用者
    /// </summary>
    public partial class TblUser
    {
        /// <summary>
        /// 使用者編號編號
        /// </summary>
        public int CUserId { get; set; }
        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string? CUserName { get; set; }
        /// <summary>
        /// cAccount、cAccount2都不可重複
        /// </summary>
        public string? CAccount { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string? CPassword { get; set; }
        /// <summary>
        /// 信箱
        /// </summary>
        public string? CMail { get; set; }
        /// <summary>
        /// 是否為單位最高權限(0:否, 1:是)
        /// </summary>
        public bool? CIsDeptManager { get; set; }
        /// <summary>
        /// 緩刪除(0:未刪除, 1:已刪除)
        /// </summary>
        public bool? CIsDelete { get; set; }
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
        /// <summary>
        /// 狀態 0:停用 1:啟用
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 代理單位
        /// </summary>
        public string? CAgentUnit { get; set; }
        /// <summary>
        /// BU
        /// </summary>
        public int? CBuid { get; set; }
    }
}
