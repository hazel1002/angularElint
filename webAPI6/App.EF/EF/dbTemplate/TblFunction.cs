using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    /// <summary>
    /// 單元(已審核)
    /// </summary>
    public partial class TblFunction
    {
        /// <summary>
        /// 模組編號
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 模組名稱
        /// </summary>
        public string? CName { get; set; }
        /// <summary>
        /// 父模組編號
        /// </summary>
        public int? CParentId { get; set; }
        /// <summary>
        /// 功能頁面
        /// </summary>
        public string? CPageUrl { get; set; }
        /// <summary>
        /// 是否為後台目錄(0:否, 1:是)
        /// </summary>
        public bool? CIsMenu { get; set; }
        /// <summary>
        /// 前台及後台目錄索引值(排序由小到大)
        /// </summary>
        public int? CMenuIndex { get; set; }
        /// <summary>
        /// 後台CSS樣式名稱
        /// </summary>
        public string? CCssStyle { get; set; }
        /// <summary>
        /// 狀態(0:停用, 1:啟用)
        /// </summary>
        public int? CStatus { get; set; }
        /// <summary>
        /// 緩刪除(0:未刪除, 1:已刪除)
        /// </summary>
        public bool? CIsDelete { get; set; }
        /// <summary>
        /// (0:是單元, 1:新增, 2:修改, 3:檢視, 4:刪除, 5:審核)
        /// </summary>
        public byte? CCompetenceType { get; set; }
        /// <summary>
        /// 建立日期時間
        /// </summary>
        public DateTime? CCreateDt { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        public int? CCreator { get; set; }
        /// <summary>
        /// 修改日期時間
        /// </summary>
        public DateTime? CUpdateDt { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        public int? CUpdator { get; set; }
        /// <summary>
        /// 審查流程ID
        /// </summary>
        public int CFlowId { get; set; }
    }
}
