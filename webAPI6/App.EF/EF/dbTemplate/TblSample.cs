using System;
using System.Collections.Generic;

namespace App.EF.EF.dbTemplate
{
    public partial class TblSample
    {
        /// <summary>
        /// Key
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 文字框範例
        /// </summary>
        public string? CTitle { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:0,
        ///   &quot;isRequire&quot;:1,
        ///   &quot;columnDesc&quot;:&quot;必填範例&quot;
        /// }
        /// </summary>
        public string? CDescription { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:1,
        ///   &quot;isRequire&quot;:1,
        ///   &quot;type&quot;:&quot;dropdownlist&quot;,
        ///   &quot;options&quot;:[{&quot;text&quot;:&quot;功能1&quot;,&quot;value&quot;:&quot;T1&quot;},{&quot;text&quot;:&quot;功能2&quot;,&quot;value&quot;:&quot;T2&quot;},{&quot;text&quot;:&quot;功能3&quot;,&quot;value&quot;:&quot;T3&quot;}],
        ///   &quot;columnDesc&quot;:&quot;下拉範例&quot;
        /// }
        /// </summary>
        public string CType { get; set; } = null!;
        /// <summary>
        /// 日期範例
        /// </summary>
        public DateTime CStartDate { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:1,
        ///   &quot;columnDesc&quot;:&quot;查詢範例&quot;
        /// }
        /// </summary>
        public string? CQueryBox { get; set; }
        /// <summary>
        /// {
        ///   &quot;isquery&quot;:0,
        ///   &quot;isRequire&quot;:1,
        ///   &quot;type&quot;:&quot;dropdownlist&quot;,
        ///   &quot;options&quot;:[{&quot;text&quot;:&quot;B功能1&quot;,&quot;value&quot;:&quot;T1&quot;},{&quot;text&quot;:&quot;B功能2&quot;,&quot;value&quot;:&quot;T2&quot;},{&quot;text&quot;:&quot;B功能3&quot;,&quot;value&quot;:&quot;T3&quot;}],
        ///   &quot;columnDesc&quot;:&quot;下拉範例2&quot;
        /// }
        /// </summary>
        public string? CType2 { get; set; }
    }
}
