using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentAdminPannel.Models
{
    [Table("tbl_category")]
    public class tbl_category
    {
        [Key]
        public long categoryid { get; set; }
        public string categoryname { get; set; }
        public string categorydescription { get; set; }
        public string entryby { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<byte> isactive { get; set; }
    }

    [Table("tbl_usermaster")]
    public class tbl_usermaster
    {
        [Key]
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
        public long fk_rollid { get; set; }
        public long fk_questionid { get; set; }
        public string answer { get; set; }
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<byte> isActive { get; set; }
    }
}