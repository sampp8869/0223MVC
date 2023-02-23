﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject.Models
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

        public virtual DbSet<TCoupon> TCoupon { get; set; }
        public virtual DbSet<TCustomer> TCustomer { get; set; }
        public virtual DbSet<TCustomerOrderSheet> TCustomerOrderSheet { get; set; }
        public virtual DbSet<TGender> TGender { get; set; }
        public virtual DbSet<TManager> TManager { get; set; }
        public virtual DbSet<TOrderDetail> TOrderDetail { get; set; }
        public virtual DbSet<TPeriod> TPeriod { get; set; }
        public virtual DbSet<TProduct> TProduct { get; set; }
        public virtual DbSet<TProductReport> TProductReport { get; set; }
        public virtual DbSet<TProductReview> TProductReview { get; set; }
        public virtual DbSet<TProductsTag> TProductsTag { get; set; }
        public virtual DbSet<TProvider> TProvider { get; set; }
        public virtual DbSet<TPurchaseOrderSheet> TPurchaseOrderSheet { get; set; }
        public virtual DbSet<TShoppingCart> TShoppingCart { get; set; }
        public virtual DbSet<TTag> TTag { get; set; }

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

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tCustomer");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FBirthDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fBirthDate");

                entity.Property(e => e.FBlackList).HasColumnName("fBlackList");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fEmail");

                entity.Property(e => e.FFirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fFirstName");

                entity.Property(e => e.FGender).HasColumnName("fGender");

                entity.Property(e => e.FLastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fLastName");

                entity.Property(e => e.FLastUpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fLastUpdateDate");

                entity.Property(e => e.FMobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fMobile");

                entity.Property(e => e.FPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fPassword");

                entity.Property(e => e.FPoint).HasColumnName("fPoint");

                entity.Property(e => e.FRemark)
                    .HasMaxLength(255)
                    .HasColumnName("fRemark");

                entity.Property(e => e.FTel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fTel");

                entity.HasOne(d => d.FGenderNavigation)
                    .WithMany(p => p.TCustomer)
                    .HasForeignKey(d => d.FGender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomer_tGender1");
            });

            modelBuilder.Entity<TCustomerOrderSheet>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_tOrderSheet");

                entity.ToTable("tCustomerOrderSheet");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCheckedDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCheckedDate");

                entity.Property(e => e.FCouponCode)
                    .HasMaxLength(10)
                    .HasColumnName("fCouponCode");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FCustomerId).HasColumnName("fCustomerID");

                entity.HasOne(d => d.FCouponCodeNavigation)
                    .WithMany(p => p.TCustomerOrderSheet)
                    .HasForeignKey(d => d.FCouponCode)
                    .HasConstraintName("FK_tCustomerOrderSheet_tCoupon");

                entity.HasOne(d => d.FCustomer)
                    .WithMany(p => p.TCustomerOrderSheet)
                    .HasForeignKey(d => d.FCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerOrderSheet_tCustomer");
            });

            modelBuilder.Entity<TGender>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tGender");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("fDescription");
            });

            modelBuilder.Entity<TManager>(entity =>
            {
                entity.HasKey(e => e.FAccount)
                    .HasName("PK_tManager_1");

                entity.ToTable("tManager");

                entity.Property(e => e.FAccount)
                    .HasMaxLength(20)
                    .HasColumnName("fAccount");

                entity.Property(e => e.FPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fPassword");

                entity.Property(e => e.FSid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fSID");
            });

            modelBuilder.Entity<TOrderDetail>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tOrderDetail");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCustomerOrderSheetId).HasColumnName("fCustomerOrderSheetID");

                entity.Property(e => e.FProductId).HasColumnName("fProductID");

                entity.Property(e => e.FPurchaseQuantity).HasColumnName("fPurchaseQuantity");

                entity.HasOne(d => d.FCustomerOrderSheet)
                    .WithMany(p => p.TOrderDetail)
                    .HasForeignKey(d => d.FCustomerOrderSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderDetail_tCustomerOrderSheet");

                entity.HasOne(d => d.FProduct)
                    .WithMany(p => p.TOrderDetail)
                    .HasForeignKey(d => d.FProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderDetail_tProduct");
            });

            modelBuilder.Entity<TPeriod>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tPeriod");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("fDescription");
            });

            modelBuilder.Entity<TProduct>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tProduct");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FAssemblyPoint)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("fAssemblyPoint");

                entity.Property(e => e.FCost)
                    .HasColumnType("money")
                    .HasColumnName("fCost");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("fDescription");

                entity.Property(e => e.FEndDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fEndDate");

                entity.Property(e => e.FImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("fImagePath");

                entity.Property(e => e.FLastUpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fLastUpdateDate");

                entity.Property(e => e.FMaxParticipants).HasColumnName("fMaxParticipants");

                entity.Property(e => e.FMinParticipants).HasColumnName("fMinParticipants");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.FPeriodId).HasColumnName("fPeriodID");

                entity.Property(e => e.FPrice)
                    .HasColumnType("money")
                    .HasColumnName("fPrice");

                entity.Property(e => e.FProviderId).HasColumnName("fProviderID");

                entity.Property(e => e.FRemark)
                    .HasMaxLength(255)
                    .HasColumnName("fRemark");

                entity.Property(e => e.FRemoved).HasColumnName("fRemoved");

                entity.Property(e => e.FStartDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fStartDate");

                entity.Property(e => e.FStocks).HasColumnName("fStocks");

                entity.HasOne(d => d.FPeriod)
                    .WithMany(p => p.TProduct)
                    .HasForeignKey(d => d.FPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProduct_tPeriod");

                entity.HasOne(d => d.FProvider)
                    .WithMany(p => p.TProduct)
                    .HasForeignKey(d => d.FProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProduct_tProvider");
            });

            modelBuilder.Entity<TProductReport>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tProductReport");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FOrderDetailId).HasColumnName("fOrderDetailID");

                entity.Property(e => e.FReportContent)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("fReportContent");

                entity.HasOne(d => d.FOrderDetail)
                    .WithMany(p => p.TProductReport)
                    .HasForeignKey(d => d.FOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductReport_tOrderDetail");
            });

            modelBuilder.Entity<TProductReview>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tProductReview");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FOrderDetailId).HasColumnName("fOrderDetailID");

                entity.Property(e => e.FReviewContent)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("fReviewContent");

                entity.Property(e => e.FScore).HasColumnName("fScore");

                entity.HasOne(d => d.FOrderDetail)
                    .WithMany(p => p.TProductReview)
                    .HasForeignKey(d => d.FOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductReview_tOrderDetail");
            });

            modelBuilder.Entity<TProductsTag>(entity =>
            {
                entity.HasKey(e => e.FSid);

                entity.ToTable("tProductsTag");

                entity.Property(e => e.FSid).HasColumnName("fSID");

                entity.Property(e => e.FProductId).HasColumnName("fProductID");

                entity.Property(e => e.FTagId).HasColumnName("fTagID");

                entity.HasOne(d => d.FProduct)
                    .WithMany(p => p.TProductsTag)
                    .HasForeignKey(d => d.FProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductsTag_tProduct");

                entity.HasOne(d => d.FTag)
                    .WithMany(p => p.TProductsTag)
                    .HasForeignKey(d => d.FTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductsTag_tTag");
            });

            modelBuilder.Entity<TProvider>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tProvider");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fAddress");

                entity.Property(e => e.FBankAccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fBankAccountName");

                entity.Property(e => e.FBankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fBankAccountNumber");

                entity.Property(e => e.FBankDivisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fBankDivisionName");

                entity.Property(e => e.FBankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fBankName");

                entity.Property(e => e.FBlackList).HasColumnName("fBlackList");

                entity.Property(e => e.FCompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fCompanyName");

                entity.Property(e => e.FContactEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fContactEmail");

                entity.Property(e => e.FContactMobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fContactMobile");

                entity.Property(e => e.FContactName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("fContactName");

                entity.Property(e => e.FContactTel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fContactTel");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FFax)
                    .HasMaxLength(20)
                    .HasColumnName("fFax");

                entity.Property(e => e.FLastUpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fLastUpdateDate");

                entity.Property(e => e.FOwnerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fOwnerEmail");

                entity.Property(e => e.FOwnerMobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fOwnerMobile");

                entity.Property(e => e.FOwnerName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("fOwnerName");

                entity.Property(e => e.FOwnerTel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fOwnerTel");

                entity.Property(e => e.FPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fPassword");

                entity.Property(e => e.FRemark)
                    .HasMaxLength(255)
                    .HasColumnName("fRemark");

                entity.Property(e => e.FTaxId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("fTaxID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TPurchaseOrderSheet>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tPurchaseOrderSheet");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fCreationDate");

                entity.Property(e => e.FOrderDetailId).HasColumnName("fOrderDetailID");

                entity.HasOne(d => d.FOrderDetail)
                    .WithMany(p => p.TPurchaseOrderSheet)
                    .HasForeignKey(d => d.FOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseOrderSheet_tOrderDetail");
            });

            modelBuilder.Entity<TShoppingCart>(entity =>
            {
                entity.HasKey(e => e.FSid);

                entity.ToTable("tShoppingCart");

                entity.Property(e => e.FSid).HasColumnName("fSID");

                entity.Property(e => e.FAddDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fAddDate");

                entity.Property(e => e.FCustomerId).HasColumnName("fCustomerID");

                entity.Property(e => e.FProductId).HasColumnName("fProductID");

                entity.Property(e => e.FPurchaseQuantity).HasColumnName("fPurchaseQuantity");

                entity.HasOne(d => d.FCustomer)
                    .WithMany(p => p.TShoppingCart)
                    .HasForeignKey(d => d.FCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShoppingCart_tCustomer");

                entity.HasOne(d => d.FProduct)
                    .WithMany(p => p.TShoppingCart)
                    .HasForeignKey(d => d.FProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShoppingCart_tProduct");
            });

            modelBuilder.Entity<TTag>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tTag");

                entity.Property(e => e.FId)
                    .ValueGeneratedNever()
                    .HasColumnName("fID");

                entity.Property(e => e.FDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fDescription");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}