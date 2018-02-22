using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentAdminPannel.Models
{
    public class RentAdminPannelContext : DbContext
    { 
        public System.Data.Entity.DbSet<tbl_category> tbl_category { get; set; }
        public System.Data.Entity.DbSet<tbl_usermaster> tbl_usermaster { get; set; }

        //public System.Data.Entity.DbSet<tbl_subcategory> tbl_subcategory { get; set; }

    }
}
