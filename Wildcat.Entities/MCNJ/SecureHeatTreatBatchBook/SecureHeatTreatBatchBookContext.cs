using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook
{
    public partial class SecureHeatTreatBatchBookContext : DbContext
    {
        public SecureHeatTreatBatchBookContext()
        {
        }

        public SecureHeatTreatBatchBookContext(DbContextOptions<SecureHeatTreatBatchBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblDieCard> TblDieCard { get; set; }
        public virtual DbSet<TblHtacutal> TblHtacutal { get; set; }
        public virtual DbSet<TblHtbatchInfo> TblHtbatchInfo { get; set; }
        public virtual DbSet<TblHtoperations> TblHtoperations { get; set; }
        public virtual DbSet<TblMetRecords> TblMetRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=SecureHeatTreatBatchBook;user id=LoupeUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .IsClustered(false);

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<TblDieCard>(entity =>
            {
                entity.HasKey(e => e.DieNo)
                    .IsClustered(false);

                entity.Property(e => e.DieNo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bhn)
                    .HasColumnName("BHN")
                    .HasMaxLength(50);

                entity.Property(e => e.ForgingsPerTray)
                    .HasColumnName("Forgings Per Tray")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MatL)
                    .HasColumnName("Mat'l")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasColumnType("ntext");

                entity.Property(e => e.SectionSize)
                    .HasColumnName("Section Size")
                    .HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);
            });

            modelBuilder.Entity<TblHtacutal>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("TblHTAcutal");

                entity.Property(e => e.AtTemp)
                    .HasColumnName("At Temp")
                    .HasMaxLength(50);

                entity.Property(e => e.Bhn)
                    .HasColumnName("BHN")
                    .HasMaxLength(20);

                entity.Property(e => e.CoolRate)
                    .HasColumnName("Cool Rate")
                    .HasMaxLength(5);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FceNo)
                    .HasColumnName("FCE No")
                    .HasMaxLength(50);

                entity.Property(e => e.HoldComplete)
                    .HasColumnName("Hold Complete")
                    .HasMaxLength(50);

                entity.Property(e => e.HoldTime)
                    .HasColumnName("Hold Time")
                    .HasMaxLength(15);

                entity.Property(e => e.NoPcs)
                    .HasColumnName("No Pcs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operation).HasMaxLength(15);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order No")
                    .HasMaxLength(50);

                entity.Property(e => e.QuenchRiseTemp).HasColumnName("Quench Rise Temp.");

                entity.Property(e => e.QuenchTempFinish).HasColumnName("Quench Temp Finish");

                entity.Property(e => e.QuenchTempStart).HasColumnName("Quench Temp Start");

                entity.Property(e => e.Temp).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblHtbatchInfo>(entity =>
            {
                entity.HasKey(e => e.RunKey)
                    .IsClustered(false);

                entity.ToTable("TblHTBatchInfo");

                entity.HasIndex(e => e.HeatCode)
                    .HasName("HeatCode");

                entity.HasIndex(e => e.RunKey)
                    .HasName("RunKey");

                entity.Property(e => e.BatchNo)
                    .HasColumnName("Batch No")
                    .HasMaxLength(50);

                entity.Property(e => e.Customer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cycle).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DieNo).HasMaxLength(50);

                entity.Property(e => e.Furnace).HasMaxLength(50);

                entity.Property(e => e.HeatCode).HasMaxLength(50);

                entity.Property(e => e.Htno)
                    .HasColumnName("HTNo")
                    .HasMaxLength(50);

                entity.Property(e => e.MatL)
                    .HasColumnName("Mat'l")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunTemp)
                    .HasColumnName("Run Temp")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeAtTemp)
                    .HasColumnName("Time at Temp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrder).HasMaxLength(50);
            });

            modelBuilder.Entity<TblHtoperations>(entity =>
            {
                entity.HasKey(e => e.OpKey)
                    .IsClustered(false);

                entity.ToTable("TblHTOperations");

                entity.HasIndex(e => e.OpKey)
                    .HasName("OpKey");

                entity.Property(e => e.DieNo).HasMaxLength(50);

                entity.Property(e => e.Furnace).HasMaxLength(50);

                entity.Property(e => e.HoldTime)
                    .HasColumnName("Hold Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Operation).HasMaxLength(50);

                entity.Property(e => e.PushTime)
                    .HasColumnName("Push Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Quench).HasMaxLength(50);

                entity.Property(e => e.Temperature).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zone).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMetRecords>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.HasIndex(e => e.OrderNo)
                    .HasName("IX_TblMetRecords");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved By")
                    .HasMaxLength(50);

                entity.Property(e => e.DieNo)
                    .HasColumnName("Die No")
                    .HasMaxLength(15);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No")
                    .HasMaxLength(15);

                entity.Property(e => e.QuantityRun)
                    .HasColumnName("Quantity Run")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuenchTempFinish)
                    .HasColumnName("Quench Temp Finish")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuenchTempStart)
                    .HasColumnName("Quench Temp Start")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SectionSize)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TestBars)
                    .HasColumnName("Test Bars")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalFurnaceTime)
                    .HasColumnName("Total Furnace Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Weight)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });
        }
    }
}
