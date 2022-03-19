using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASP.NET
{
    public partial class donationEntities : DbContext
    {
        public donationEntities()
            : base("name=donationEntities")
        {
        }

        public virtual DbSet<good> goods { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<user>()
                .HasMany(e => e.goods)
                .WithRequired(e => e.user1)
                .HasForeignKey(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
