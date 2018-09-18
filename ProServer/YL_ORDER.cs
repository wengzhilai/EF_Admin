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
    
    public partial class YL_ORDER
    {
        public YL_ORDER()
        {
            this.YL_ORDER_FLOW = new HashSet<YL_ORDER_FLOW>();
        }
    
        public int ID { get; set; }
        public int CAR_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public string ORDER_NO { get; set; }
        public string ORDER_TYPE { get; set; }
        public string PAY_STATUS { get; set; }
        public Nullable<System.DateTime> PAY_STATUS_TIME { get; set; }
        public Nullable<decimal> COST { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public string LANG { get; set; }
        public string LAT { get; set; }
        public Nullable<int> APPRAISE_SCORE { get; set; }
        public string APPRAISE_CONTENT { get; set; }
        public string REMARK { get; set; }
        public int VITAL { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> STATUS_TIME { get; set; }
    
        public virtual YL_CAR YL_CAR { get; set; }
        public virtual YL_CLIENT YL_CLIENT { get; set; }
        public virtual ICollection<YL_ORDER_FLOW> YL_ORDER_FLOW { get; set; }
        public virtual YL_ORDER_INSURE YL_ORDER_INSURE { get; set; }
        public virtual YL_ORDER_RESCUE YL_ORDER_RESCUE { get; set; }
    }
}