//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentAdminPannel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_questionmaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_questionmaster()
        {
            this.tbl_usermaster = new HashSet<tbl_usermaster>();
        }
        [Key]
        public long questionid { get; set; }
        public string question { get; set; }
        public Nullable<byte> isActive { get; set; }
        public string entryby { get; set; }
        public Nullable<System.DateTime> enteydate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_usermaster> tbl_usermaster { get; set; }
    }
}
