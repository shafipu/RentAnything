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
    
    public partial class tbl_packagedetails
    {
        public long packagedetaildid { get; set; }
        public Nullable<long> fk_packageid { get; set; }
        public string featurename { get; set; }
        public string featuredescription { get; set; }
        public Nullable<byte> isactive { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public string entryby { get; set; }
    }
}