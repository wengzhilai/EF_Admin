//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class YL_DATASOURCE_WHERE
    {
        public int ID { get; set; }
        public int DATASOURCE_ID { get; set; }
        public short TYPE { get; set; }
        public int FILED_ID { get; set; }
        public string FILED_NAME { get; set; }
        public string OPTYPE { get; set; }
        public string VALUE { get; set; }
        public string WHERE_SQL { get; set; }
        public string REMARK { get; set; }
    
        public virtual YL_DATASOURCE YL_DATASOURCE { get; set; }
        public virtual YL_DATASOURCE_FILED YL_DATASOURCE_FILED { get; set; }
    }
}
