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
    
    public partial class YL_TASK_FLOW_HANDLE
    {
        public YL_TASK_FLOW_HANDLE()
        {
            this.YL_FILES = new HashSet<YL_FILES>();
        }
    
        public int ID { get; set; }
        public int TASK_FLOW_ID { get; set; }
        public int DEAL_USER_ID { get; set; }
        public string DEAL_USER_NAME { get; set; }
        public System.DateTime DEAL_TIME { get; set; }
        public string CONTENT { get; set; }
    
        public virtual YL_TASK_FLOW YL_TASK_FLOW { get; set; }
        public virtual ICollection<YL_FILES> YL_FILES { get; set; }
    }
}
