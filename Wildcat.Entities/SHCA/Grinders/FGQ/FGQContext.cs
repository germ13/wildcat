using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.Grinders.FGQ
{
    public partial class FGQContext : DbContext
    {
        public FGQContext()
        {
        }

        public FGQContext(DbContextOptions<FGQContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TFgq> TFgq { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHCA-SQL01;Database=FGQ;user id=DC_User;password=DC_Userpwd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TFgq>(entity =>
            {
                entity.ToTable("tFGQ");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

                entity.Property(e => e.Quality).HasColumnName("_QUALITY");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("_TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("_VALUE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
