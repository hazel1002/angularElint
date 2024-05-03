using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblLoginLog
    {
        public int CId { get; set; }
        public int? CUserId { get; set; }
        public string? CUserToken { get; set; }
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
