using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.MCNJ.IDR
{
    public partial class IDRContext : DbContext
    {
        public IDRContext()
        {
        }

        public IDRContext(DbContextOptions<IDRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SwitchboardItems> SwitchboardItems { get; set; }
        public virtual DbSet<TblCustomerNames> TblCustomerNames { get; set; }
        public virtual DbSet<TblDiscrepancyTypes> TblDiscrepancyTypes { get; set; }
        public virtual DbSet<TblIdrdata> TblIdrdata { get; set; }
        public virtual DbSet<TblPreDispositionStatus> TblPreDispositionStatus { get; set; }

        // Unable to generate entity type for table 'dbo.Name AutoCorrect Save Failures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors6'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors7'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors8'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIDRData_ExportErrors9'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=IDR;user id=LoupeUser;password=Password123!;");
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

            modelBuilder.Entity<TblCustomerNames>(entity =>
            {
                entity.HasKey(e => e.CustomerName);

                entity.ToTable("tblCustomerNames");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblDiscrepancyTypes>(entity =>
            {
                entity.HasKey(e => e.DiscrepancyTypes);

                entity.ToTable("tblDiscrepancyTypes");

                entity.Property(e => e.DiscrepancyTypes)
                    .HasMaxLength(30)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblIdrdata>(entity =>
            {
                entity.HasKey(e => e.Idrnumber);

                entity.ToTable("tblIDRData");

                entity.HasIndex(e => e.HeatCode)
                    .HasName("tblIDRData$HeatCode");

                entity.HasIndex(e => e.Idrcost)
                    .HasName("tblIDRData$IDRCost");

                entity.Property(e => e.Idrnumber).HasColumnName("IDRNumber");

                entity.Property(e => e.AdditionalTestForInfo).HasColumnType("money");

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime2(0)");

                entity.Property(e => e.DieNumber).HasMaxLength(255);

                entity.Property(e => e.DiscrepancyType1).HasMaxLength(255);

                entity.Property(e => e.DiscrepancyType2).HasMaxLength(255);

                entity.Property(e => e.DollarsSubmitted).HasColumnType("money");

                entity.Property(e => e.FinalDisposition).HasMaxLength(255);

                entity.Property(e => e.FinalDispositionBy).HasMaxLength(255);

                entity.Property(e => e.FinalDispositionDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.HeatCode).HasMaxLength(255);

                entity.Property(e => e.Idrcost)
                    .HasColumnName("IDRCost")
                    .HasColumnType("money");

                entity.Property(e => e.Initiator).HasMaxLength(255);

                entity.Property(e => e.LaborOverheadCost).HasColumnType("money");

                entity.Property(e => e.LostSales).HasColumnType("money");

                entity.Property(e => e.MaterialCost).HasColumnType("money");

                entity.Property(e => e.MrbdispositionDate)
                    .HasColumnName("MRBDispositionDate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MrbsubmittalDate)
                    .HasColumnName("MRBSubmittalDate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MrbsubmittalNumber)
                    .HasColumnName("MRBSubmittalNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.MrbsubmittalQuantity).HasColumnName("MRBSubmittalQuantity");

                entity.Property(e => e.Operation).HasMaxLength(255);

                entity.Property(e => e.PreDispositionStatus).HasMaxLength(255);

                entity.Property(e => e.ReplacementTestCost).HasColumnType("money");

                entity.Property(e => e.RetestCost).HasColumnType("money");

                entity.Property(e => e.ReworkCost).HasColumnType("money");

                entity.Property(e => e.ScrapCost).HasColumnType("money");

                entity.Property(e => e.SerialNumbers).HasMaxLength(255);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .IsRowVersion();

                entity.Property(e => e.SubmittalCost).HasColumnType("money");

                entity.Property(e => e.TotalIdrcost)
                    .HasColumnName("TotalIDRCost")
                    .HasColumnType("money");

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.Property(e => e.UnitSellPrice).HasColumnType("money");

                entity.Property(e => e.WorkOrderNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<TblPreDispositionStatus>(entity =>
            {
                entity.HasKey(e => e.PreDispositionStatus);

                entity.ToTable("tblPreDispositionStatus");

                entity.Property(e => e.PreDispositionStatus)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });
        }
    }
}
