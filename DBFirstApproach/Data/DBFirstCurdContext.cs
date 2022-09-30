using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DBFirstApproach.Models;

namespace DBFirstApproach.Data
{
    public partial class DBFirstCurdContext : DbContext
    {
        public DBFirstCurdContext()
        {
        }

        public DBFirstCurdContext(DbContextOptions<DBFirstCurdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatageoryTable> CatageoryTable { get; set; }
        public virtual DbSet<CustomerTable> CustomerTable { get; set; }
        public virtual DbSet<ProductTable> ProductTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            if (!optionsBuilder.IsConfigured)
            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               optionsBuilder.UseSqlServer("server=localhost;database=DBFirstCurd;Integrated Security=true; Encrypt=false;");
           }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatageoryTable>(entity =>
            {
                entity.HasKey(e => e.CatCode);

                entity.ToTable("Catageory_Table");

                entity.Property(e => e.CatCode).ValueGeneratedNever();

                entity.Property(e => e.CatName).HasMaxLength(100);
            });

            modelBuilder.Entity<CustomerTable>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customer_Table");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LatName).HasMaxLength(100);

                entity.Property(e => e.PhoneNo).HasMaxLength(100);

                entity.Property(e => e.PhotoUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<ProductTable>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("Product_Table");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
