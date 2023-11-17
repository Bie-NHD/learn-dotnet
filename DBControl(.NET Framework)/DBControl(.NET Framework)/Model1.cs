using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DBControl_.NET_Framework_
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QuanLyBanHangModel")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
