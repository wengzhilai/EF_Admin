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
    
    public partial class YL_ORDER_RESCUE
    {
        public YL_ORDER_RESCUE()
        {
            this.YL_ORDER_RESCUE_SEND = new HashSet<YL_ORDER_RESCUE_SEND>();
        }
    
        public int ID { get; set; }
        public Nullable<int> GARAGE_ID { get; set; }
        public string GARAGE_TYPE { get; set; }
        public string REACH_TYPE { get; set; }
        public Nullable<System.DateTime> REACH_TIME { get; set; }
        public string CLIENT_NAME { get; set; }
        public string CLIENT_PHONE { get; set; }
        public string PLATE_NUMBER { get; set; }
        public string CAR_TYPE { get; set; }
        public string BRAND { get; set; }
        public string MODEL { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> STATUS_TIME { get; set; }
        public string HITCH_TYPE { get; set; }
        public string OTHER_PHONE { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<System.DateTime> PICK_TIME { get; set; }
    
        public virtual YL_GARAGE YL_GARAGE { get; set; }
        public virtual YL_ORDER YL_ORDER { get; set; }
        public virtual ICollection<YL_ORDER_RESCUE_SEND> YL_ORDER_RESCUE_SEND { get; set; }
    }
}