using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.Grinders.Wildcat
{
    public partial class SHCAEngineeringContext : DbContext
    {
        public SHCAEngineeringContext()
        {
        }

        public SHCAEngineeringContext(DbContextOptions<SHCAEngineeringContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GrinderData> GrinderData { get; set; }

        // Unable to generate entity type for table 'dbo.QueryFGA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGQ'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryFGD6'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=SHCAEngineering;user id=WildcatUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GrinderData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareId).HasColumnName("kepwareId");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid)
                    .HasColumnName("_NUMERICID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Property)
                    .HasColumnName("_PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
