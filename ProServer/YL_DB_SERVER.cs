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
    
    public partial class YL_DB_SERVER
    {
        public int ID { get; set; }
        public int DB_TYPE_ID { get; set; }
        public string TYPE { get; set; }
        public string IP { get; set; }
        public int PORT { get; set; }
        public string DBNAME { get; set; }
        public string DBUID { get; set; }
        public string PASSWORD { get; set; }
        public string REMARK { get; set; }
        public string DB_LINK { get; set; }
        public string NICKNAME { get; set; }
        public string TO_PATH_M { get; set; }
        public string TO_PATH_D { get; set; }
    
        public virtual YL_DB_SERVER_TYPE YL_DB_SERVER_TYPE { get; set; }
    }
}
