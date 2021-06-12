using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcContext : DbContext
    {
        public SawCalcContext()
        {
        }

        public SawCalcContext(DbContextOptions<SawCalcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SawCalcAlloys> SawCalcAlloys { get; set; }
        public virtual DbSet<SawCalcAvailableTpis> SawCalcAvailableTpis { get; set; }
        public virtual DbSet<SawCalcBillets> SawCalcBillets { get; set; }
        public virtual DbSet<SawCalcBlades> SawCalcBlades { get; set; }
        public virtual DbSet<SawCalcComputers> SawCalcComputers { get; set; }
        public virtual DbSet<SawCalcExceptionReasons> SawCalcExceptionReasons { get; set; }
        public virtual DbSet<SawCalcGlobalSettings> SawCalcGlobalSettings { get; set; }
        public virtual DbSet<SawCalcInventoryBillets> SawCalcInventoryBillets { get; set; }
        public virtual DbSet<SawCalcMaintenanceRequests> SawCalcMaintenanceRequests { get; set; }
        public virtual DbSet<SawCalcMaterialMultReserves> SawCalcMaterialMultReserves { get; set; }
        public virtual DbSet<SawCalcMaterialReserves> SawCalcMaterialReserves { get; set; }
        public virtual DbSet<SawCalcMaterials> SawCalcMaterials { get; set; }
        public virtual DbSet<SawCalcPendingAlerts> SawCalcPendingAlerts { get; set; }
        public virtual DbSet<SawCalcPersons> SawCalcPersons { get; set; }
        public virtual DbSet<SawCalcPieces> SawCalcPieces { get; set; }
        public virtual DbSet<SawCalcRetiredBladeReasons> SawCalcRetiredBladeReasons { get; set; }
        public virtual DbSet<SawCalcSaws> SawCalcSaws { get; set; }
        public virtual DbSet<SawCalcScheduleItems> SawCalcScheduleItems { get; set; }
        public virtual DbSet<SawCalcShapeDimensionSets> SawCalcShapeDimensionSets { get; set; }
        public virtual DbSet<SawCalcShapeMeasurements> SawCalcShapeMeasurements { get; set; }
        public virtual DbSet<SawCalcShopOrderBillets> SawCalcShopOrderBillets { get; set; }
        public virtual DbSet<SawCalcShopOrderHeatAndBilletNumbers> SawCalcShopOrderHeatAndBilletNumbers { get; set; }
        public virtual DbSet<SawCalcShopOrderMultRequests> SawCalcShopOrderMultRequests { get; set; }
        public virtual DbSet<SawCalcShopOrders> SawCalcShopOrders { get; set; }
        public virtual DbSet<SawCalcShopOrderSavedStates> SawCalcShopOrderSavedStates { get; set; }
        public virtual DbSet<SawCalcShopOrderSerialNumbers> SawCalcShopOrderSerialNumbers { get; set; }
        public virtual DbSet<SawCalcTotalCutWeight> SawCalcTotalCutWeight { get; set; }
        public virtual DbSet<SawCalcTpiRestrictions> SawCalcTpiRestrictions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"server=WGFC-DEV-SQL01,1433;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;");
            }

            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("server=WGCFSQL;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SawCalcAlloys>(entity =>
            {
                entity.HasKey(e => e.AlloyId);

                entity.ToTable("SawCalc_Alloys");

                entity.HasIndex(e => e.AlloyName)
                    .HasName("IX_AlloyName")
                    .IsUnique();

                entity.Property(e => e.AlloyId).HasColumnName("AlloyID");

                entity.Property(e => e.AlloyName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcAvailableTpis>(entity =>
            {
                entity.HasKey(e => e.TpiId);

                entity.ToTable("SawCalc_AvailableTpis");

                entity.Property(e => e.TpiId).HasColumnName("TpiID");

                entity.Property(e => e.TpiDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcBillets>(entity =>
            {
                entity.HasKey(e => e.BilletId);

                entity.ToTable("SawCalc_Billets");

                entity.HasIndex(e => new { e.HeatNumber, e.BilletNumber })
                    .HasName("IX_HeatNumberBilletNumber")
                    .IsUnique();

                entity.Property(e => e.BilletId).HasColumnName("BilletID");

                entity.Property(e => e.BilletNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrossSectionShape)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeatNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SawCalcBillets)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Billets_Materials");
            });

            modelBuilder.Entity<SawCalcBlades>(entity =>
            {
                entity.HasKey(e => e.BladeId);

                entity.ToTable("SawCalc_Blades");

                entity.HasIndex(e => e.BladeName)
                    .HasName("IX_BladeName")
                    .IsUnique();

                entity.Property(e => e.BladeId).HasColumnName("BladeID");

                entity.Property(e => e.BladeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BladeType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RetiredBladeNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RetiredBladeReasonId).HasColumnName("RetiredBladeReasonID");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TpiDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.HasOne(d => d.RetiredBladeReason)
                    .WithMany(p => p.SawCalcBlades)
                    .HasForeignKey(d => d.RetiredBladeReasonId)
                    .HasConstraintName("FK_Blades_RetiredBladeReasons");
            });

            modelBuilder.Entity<SawCalcComputers>(entity =>
            {
                entity.HasKey(e => e.ComputerId);

                entity.ToTable("SawCalc_Computers");

                entity.HasIndex(e => e.ComputerName)
                    .HasName("IX_ComputerName")
                    .IsUnique();

                entity.Property(e => e.ComputerId).HasColumnName("ComputerID");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SawId).HasColumnName("SawID");

                entity.HasOne(d => d.Saw)
                    .WithMany(p => p.SawCalcComputers)
                    .HasForeignKey(d => d.SawId)
                    .HasConstraintName("FK_Computers_Saws");
            });

            modelBuilder.Entity<SawCalcExceptionReasons>(entity =>
            {
                entity.HasKey(e => e.ExceptionReasonId);

                entity.ToTable("SawCalc_ExceptionReasons");

                entity.HasIndex(e => e.ExceptionReasonDescription)
                    .HasName("IX_ExceptionReasonDescription")
                    .IsUnique();

                entity.Property(e => e.ExceptionReasonId).HasColumnName("ExceptionReasonID");

                entity.Property(e => e.ExceptionReasonDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SawCalcGlobalSettings>(entity =>
            {
                entity.HasKey(e => e.GlobalSettingId);

                entity.ToTable("SawCalc_GlobalSettings");

                entity.Property(e => e.GlobalSettingId)
                    .HasColumnName("GlobalSettingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PercentSawUtilization).HasDefaultValueSql("((65))");

                entity.Property(e => e.TimePerDayHours).HasDefaultValueSql("((20))");
            });

            modelBuilder.Entity<SawCalcInventoryBillets>(entity =>
            {
                entity.HasKey(e => e.InventoryBilletId);

                entity.ToTable("SawCalc_InventoryBillets");

                entity.HasIndex(e => new { e.HeatNumber, e.BilletNumber })
                    .HasName("IX_HeatNumberBilletNumber");

                entity.Property(e => e.InventoryBilletId).HasColumnName("InventoryBilletID");

                entity.Property(e => e.BilletNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.HeatNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mill)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcMaintenanceRequests>(entity =>
            {
                entity.HasKey(e => e.MaintenanceRequestId);

                entity.ToTable("SawCalc_MaintenanceRequests");

                entity.Property(e => e.MaintenanceRequestId).HasColumnName("MaintenanceRequestID");

                entity.Property(e => e.BladeId).HasColumnName("BladeID");

                entity.Property(e => e.ComputerId).HasColumnName("ComputerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.Responder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SawId).HasColumnName("SawID");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.HasOne(d => d.Blade)
                    .WithMany(p => p.SawCalcMaintenanceRequests)
                    .HasForeignKey(d => d.BladeId)
                    .HasConstraintName("FK_MaintenanceRequests_Blades");

                entity.HasOne(d => d.Computer)
                    .WithMany(p => p.SawCalcMaintenanceRequests)
                    .HasForeignKey(d => d.ComputerId)
                    .HasConstraintName("FK_MaintenanceRequests_Computers");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.SawCalcMaintenanceRequests)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_MaintenanceRequests_Persons");

                entity.HasOne(d => d.Saw)
                    .WithMany(p => p.SawCalcMaintenanceRequests)
                    .HasForeignKey(d => d.SawId)
                    .HasConstraintName("FK_MaintenanceRequests_Saws");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcMaintenanceRequests)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_MaintenanceRequests_ShopOrders");
            });

            modelBuilder.Entity<SawCalcMaterialMultReserves>(entity =>
            {
                entity.HasKey(e => e.MaterialMultReserveId);

                entity.ToTable("SawCalc_MaterialMultReserves");

                entity.HasIndex(e => e.MaterialReserveId)
                    .HasName("IX_MaterialReserveID");

                entity.Property(e => e.MaterialMultReserveId).HasColumnName("MaterialMultReserveID");

                entity.Property(e => e.MaterialReserveId).HasColumnName("MaterialReserveID");

                entity.HasOne(d => d.MaterialReserve)
                    .WithMany(p => p.SawCalcMaterialMultReserves)
                    .HasForeignKey(d => d.MaterialReserveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SawCalc_MaterialMultReserves_SawCalc_MaterialReserves");
            });

            modelBuilder.Entity<SawCalcMaterialReserves>(entity =>
            {
                entity.HasKey(e => e.MaterialReserveId);

                entity.ToTable("SawCalc_MaterialReserves");

                entity.HasIndex(e => e.ShopOrderNumber)
                    .HasName("IX_ShopOrderNumber");

                entity.HasIndex(e => new { e.HeatNumber, e.BilletNumber })
                    .HasName("IX_HeatNumberBilletNumber");

                entity.Property(e => e.MaterialReserveId).HasColumnName("MaterialReserveID");

                entity.Property(e => e.BilletNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeatNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShopOrderNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcMaterials>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.ToTable("SawCalc_Materials");

                entity.HasIndex(e => e.MaterialName)
                    .HasName("IX_MaterialName")
                    .IsUnique();

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.AlloyId).HasColumnName("AlloyID");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Alloy)
                    .WithMany(p => p.SawCalcMaterials)
                    .HasForeignKey(d => d.AlloyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Materials_Alloys");
            });

            modelBuilder.Entity<SawCalcPendingAlerts>(entity =>
            {
                entity.HasKey(e => e.PendingAlertId);

                entity.ToTable("SawCalc_PendingAlerts");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserID");

                entity.Property(e => e.PendingAlertId).HasColumnName("PendingAlertID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcPersons>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("SawCalc_Persons");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcPieces>(entity =>
            {
                entity.HasKey(e => e.PieceId);

                entity.ToTable("SawCalc_Pieces");

                entity.HasIndex(e => e.BladeId)
                    .HasName("IX_BladeID");

                entity.HasIndex(e => e.CreatedDate)
                    .HasName("IX_CreatedDate");

                entity.HasIndex(e => e.MultSerialNumber)
                    .HasName("IX_MultSerialNumber");

                entity.HasIndex(e => e.OperatorId)
                    .HasName("IX_OperatorID");

                entity.HasIndex(e => e.ShopOrderId)
                    .HasName("IX_ShopOrderID");

                entity.Property(e => e.PieceId).HasColumnName("PieceID");

                entity.Property(e => e.BilletId).HasColumnName("BilletID");

                entity.Property(e => e.BladeId).HasColumnName("BladeID");

                entity.Property(e => e.ComputerId).HasColumnName("ComputerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionReasonId).HasColumnName("ExceptionReasonID");

                entity.Property(e => e.IssueCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.IssueNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IssueOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastMultSerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MultSerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.PeerOverrideId).HasColumnName("PeerOverrideID");

                entity.Property(e => e.SawId).HasColumnName("SawID");

                entity.Property(e => e.ShapeMeasurementId).HasColumnName("ShapeMeasurementID");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.HasOne(d => d.Billet)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.BilletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_Billets");

                entity.HasOne(d => d.Blade)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.BladeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_Blades");

                entity.HasOne(d => d.Computer)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.ComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_Computers");

                entity.HasOne(d => d.ExceptionReason)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.ExceptionReasonId)
                    .HasConstraintName("FK_Pieces_ExceptionReasons");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.SawCalcPiecesOperator)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_Persons");

                entity.HasOne(d => d.PeerOverride)
                    .WithMany(p => p.SawCalcPiecesPeerOverride)
                    .HasForeignKey(d => d.PeerOverrideId)
                    .HasConstraintName("FK_PiecesPeerOverride_Persons");

                entity.HasOne(d => d.Saw)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.SawId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_Saws");

                entity.HasOne(d => d.ShapeMeasurement)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.ShapeMeasurementId)
                    .HasConstraintName("FK_Pieces_ShapeMeasurements");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcPieces)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pieces_ShopOrders");
            });

            modelBuilder.Entity<SawCalcRetiredBladeReasons>(entity =>
            {
                entity.HasKey(e => e.RetiredBladeReasonId);

                entity.ToTable("SawCalc_RetiredBladeReasons");

                entity.HasIndex(e => e.RetiredBladeReasonDescription)
                    .HasName("IX_RetiredBladeReasonDescription")
                    .IsUnique();

                entity.Property(e => e.RetiredBladeReasonId).HasColumnName("RetiredBladeReasonID");

                entity.Property(e => e.RetiredBladeReasonDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SawCalcSaws>(entity =>
            {
                entity.HasKey(e => e.SawId);

                entity.ToTable("SawCalc_Saws");

                entity.HasIndex(e => e.SawName)
                    .HasName("IX_SawName")
                    .IsUnique();

                entity.Property(e => e.SawId).HasColumnName("SawID");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PerformanceFactor).HasDefaultValueSql("((1.0))");

                entity.Property(e => e.SawName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SawType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcScheduleItems>(entity =>
            {
                entity.HasKey(e => e.ScheduleItemId);

                entity.ToTable("SawCalc_ScheduleItems");

                entity.HasIndex(e => e.ShopOrderId)
                    .HasName("IX_ShopOrderID");

                entity.HasIndex(e => new { e.DateScheduled, e.SawId })
                    .HasName("IX_Date_Saw");

                entity.Property(e => e.ScheduleItemId).HasColumnName("ScheduleItemID");

                entity.Property(e => e.DateScheduled).HasColumnType("smalldatetime");

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.SawId).HasColumnName("SawID");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.SawCalcScheduleItems)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_SawCalc_ScheduleItems_SawCalc_Persons");

                entity.HasOne(d => d.Saw)
                    .WithMany(p => p.SawCalcScheduleItems)
                    .HasForeignKey(d => d.SawId)
                    .HasConstraintName("FK_SawCalc_ScheduleItems_SawCalc_Saws");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcScheduleItems)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_SawCalc_ScheduleItems_SawCalc_ShopOrders");
            });

            modelBuilder.Entity<SawCalcShapeDimensionSets>(entity =>
            {
                entity.HasKey(e => new { e.ShapeMeasurementId, e.SequenceNumber });

                entity.ToTable("SawCalc_ShapeDimensionSets");

                entity.Property(e => e.ShapeMeasurementId).HasColumnName("ShapeMeasurementID");

                entity.HasOne(d => d.ShapeMeasurement)
                    .WithMany(p => p.SawCalcShapeDimensionSets)
                    .HasForeignKey(d => d.ShapeMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShapeDimensionSets_ShapeMeasurements");
            });

            modelBuilder.Entity<SawCalcShapeMeasurements>(entity =>
            {
                entity.HasKey(e => e.ShapeMeasurementId);

                entity.ToTable("SawCalc_ShapeMeasurements");

                entity.Property(e => e.ShapeMeasurementId).HasColumnName("ShapeMeasurementID");

                entity.Property(e => e.CrossSectionShape)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcShopOrderBillets>(entity =>
            {
                entity.HasKey(e => new { e.ShopOrderId, e.BilletId });

                entity.ToTable("SawCalc_ShopOrderBillets");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.BilletId).HasColumnName("BilletID");

                entity.HasOne(d => d.Billet)
                    .WithMany(p => p.SawCalcShopOrderBillets)
                    .HasForeignKey(d => d.BilletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopOrderBillets_Billets");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcShopOrderBillets)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopOrderBillets_ShopOrders");
            });

            modelBuilder.Entity<SawCalcShopOrderHeatAndBilletNumbers>(entity =>
            {
                entity.HasKey(e => new { e.ShopOrderId, e.HeatNumber, e.BilletNumber });

                entity.ToTable("SawCalc_ShopOrderHeatAndBilletNumbers");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.HeatNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilletNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcShopOrderHeatAndBilletNumbers)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SawCalc_ShopOrderHeatAndBilletNumbers_SawCalc_ShopOrders");
            });

            modelBuilder.Entity<SawCalcShopOrderMultRequests>(entity =>
            {
                entity.HasKey(e => e.ShopOrderMultRequestId);

                entity.ToTable("SawCalc_ShopOrderMultRequests");

                entity.HasIndex(e => e.ShopOrderId)
                    .HasName("IX_ShopOrderID");

                entity.Property(e => e.ShopOrderMultRequestId).HasColumnName("ShopOrderMultRequestID");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcShopOrderMultRequests)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopOrderMultRequests_ShopOrders");
            });

            modelBuilder.Entity<SawCalcShopOrders>(entity =>
            {
                entity.HasKey(e => e.ShopOrderId);

                entity.ToTable("SawCalc_ShopOrders");

                entity.HasIndex(e => e.ShopOrderNumber)
                    .HasName("IX_ShopOrderNumber")
                    .IsUnique();

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.BilletShape)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Customer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuttingTicketStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ForgeDate).HasColumnType("datetime");

                entity.Property(e => e.LastCutDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.Mill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfRemainingPieces).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopOrderNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetWeights)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SawCalcShopOrders)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_SawCalc_ShopOrders_SawCalc_Materials");
            });

            modelBuilder.Entity<SawCalcShopOrderSavedStates>(entity =>
            {
                entity.HasKey(e => new { e.ShopOrderId, e.ComputerId });

                entity.ToTable("SawCalc_ShopOrderSavedStates");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.ComputerId).HasColumnName("ComputerID");

                entity.Property(e => e.BilletNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BladeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossSectionShape)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeatNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

                entity.Property(e => e.MultSerialNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SawName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShapeMeasurementId).HasColumnName("ShapeMeasurementID");

                entity.HasOne(d => d.Computer)
                    .WithMany(p => p.SawCalcShopOrderSavedStates)
                    .HasForeignKey(d => d.ComputerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopOrderSavedStates_Computers");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SawCalcShopOrderSavedStates)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_ShopOrderSavedStates_Materials");

                entity.HasOne(d => d.ShapeMeasurement)
                    .WithMany(p => p.SawCalcShopOrderSavedStates)
                    .HasForeignKey(d => d.ShapeMeasurementId)
                    .HasConstraintName("FK_ShopOrderSavedStates_ShapeMeasurements");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcShopOrderSavedStates)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopOrderSavedStates_ShopOrders");
            });

            modelBuilder.Entity<SawCalcShopOrderSerialNumbers>(entity =>
            {
                entity.HasKey(e => new { e.ShopOrderId, e.MultSerialNumber });

                entity.ToTable("SawCalc_ShopOrderSerialNumbers");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.MultSerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.SawCalcShopOrderSerialNumbers)
                    .HasForeignKey(d => d.ShopOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SawCalc_ShopOrderSerialNumbers_SawCalc_ShopOrders");
            });

            modelBuilder.Entity<SawCalcTotalCutWeight>(entity =>
            {
                entity.HasKey(e => new { e.ShopOrderNumber, e.LotNumber });

                entity.ToTable("SawCalc_TotalCutWeight");

                entity.Property(e => e.ShopOrderNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(41)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SawCalcTpiRestrictions>(entity =>
            {
                entity.HasKey(e => e.TpiRestrictionId);

                entity.ToTable("SawCalc_TpiRestrictions");

                entity.Property(e => e.TpiRestrictionId).HasColumnName("TpiRestrictionID");
            });
        }
    }
}
