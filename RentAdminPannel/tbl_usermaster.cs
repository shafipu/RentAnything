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
    
    public partial class tbl_usermaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_usermaster()
        {
            this.tbl_product = new HashSet<tbl_product>();
        }
    
        public long userid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<byte> isActive { get; set; }
        public Nullable<long> fk_rollid { get; set; }
        public Nullable<long> fk_questionid { get; set; }
        public string answer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_product> tbl_product { get; set; }
        public virtual tbl_questionmaster tbl_questionmaster { get; set; }
        public virtual tbl_rollmaster tbl_rollmaster { get; set; }
    }
}
