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
    
    public partial class YL_DATAUP_FILED
    {
        public int ID { get; set; }
        public int DATAUP_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public string ALIAS { get; set; }
        public string FIELD_TYPE { get; set; }
        public Nullable<int> IS_USE { get; set; }
    
        public virtual YL_DATAUP YL_DATAUP { get; set; }
    }
}