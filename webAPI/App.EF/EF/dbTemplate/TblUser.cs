using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblUser
    {
        public int CUserId { get; set; }
        public string CUserName { get; set; }
        public string CAccount { get; set; }
        public string CPassword { get; set; }
        public string CMail { get; set; }
        public bool? CIsDeptManager { get; set; }
        public bool? CIsDelete { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CUpdator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CStatus { get; set; }
        public string CAgentUnit { get; set; }
        public int? CBuid { get; set; }
    }
}
