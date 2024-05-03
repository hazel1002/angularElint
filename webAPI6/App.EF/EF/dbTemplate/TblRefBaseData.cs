using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblRefBaseData
    {
        public int CId { get; set; }
        public int? CMemberId { get; set; }
        public string? CRefType { get; set; }
        public string? CRefId { get; set; }
        public string? CRefData { get; set; }
        public string? CRemark { get; set; }
        public DateTime? CCreateDt { get; set; }
        public string? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public string? CUpdator { get; set; }
    }
}
