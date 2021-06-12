using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.Grinders.FGX
{
    public partial class FGXContext : DbContext
    {
        public FGXContext()
        {
        }

        public FGXContext(DbContextOptions<FGXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TFgx> TFgx { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Duncan\\datacollection;Database=FGX;user id=DC_User;password=DC_Userpwd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TFgx>(entity =>
            {
                entity.ToTable("tFGX");

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
