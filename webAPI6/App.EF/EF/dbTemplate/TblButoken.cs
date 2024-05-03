using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblButoken
    {
        public int CId { get; set; }
        public string? CBuid { get; set; }
        public string? CToken { get; set; }
        public DateTime? CEffectiveDt { get; set; }
        public DateTime? CExpiredDt { get; set; }
        public string? CRemark { get; set; }
        public int? CStatus { get; set; }
        public DateTime? CCreateDt { get; set; }
        public string? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public string? CUpdator { get; set; }
    }
}
