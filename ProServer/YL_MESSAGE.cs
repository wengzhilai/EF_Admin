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
    
    public partial class YL_MESSAGE
    {
        public YL_MESSAGE()
        {
            this.YL_USER_MESSAGE = new HashSet<YL_USER_MESSAGE>();
        }
    
        public int ID { get; set; }
        public Nullable<int> MESSAGE_TYPE_ID { get; set; }
        public Nullable<int> KEY { get; set; }
        public string TITLE { get; set; }
        public string CONTENT { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string CREATE_USERNAME { get; set; }
        public Nullable<int> CREATE_USERID { get; set; }
        public string STATUS { get; set; }
        public string PUSH_TYPE { get; set; }
        public Nullable<int> DISTRICT_ID { get; set; }
        public string ALL_ROLE_ID { get; set; }
    
        public virtual YL_MESSAGE_TYPE YL_MESSAGE_TYPE { get; set; }
        public virtual ICollection<YL_USER_MESSAGE> YL_USER_MESSAGE { get; set; }
    }
}
