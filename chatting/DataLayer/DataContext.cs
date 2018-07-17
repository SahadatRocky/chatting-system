using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Room> rooms{ get; set; }

    }
}