//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LGI.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class T_mq_log
    {
        public int F_id { get; set; }
        public string dateTime { get; set; }
        public string GUID { get; set; }
        public string sm { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string msgid { get; set; }
        public string flag { get; set; }
        public string xmls { get; set; }
        public string bz { get; set; }
        public string msg { get; set; }
        public Nullable<int> F_FSCS { get; set; }
    }
}
