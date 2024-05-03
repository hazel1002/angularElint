﻿using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblAccessLog
    {
        public int CId { get; set; }
        public int? CUserId { get; set; }
        public int? CFunctionId { get; set; }
        public string CActionName { get; set; }
        public string CApiname { get; set; }
        public string CRequest { get; set; }
        public string CUrl { get; set; }
        public string CRemark { get; set; }
        public string CIp { get; set; }
        public DateTime? CCreateDt { get; set; }
        public int? CCreator { get; set; }
        public DateTime? CUpdateDt { get; set; }
        public int? CUpdator { get; set; }
    }
}
