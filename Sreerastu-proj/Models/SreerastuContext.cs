using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class SreerastuContext : DbContext
    {
        public SreerastuContext()
        {
        }

        public SreerastuContext(DbContextOptions<SreerastuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCustomerRegistration> TblCustomerRegistration { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblSubscriptionType> TblSubscriptionType { get; set; }
        public virtual DbSet<TblUserType> TblUserType { get; set; }
        public virtual DbSet<TblVendorCategory> TblVendorCategory { get; set; }
        public virtual DbSet<TblVendorRegistration> TblVendorRegistration { get; set; }
        public virtual DbSet<TblVendorStatus> TblVendorStatus { get; set; }
        public virtual DbSet<TblVendorType> TblVendorType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-R01AGT3\\SQLEXPRESS;Database=Sreerastu;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCustomerRegistration>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__TBL_Cust__A4AE64B8D3359C3A");

                entity.ToTable("TBL_CustomerRegistration");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFname)
                    .HasColumnName("CustomerFName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLname)
                    .HasColumnName("CustomerLName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__TBL_Empl__AF2DBA79266A8A3A");

                entity.ToTable("TBL_Employee");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpDob)
                    .HasColumnName("EmpDOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("EmpFName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLname)
                    .HasColumnName("EmpLName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSubscriptionType>(entity =>
            {
                entity.HasKey(e => e.SubscriptionTypeId)
                    .HasName("PK__TBL_Subs__AFE5EE884A95E428");

                entity.ToTable("TBL_SubscriptionType");

                entity.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");

                entity.Property(e => e.SubscriptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeId)
                    .HasName("PK__TBL_User__40D2D8F620029C58");

                entity.ToTable("TBL_UserType");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorCategory>(entity =>
            {
                entity.HasKey(e => e.VendorCategoryId)
                    .HasName("PK__TBL_Vend__1E72AB0A33CACEFC");

                entity.ToTable("TBL_VendorCategory");

                entity.Property(e => e.VendorCategoryId).HasColumnName("VendorCategoryID");

                entity.Property(e => e.VcategoryDescription)
                    .HasColumnName("VCategoryDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorRegistration>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__TBL_Vend__FC8618D3AC85E0F8");

                entity.ToTable("TBL_VendorRegistration");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AddressProof)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.BusinessLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessRegistrationDate).HasColumnType("date");

                entity.Property(e => e.BusinessStartedDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idproof)
                    .HasColumnName("IDProof")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleWorks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubscriptionExpiryDate).HasColumnType("date");

                entity.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");

                entity.Property(e => e.VendorBusinessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCategoryId).HasColumnName("VendorCategoryID");

                entity.Property(e => e.VendorPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorRegistrationDate).HasColumnType("date");

                entity.Property(e => e.VendorUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedDate).HasColumnType("date");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.TblVendorRegistrationApprovedByNavigation)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK__TBL_Vendo__Appro__33D4B598");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblVendorRegistration)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__TBL_Vendo__Statu__30F848ED");

                entity.HasOne(d => d.SubscriptionType)
                    .WithMany(p => p.TblVendorRegistration)
                    .HasForeignKey(d => d.SubscriptionTypeId)
                    .HasConstraintName("FK__TBL_Vendo__Subsc__31EC6D26");

                entity.HasOne(d => d.VendorCategory)
                    .WithMany(p => p.TblVendorRegistration)
                    .HasForeignKey(d => d.VendorCategoryId)
                    .HasConstraintName("FK__TBL_Vendo__Vendo__300424B4");

                entity.HasOne(d => d.VerifiedByNavigation)
                    .WithMany(p => p.TblVendorRegistrationVerifiedByNavigation)
                    .HasForeignKey(d => d.VerifiedBy)
                    .HasConstraintName("FK__TBL_Vendo__Verif__32E0915F");
            });

            modelBuilder.Entity<TblVendorStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__TBL_Vend__C8EE20437C73C694");

                entity.ToTable("TBL_VendorStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendorType>(entity =>
            {
                entity.HasKey(e => e.VendorTypeId)
                    .HasName("PK__TBL_Vend__54DFA28C81B3C0D0");

                entity.ToTable("TBL_VendorType");

                entity.Property(e => e.VendorTypeId).HasColumnName("VendorTypeID");

                entity.Property(e => e.VendorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
