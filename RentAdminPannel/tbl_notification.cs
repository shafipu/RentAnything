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
    
    public partial class tbl_notification
    {
        public long notificationid { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string context { get; set; }
        public string priority { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<long> fk_userid { get; set; }
    }
}
