using Microsoft.EntityFrameworkCore;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class TechnicalTestDBContext : DbContext
    {
        public TechnicalTestDBContext()
        {
        }

        public TechnicalTestDBContext(DbContextOptions<TechnicalTestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Tech> Tech { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "master");

                entity.HasIndex(e => e.CountryCodeIso2)
                    .HasName("PK_master_Country_CountryCodeISO2")
                    .IsUnique();

                entity.HasIndex(e => e.CountryCodeIso3)
                    .HasName("PK_master_Country_CountryCodeISO3")
                    .IsUnique();

                entity.HasIndex(e => e.CountryName)
                    .HasName("PK_master_Country_CountryName")
                    .IsUnique();

                entity.Property(e => e.CountryCallingCode).HasMaxLength(8);

                entity.Property(e => e.CountryCodeIso2)
                    .HasColumnName("CountryCodeISO2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryCodeIso3)
                    .HasColumnName("CountryCodeISO3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Translations).IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('dba')");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_master_Country_CurrencyId");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency", "master");

                entity.HasIndex(e => e.CurrencyName)
                    .HasName("UK_master_Currency_CurrencyName")
                    .IsUnique();

                entity.Property(e => e.CurrencyIso)
                    .IsRequired()
                    .HasColumnName("CurrencyISO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(10);

                entity.Property(e => e.Translations).IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('dba')");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.ProjectCode)
                    .HasName("UK_dbo_Project_ProjectCode")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectName)
                    .HasName("UK_dbo_Project_ProjectName")
                    .IsUnique();

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('dba')");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo_Project_CountryId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_dbo_Project_StateId");

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.TechId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_Project_TechId");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "master");

                entity.Property(e => e.StateCodeIso2)
                    .HasColumnName("StateCodeISO2")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateCodeIso3)
                    .HasColumnName("StateCodeISO3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Translations).IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('dba')");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_master_State_CountryId");
            });

            modelBuilder.Entity<Tech>(entity =>
            {
                entity.ToTable("Tech", "master");

                entity.Property(e => e.TechName).HasMaxLength(50);

                entity.Property(e => e.TechShortName).HasMaxLength(20);

                entity.Property(e => e.Translations).IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdateUserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('dba')");
            });
        }
    }
}