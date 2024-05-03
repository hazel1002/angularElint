using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblBusinessUnit
    {
        public int CId { get; set; }
        public string CBucode { get; set; }
        public string CName { get; set; }
        public string CDescription { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CUpdator { get; set; }
        public int? CStatus { get; set; }
        public string CRemark { get; set; }
        public int? CUserLimit { get; set; }
        public bool? CPlatformIsSupport { get; set; }
        public int? CType { get; set; }
    }
}
