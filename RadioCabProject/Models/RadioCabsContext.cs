using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RadioCabProject.Models
{
    public partial class RadioCabsContext : IdentityDbContext<RadioCabsUser, IdentityRole, string>
    {
        public RadioCabsContext(DbContextOptions<RadioCabsContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-PVJST0I\\SQLEXPRESS;Database=RadioCabsDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Add this line to ensure the base class configuration is included

           

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasKey(e => e.AdvertisementId).HasName("PK__Advertis__C4C7F42DC8DD2011");

                entity.Property(e => e.AdvertisementId).HasColumnName("AdvertisementID");
                entity.Property(e => e.Address).HasMaxLength(255);
                entity.Property(e => e.CompanyName).HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.Designation).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.FaxNumber).HasMaxLength(15);
                entity.Property(e => e.Mobile).HasMaxLength(15);
                entity.Property(e => e.PaymentType).HasMaxLength(50);
                entity.Property(e => e.Telephone).HasMaxLength(15);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId).HasName("PK__Companie__2D971C4C1BC291ED");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
                entity.Property(e => e.Address).HasMaxLength(255);
                entity.Property(e => e.CompanyName).HasMaxLength(100);
                entity.Property(e => e.ContactPerson).HasMaxLength(100);
                entity.Property(e => e.Designation).HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.FaxNumber).HasMaxLength(15);
                entity.Property(e => e.MembershipType).HasMaxLength(50);
                entity.Property(e => e.Mobile).HasMaxLength(15);
                entity.Property(e => e.Password).HasMaxLength(100);
                entity.Property(e => e.PaymentType).HasMaxLength(50);
                entity.Property(e => e.Telephone).HasMaxLength(15);
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => e.DriverId).HasName("PK__Drivers__F1B1CD244E1D6030");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");
                entity.Property(e => e.Address).HasMaxLength(255);
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.ContactPerson).HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.DriverName).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Mobile).HasMaxLength(15);
                entity.Property(e => e.Password).HasMaxLength(100);
                entity.Property(e => e.PaymentType).HasMaxLength(50);
                entity.Property(e => e.Telephone).HasMaxLength(15);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId).HasName("PK__Feedback__6A4BEDF60979BE54");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.MobileNo).HasMaxLength(15);
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.HasKey(e => e.MembershipId).HasName("PK__Membersh__92A785994226F4E0");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");
                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.MembershipType).HasMaxLength(50);
                entity.Property(e => e.MonthlyFee).HasColumnType("decimal(10, 2)");
                entity.Property(e => e.QuarterlyFee).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
