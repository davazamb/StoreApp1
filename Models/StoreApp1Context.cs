using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models
{
    public class StoreApp1Context : DbContext
    {
        public StoreApp1Context() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Models.Department> Departments { get; set; }
    }
}