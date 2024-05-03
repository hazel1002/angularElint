using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblMember
    {
        public int CId { get; set; }
        public string? CUid { get; set; }
        public string? CBuid { get; set; }
        public string? CEmail { get; set; }
        public string? CPhone { get; set; }
        public string? CName { get; set; }
        public DateTime? CCreateDt { get; set; }
        public string? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public string? CUpdator { get; set; }
        public int? CStatus { get; set; }
        public string? CRemark { get; set; }
        public string? CRefKey1 { get; set; }
        public string? CRefKey2 { get; set; }
    }
}
