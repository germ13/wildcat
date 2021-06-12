using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.MCNJ.DCR
{
    public partial class DCRContext : DbContext
    {
        public DCRContext()
        {
        }

        public DCRContext(DbContextOptions<DCRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SwitchboardItems> SwitchboardItems { get; set; }
        public virtual DbSet<TblDcr> TblDcr { get; set; }
        public virtual DbSet<TblEngineeringNames> TblEngineeringNames { get; set; }
        public virtual DbSet<TblInitiatorNames> TblInitiatorNames { get; set; }
        public virtual DbSet<TblUnit> TblUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=DCR;user id=LoupeUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SwitchboardItems>(entity =>
            {
                entity.HasKey(e => new { e.SwitchboardId, e.ItemNumber });

                entity.ToTable("Switchboard Items");

                entity.Property(e => e.SwitchboardId).HasColumnName("SwitchboardID");

                entity.Property(e => e.Argument).HasMaxLength(255);

                entity.Property(e => e.ItemText).HasMaxLength(255);
            });

            modelBuilder.Entity<TblDcr>(entity =>
            {
                entity.HasKey(e => e.Dcrnumber);

                entity.ToTable("tblDCR");

                entity.Property(e => e.Dcrnumber).HasColumnName("DCRNumber");

                entity.Property(e => e.DateRequired).HasMaxLength(11);

                entity.Property(e => e.DieShopSignature).HasMaxLength(25);

                entity.Property(e => e.DieShopSignatureDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EngApproval).HasMaxLength(3);

                entity.Property(e => e.EngApprovalDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EngApprovalSignature).HasMaxLength(25);

                entity.Property(e => e.HoldProductionYesOrNo).HasMaxLength(51);

                entity.Property(e => e.RequestedBy).HasMaxLength(25);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .IsRowVersion();

                entity.Property(e => e.ToolNumber).HasMaxLength(10);

                entity.Property(e => e.ToolsChangedYesOrNo).HasMaxLength(3);

                entity.Property(e => e.Unit).HasMaxLength(15);
            });

            modelBuilder.Entity<TblEngineeringNames>(entity =>
            {
                entity.HasKey(e => e.Names);

                entity.ToTable("tblEngineeringNames");

                entity.Property(e => e.Names)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblInitiatorNames>(entity =>
            {
                entity.HasKey(e => e.Names);

                entity.ToTable("tblInitiatorNames");

                entity.Property(e => e.Names)
                    .HasMaxLength(25)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblUnit>(entity =>
            {
                entity.HasKey(e => e.Sphammer);

                entity.ToTable("tblUnit");

                entity.Property(e => e.Sphammer)
                    .HasColumnName("SPHammer")
                    .HasMaxLength(17)
                    .ValueGeneratedNever();
            });
        }
    }
}
