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
    
    public partial class YL_USER
    {
        public YL_USER()
        {
            this.YL_BBS = new HashSet<YL_BBS>();
            this.YL_COSTLIST = new HashSet<YL_COSTLIST>();
            this.YL_USER_ADDRESS = new HashSet<YL_USER_ADDRESS>();
            this.YL_USER_CARD = new HashSet<YL_USER_CARD>();
            this.YL_USER_WITHDRAW = new HashSet<YL_USER_WITHDRAW>();
            this.YL_USER_MESSAGE = new HashSet<YL_USER_MESSAGE>();
            this.YL_BBS1 = new HashSet<YL_BBS>();
            this.YL_GARAGE = new HashSet<YL_GARAGE>();
            this.YL_DISTRICT1 = new HashSet<YL_DISTRICT>();
            this.YL_MODULE = new HashSet<YL_MODULE>();
            this.YL_ROLE = new HashSet<YL_ROLE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LOGIN_NAME { get; set; }
        public Nullable<int> ICON_FILES_ID { get; set; }
        public int DISTRICT_ID { get; set; }
        public Nullable<short> IS_LOCKED { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public Nullable<int> LOGIN_COUNT { get; set; }
        public Nullable<System.DateTime> LAST_LOGIN_TIME { get; set; }
        public Nullable<System.DateTime> LAST_LOGOUT_TIME { get; set; }
        public Nullable<System.DateTime> LAST_ACTIVE_TIME { get; set; }
        public string REMARK { get; set; }
        public string REGION { get; set; }
    
        public virtual ICollection<YL_BBS> YL_BBS { get; set; }
        public virtual YL_CLIENT YL_CLIENT { get; set; }
        public virtual ICollection<YL_COSTLIST> YL_COSTLIST { get; set; }
        public virtual YL_DISTRICT YL_DISTRICT { get; set; }
        public virtual YL_SALESMAN YL_SALESMAN { get; set; }
        public virtual ICollection<YL_USER_ADDRESS> YL_USER_ADDRESS { get; set; }
        public virtual ICollection<YL_USER_CARD> YL_USER_CARD { get; set; }
        public virtual YL_USER_WALLET YL_USER_WALLET { get; set; }
        public virtual ICollection<YL_USER_WITHDRAW> YL_USER_WITHDRAW { get; set; }
        public virtual ICollection<YL_USER_MESSAGE> YL_USER_MESSAGE { get; set; }
        public virtual ICollection<YL_BBS> YL_BBS1 { get; set; }
        public virtual ICollection<YL_GARAGE> YL_GARAGE { get; set; }
        public virtual ICollection<YL_DISTRICT> YL_DISTRICT1 { get; set; }
        public virtual ICollection<YL_MODULE> YL_MODULE { get; set; }
        public virtual ICollection<YL_ROLE> YL_ROLE { get; set; }
    }
}
