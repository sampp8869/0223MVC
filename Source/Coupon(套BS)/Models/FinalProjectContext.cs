using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Coupon.Models
{
    public partial class FinalProjectContext : DbContext
    {
        public FinalProjectContext()
        {
        }

        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCoupon> TCoupons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(" Data Source=.;Initial Catalog=FinalProject;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCoupon>(entity =>
            {
                entity.HasKey(e => e.FCode)
                    .HasName("PK_tCoupon_1");

                entity.ToTable("tCoupon");

                entity.Property(e => e.FCode)
                    .HasMaxLength(10)
                    .HasColumnName("fCode");

                entity.Property(e => e.FAvailableTimes).HasColumnName("fAvailableTimes");

                entity.Property(e => e.FEndDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fEndDate");

                entity.Property(e => e.FRatio).HasColumnName("fRatio");

                entity.Property(e => e.FSid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fSID");

                entity.Property(e => e.FStartDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fStartDate");

                entity.Property(e => e.FUsedTimes).HasColumnName("fUsedTimes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
