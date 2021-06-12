using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.Grinders.FGD
{
    public partial class FGDContext : DbContext
    {
        public FGDContext()
        {
        }

        public FGDContext(DbContextOptions<FGDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TFgd11> TFgd11 { get; set; }
        public virtual DbSet<TFgd21> TFgd21 { get; set; }
        public virtual DbSet<TFgd31> TFgd31 { get; set; }
        public virtual DbSet<TFgd41> TFgd41 { get; set; }
        public virtual DbSet<TFgd51> TFgd51 { get; set; }
        public virtual DbSet<TFgd61> TFgd61 { get; set; }

        // Unable to generate entity type for table 'dbo.tFGD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_6'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tFGD_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHCA-SQL01;Database=FGD;user id=DC_User;password=DC_Userpwd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TFgd11>(entity =>
            {
                entity.ToTable("tFGD_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFgd21>(entity =>
            {
                entity.ToTable("tFGD_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFgd31>(entity =>
            {
                entity.ToTable("tFGD_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFgd41>(entity =>
            {
                entity.ToTable("tFGD_4");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFgd51>(entity =>
            {
                entity.ToTable("tFGD_5");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFgd61>(entity =>
            {
                entity.ToTable("tFGD_6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });
        }
    }
}
