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
    
    public partial class YL_FILES
    {
        public YL_FILES()
        {
            this.YL_BBS = new HashSet<YL_BBS>();
            this.YL_BULLETIN = new HashSet<YL_BULLETIN>();
            this.YL_TASK_FLOW_HANDLE = new HashSet<YL_TASK_FLOW_HANDLE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PATH { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public int LENGTH { get; set; }
        public Nullable<System.DateTime> UPLOAD_TIME { get; set; }
        public string REMARK { get; set; }
        public string URL { get; set; }
        public string FILE_TYPE { get; set; }
    
        public virtual ICollection<YL_BBS> YL_BBS { get; set; }
        public virtual ICollection<YL_BULLETIN> YL_BULLETIN { get; set; }
        public virtual ICollection<YL_TASK_FLOW_HANDLE> YL_TASK_FLOW_HANDLE { get; set; }
    }
}
