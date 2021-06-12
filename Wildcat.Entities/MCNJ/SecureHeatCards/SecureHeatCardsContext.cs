using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.MCNJ.SecureHeatCards
{
    public partial class SecureHeatCardsContext : DbContext
    {
        public SecureHeatCardsContext()
        {
        }

        public SecureHeatCardsContext(DbContextOptions<SecureHeatCardsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Dies> Dies { get; set; }
        public virtual DbSet<RawMaterial> RawMaterial { get; set; }
        public virtual DbSet<TblHeatCard> TblHeatCard { get; set; }
        public virtual DbSet<TblPartType> TblPartType { get; set; }

        // Unable to generate entity type for table 'dbo.TblPartType'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=SecureHeatCards;user id=LoupeUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .IsClustered(false);

                entity.HasIndex(e => e.Name)
                    .HasName("Name1");

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(25);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(2);
            });

            modelBuilder.Entity<Dies>(entity =>
            {
                entity.HasKey(e => e.Die)
                    .IsClustered(false);

                entity.HasIndex(e => e.CustId)
                    .HasName("CustID");

                entity.HasIndex(e => e.CustomerPart)
                    .HasName("PartNum");

                entity.HasIndex(e => e.Die)
                    .HasName("Die");

                entity.Property(e => e.Die)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerPart)
                    .HasColumnName("CustomerPart #")
                    .HasMaxLength(25);

                entity.Property(e => e.Material).HasMaxLength(10);

                entity.Property(e => e.PartType).HasMaxLength(50);

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<RawMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialField)
                    .IsClustered(false);

                entity.ToTable("Raw material");

                entity.HasIndex(e => e.MaterialField)
                    .HasName("Material Field")
                    .IsUnique();

                entity.Property(e => e.MaterialField)
                    .HasColumnName("Material Field")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblHeatCard>(entity =>
            {
                entity.HasKey(e => e.Hcn);

                entity.HasIndex(e => e.HeatCode)
                    .HasName("Heat Code");

                entity.HasIndex(e => e.HeatNumber)
                    .HasName("Heat Number");

                entity.HasIndex(e => e.ShopOrderNumber)
                    .HasName("Shop Order Number");

                entity.Property(e => e.Hcn).HasColumnName("HCN");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DieNumber)
                    .HasColumnName("Die Number")
                    .HasMaxLength(50);

                entity.Property(e => e.HeatCode)
                    .HasColumnName("Heat Code")
                    .HasMaxLength(3);

                entity.Property(e => e.HeatNumber)
                    .HasColumnName("Heat Number")
                    .HasMaxLength(25);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.NucPrefix)
                    .HasColumnName("Nuc Prefix")
                    .HasMaxLength(4);

                entity.Property(e => e.QuantityOrderedCut)
                    .HasColumnName("Quantity Ordered & Cut")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Range).HasMaxLength(50);

                entity.Property(e => e.ShopOrderNumber)
                    .HasColumnName("Shop Order Number")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblPartType>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.HasIndex(e => e.PartType)
                    .HasName("PartType");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.PartType)
                    .HasColumnName("PartType")
                    .HasMaxLength(30);
            });
        }
    }
}
