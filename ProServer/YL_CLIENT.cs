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
    
    public partial class YL_CLIENT
    {
        public YL_CLIENT()
        {
            this.YL_ORDER = new HashSet<YL_ORDER>();
            this.YL_CAR = new HashSet<YL_CAR>();
        }
    
        public int ID { get; set; }
        public string SEX { get; set; }
        public string ADDRESS { get; set; }
        public string STATUS { get; set; }
        public System.DateTime STATUS_TIME { get; set; }
        public string REMARK { get; set; }
        public int SALESMAN_ID { get; set; }
        public string ID_NO { get; set; }
        public Nullable<int> ID_NO_PIC_ID { get; set; }
        public Nullable<int> DRIVER_PIC_ID { get; set; }
        public Nullable<int> ID_NO_PIC_ID1 { get; set; }
        public Nullable<int> DRIVER_PIC_ID1 { get; set; }
    
        public virtual YL_SALESMAN YL_SALESMAN { get; set; }
        public virtual YL_USER YL_USER { get; set; }
        public virtual ICollection<YL_ORDER> YL_ORDER { get; set; }
        public virtual ICollection<YL_CAR> YL_CAR { get; set; }
    }
}
