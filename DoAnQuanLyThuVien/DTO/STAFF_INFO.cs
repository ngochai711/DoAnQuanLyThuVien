//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnQuanLyThuVien.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class STAFF_INFO
    {
        public int PIN { get; set; }
        public string ID { get; set; }
        public string NAME { get; set; }
        public string SEX { get; set; }
        public Nullable<System.DateTime> BIRTHDATE { get; set; }
        public Nullable<byte> AGE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string EMAIL { get; set; }
        public Nullable<bool> POSITION { get; set; }
    
        public virtual STAFF_ACCOUNT STAFF_ACCOUNT { get; set; }
    }
}
