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
    
    public partial class YL_BULLETIN_REVIEW
    {
        public YL_BULLETIN_REVIEW()
        {
            this.YL_BULLETIN_REVIEW1 = new HashSet<YL_BULLETIN_REVIEW>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PARENT_ID { get; set; }
        public int BULLETIN_ID { get; set; }
        public string NAME { get; set; }
        public string CONTENT { get; set; }
        public int USER_ID { get; set; }
        public System.DateTime ADD_TIME { get; set; }
        public string STATUS { get; set; }
        public System.DateTime STATUS_TIME { get; set; }
    
        public virtual YL_BULLETIN YL_BULLETIN { get; set; }
        public virtual ICollection<YL_BULLETIN_REVIEW> YL_BULLETIN_REVIEW1 { get; set; }
        public virtual YL_BULLETIN_REVIEW YL_BULLETIN_REVIEW2 { get; set; }
    }
}
