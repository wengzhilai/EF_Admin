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
    
    public partial class YL_ORDER_INSURE_PRODUCT
    {
        public int INSURER_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int INSURE_ID { get; set; }
        public string MAX_PAY { get; set; }
        public Nullable<decimal> COST { get; set; }
    
        public virtual YL_INSURER YL_INSURER { get; set; }
        public virtual YL_INSURER_PRODUCT YL_INSURER_PRODUCT { get; set; }
        public virtual YL_ORDER_INSURE YL_ORDER_INSURE { get; set; }
    }
}
