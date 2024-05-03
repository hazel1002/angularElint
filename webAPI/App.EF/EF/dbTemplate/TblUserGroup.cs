using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblUserGroup
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public int? CStatus { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CUpdator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CBuid { get; set; }
    }
}
