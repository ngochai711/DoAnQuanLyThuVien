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
    
    public partial class CLIENT_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT_INFO()
        {
            this.REQUEST_FORM = new HashSet<REQUEST_FORM>();
        }
    
        public string ID { get; set; }
        public string NAME { get; set; }
        public string SEX { get; set; }
        public byte AGE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUEST_FORM> REQUEST_FORM { get; set; }
    }
}
