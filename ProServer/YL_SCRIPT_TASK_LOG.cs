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
    
    public partial class YL_SCRIPT_TASK_LOG
    {
        public int ID { get; set; }
        public int SCRIPT_TASK_ID { get; set; }
        public System.DateTime LOG_TIME { get; set; }
        public short LOG_TYPE { get; set; }
        public string MESSAGE { get; set; }
        public string SQL_TEXT { get; set; }
    
        public virtual YL_SCRIPT_TASK YL_SCRIPT_TASK { get; set; }
    }
}
