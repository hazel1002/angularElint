using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    /// <summary>
    /// 模組功能管理(對應企業)
    /// </summary>
    public partial class TblFunctionOnBu
    {
        public int CBuid { get; set; }
        public int CFunctionId { get; set; }
        public int? CStatus { get; set; }
    }
}
