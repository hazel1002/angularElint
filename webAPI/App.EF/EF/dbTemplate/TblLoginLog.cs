using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblLoginLog
    {
        public int CId { get; set; }
        public int? CUserId { get; set; }
        public string CUserToken { get; set; }
        public string CIp { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CUpdator { get; set; }
    }
}
