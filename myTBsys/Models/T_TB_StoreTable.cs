//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace myTBsys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_TB_StoreTable
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<int> YudingNum { get; set; }
        public int State { get; set; }
    
        public virtual T_SH_Class T_SH_Class { get; set; }
        public virtual T_TB_Books T_TB_Books { get; set; }
        public virtual T_TB_TeachingTask T_TB_TeachingTask { get; set; }
    }
}
