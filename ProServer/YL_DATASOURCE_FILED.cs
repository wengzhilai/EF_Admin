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
    
    public partial class YL_DATASOURCE_FILED
    {
        public YL_DATASOURCE_FILED()
        {
            this.YL_DATASOURCE_WHERE = new HashSet<YL_DATASOURCE_WHERE>();
        }
    
        public int ID { get; set; }
        public int DATASOURCE_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public string ALIAS { get; set; }
        public string FIELD_TYPE { get; set; }
        public short IS_KEY { get; set; }
        public short IS_PARTITION { get; set; }
        public short IS_INDEX { get; set; }
    
        public virtual YL_DATASOURCE YL_DATASOURCE { get; set; }
        public virtual ICollection<YL_DATASOURCE_WHERE> YL_DATASOURCE_WHERE { get; set; }
    }
}
