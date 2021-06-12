using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class ShultzBBxContext : DbContext
    {
        public ShultzBBxContext()
        {
        }

        public ShultzBBxContext(DbContextOptions<ShultzBBxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FinishedGoods> FinishedGoods { get; set; }
        public virtual DbSet<FiscalCalendar> FiscalCalendar { get; set; }
        public virtual DbSet<FiscalCalendar1> FiscalCalendar1 { get; set; }
        public virtual DbSet<FiscalHoliday> FiscalHoliday { get; set; }
        public virtual DbSet<FiscalHoliday1> FiscalHoliday1 { get; set; }
        public virtual DbSet<MachineCodeToFlexDepartment> MachineCodeToFlexDepartment { get; set; }
        public virtual DbSet<TA1vend> TA1vend { get; set; }
        public virtual DbSet<TA5tchk> TA5tchk { get; set; }
        public virtual DbSet<TA6mchk> TA6mchk { get; set; }
        public virtual DbSet<TableDetails> TableDetails { get; set; }
        public virtual DbSet<TableDetails1> TableDetails1 { get; set; }
        public virtual DbSet<TApDtl> TApDtl { get; set; }
        public virtual DbSet<TCustS> TCustS { get; set; }
        public virtual DbSet<TDlyshp> TDlyshp { get; set; }
        public virtual DbSet<TE1cust> TE1cust { get; set; }
        public virtual DbSet<TE2head01> TE2head01 { get; set; }
        public virtual DbSet<TE2head02> TE2head02 { get; set; }
        public virtual DbSet<TE3line> TE3line { get; set; }
        public virtual DbSet<TE4ref> TE4ref { get; set; }
        public virtual DbSet<TE5grad> TE5grad { get; set; }
        public virtual DbSet<TE6rep> TE6rep { get; set; }
        public virtual DbSet<TFcsmandata> TFcsmandata { get; set; }
        public virtual DbSet<TFcspriority> TFcspriority { get; set; }
        public virtual DbSet<TFcssched> TFcssched { get; set; }
        public virtual DbSet<TGDollarGCaretL> TGDollarGCaretL { get; set; }
        public virtual DbSet<TGDollarPst> TGDollarPst { get; set; }
        public virtual DbSet<TGDollarPstArchive> TGDollarPstArchive { get; set; }
        public virtual DbSet<TI1inv> TI1inv { get; set; }
        public virtual DbSet<TI2heat> TI2heat { get; set; }
        public virtual DbSet<TI2rsI> TI2rsI { get; set; }
        public virtual DbSet<TI2rsO> TI2rsO { get; set; }
        public virtual DbSet<TIdr2009> TIdr2009 { get; set; }
        public virtual DbSet<TIheatcd> TIheatcd { get; set; }
        public virtual DbSet<TJ3mach> TJ3mach { get; set; }
        public virtual DbSet<TLinuxuser> TLinuxuser { get; set; }
        public virtual DbSet<TMasttrav> TMasttrav { get; set; }
        public virtual DbSet<TMse6rep> TMse6rep { get; set; }
        public virtual DbSet<TMshead> TMshead { get; set; }
        public virtual DbSet<TMsi1inv> TMsi1inv { get; set; }
        public virtual DbSet<TMsline> TMsline { get; set; }
        public virtual DbSet<TMsspec> TMsspec { get; set; }
        public virtual DbSet<TMstrav> TMstrav { get; set; }
        public virtual DbSet<TocSpans> TocSpans { get; set; }
        public virtual DbSet<TOfctrav> TOfctrav { get; set; }
        public virtual DbSet<TP2opo> TP2opo { get; set; }
        public virtual DbSet<TPccPeriod> TPccPeriod { get; set; }
        public virtual DbSet<TPccperiod2> TPccperiod2 { get; set; }
        public virtual DbSet<TPcgraf> TPcgraf { get; set; }
        public virtual DbSet<TR1jnl> TR1jnl { get; set; }
        public virtual DbSet<TR2aCaretR> TR2aCaretR { get; set; }
        public virtual DbSet<TR5act> TR5act { get; set; }
        public virtual DbSet<TR5sls> TR5sls { get; set; }
        public virtual DbSet<TR7CaretJnl> TR7CaretJnl { get; set; }
        public virtual DbSet<TSeccheckProg> TSeccheckProg { get; set; }
        public virtual DbSet<TSeccheckUser> TSeccheckUser { get; set; }
        public virtual DbSet<TSjDtl> TSjDtl { get; set; }
        public virtual DbSet<TStar90008> TStar90008 { get; set; }
        public virtual DbSet<TStar901068> TStar901068 { get; set; }
        public virtual DbSet<TStar90184> TStar90184 { get; set; }
        public virtual DbSet<TStar90549> TStar90549 { get; set; }
        public virtual DbSet<TStar90551> TStar90551 { get; set; }
        public virtual DbSet<TStar90551t> TStar90551t { get; set; }
        public virtual DbSet<TStar91260> TStar91260 { get; set; }
        public virtual DbSet<TStar91325> TStar91325 { get; set; }
        public virtual DbSet<TStar92036> TStar92036 { get; set; }
        public virtual DbSet<TStar93551> TStar93551 { get; set; }
        public virtual DbSet<TTmopn> TTmopn { get; set; }
        public virtual DbSet<TToccur> TToccur { get; set; }
        public virtual DbSet<TTstrav> TTstrav { get; set; }

        // Unable to generate entity type for table 'dbo.t_ImportErrors'. Please see the warning messages.
        // Unable to generate entity type for table 'toc.TOC_Spans_Imp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TOC_MS_Steps'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.J3MACH_SNAPSHOT'. Please see the warning messages.
        // Unable to generate entity type for table 'dev.ImportErrors'. Please see the warning messages.
        // Unable to generate entity type for table 'staging.BOM_STG_TBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tTSTRAV_Detail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.J3MACH_SNAPSHOT_20200923'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHCA-SQL03;Database=ShultzBBx;user id=ShultzUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinishedGoods>(entity =>
            {
                entity.ToTable("FinishedGoods", "staging");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobNumber)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiscalCalendar>(entity =>
            {
                entity.HasKey(e => new { e.FiscalDate, e.PlantCode });

                entity.Property(e => e.FiscalDate).HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'SHCA')");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'system')");

                entity.Property(e => e.FiscalWeekday)
                    .HasMaxLength(30)
                    .HasComputedColumnSql("(datename(weekday,[FiscalDate]))");

                entity.Property(e => e.IsHoliday).HasComputedColumnSql("([dbo].[IsFiscalHoliday]([PlantCode],[FiscalDate]))");

                entity.Property(e => e.IsWorkday).HasComputedColumnSql("([dbo].[IsFiscalWorkday]([PlantCode],[FiscalDate]))");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Versioning).IsRowVersion();
            });

            modelBuilder.Entity<FiscalCalendar1>(entity =>
            {
                entity.HasKey(e => new { e.FiscalDate, e.PlantCode });

                entity.ToTable("FiscalCalendar", "dev");

                entity.Property(e => e.FiscalDate).HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'SHCA')");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'system')");

                entity.Property(e => e.FiscalWeekday).HasMaxLength(30);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Versioning).IsRowVersion();
            });

            modelBuilder.Entity<FiscalHoliday>(entity =>
            {
                entity.HasKey(e => new { e.FiscalDate, e.PlantCode });

                entity.ToTable("FiscalHoliday", "dev");

                entity.Property(e => e.FiscalDate).HasColumnType("datetime");

                entity.Property(e => e.PlantCode).HasMaxLength(4);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.Detail).HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Versioning)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<FiscalHoliday1>(entity =>
            {
                entity.HasKey(e => new { e.FiscalDate, e.PlantCode });

                entity.ToTable("FiscalHoliday");

                entity.Property(e => e.FiscalDate).HasColumnType("datetime");

                entity.Property(e => e.PlantCode).HasMaxLength(4);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.Detail).HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Versioning)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<MachineCodeToFlexDepartment>(entity =>
            {
                entity.HasKey(e => e.MachineCode);

                entity.Property(e => e.MachineCode)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Details).HasMaxLength(64);

                entity.Property(e => e.FlexDepartment)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.GlDepartment)
                    .IsRequired()
                    .HasColumnName("GL_Department")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<TA1vend>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tA1VEND");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIs1099).HasColumnName("bIs1099");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblPurchaseYtd)
                    .HasColumnName("dblPurchaseYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SContactEmail)
                    .HasColumnName("sContactEmail")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContactFaxNumber)
                    .HasColumnName("sContactFaxNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContactName)
                    .HasColumnName("sContactName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContactPhoneNumber)
                    .HasColumnName("sContactPhoneNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDiscountPercentage)
                    .HasColumnName("sDiscountPercentage")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty01)
                    .HasColumnName("sEmpty01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty02)
                    .HasColumnName("sEmpty02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLine01)
                    .HasColumnName("sLine01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLine02)
                    .HasColumnName("sLine02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLine03)
                    .HasColumnName("sLine03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen04)
                    .HasColumnName("sOpen04")
                    .HasMaxLength(1111);

                entity.Property(e => e.STaxPayerIdNumber)
                    .HasColumnName("sTaxPayerIdNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.STerms)
                    .HasColumnName("sTerms")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVendorNumber)
                    .HasColumnName("sVendorNumber")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TA5tchk>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tA5TCHK");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDiscount)
                    .HasColumnName("dblDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGross)
                    .HasColumnName("dblGross")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblNet)
                    .HasColumnName("dblNet")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCheckNumber)
                    .HasColumnName("sCheckNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SDue)
                    .HasColumnName("sDue")
                    .HasMaxLength(432);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SPreIssuedCheckCode)
                    .HasColumnName("sPreIssuedCheckCode")
                    .HasMaxLength(432);

                entity.Property(e => e.SReturnCode)
                    .HasColumnName("sReturnCode")
                    .HasMaxLength(432);

                entity.Property(e => e.STime)
                    .HasColumnName("sTime")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorAndInvoiceNumber)
                    .HasColumnName("sVendorAndInvoiceNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(432);

                entity.Property(e => e.SVendorNumber)
                    .HasColumnName("sVendorNumber")
                    .HasMaxLength(432);
            });

            modelBuilder.Entity<TA6mchk>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tA6MCHK");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDiscount)
                    .HasColumnName("dblDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGross)
                    .HasColumnName("dblGross")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblNet)
                    .HasColumnName("dblNet")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDue)
                    .HasColumnName("dtDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCheckNumber)
                    .HasColumnName("sCheckNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPreIssuedCheckCode)
                    .HasColumnName("sPreIssuedCheckCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReturnCode)
                    .HasColumnName("sReturnCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.STime)
                    .HasColumnName("sTime")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorAndInvoiceNumber)
                    .HasColumnName("sVendorAndInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVendorNumber)
                    .HasColumnName("sVendorNumber")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TableDetails>(entity =>
            {
                entity.HasKey(e => e.BbxName);

                entity.ToTable("TableDetails", "dev");

                entity.Property(e => e.BbxName)
                    .HasColumnName("BBxName")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Details).HasMaxLength(200);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsBeingMigrated).HasDefaultValueSql("((1))");

                entity.Property(e => e.ResetStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateSources)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TableDetails1>(entity =>
            {
                entity.HasKey(e => e.BbxName);

                entity.ToTable("TableDetails");

                entity.Property(e => e.BbxName)
                    .HasColumnName("BBxName")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Details).HasMaxLength(200);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsBeingMigrated).HasDefaultValueSql("((1))");

                entity.Property(e => e.ResetStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateSources)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TApDtl>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tAP-DTL");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDiscountAmount)
                    .HasColumnName("dblDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblFreightAmount)
                    .HasColumnName("dblFreightAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGrossInvoiceAmount)
                    .HasColumnName("dblGrossInvoiceAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDueDate)
                    .HasColumnName("dtDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInvoiceDate)
                    .HasColumnName("dtInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPaidDate)
                    .HasColumnName("dtPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGlnumDistributedOn)
                    .HasColumnName("sGLNumDistributedOn")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHoldPayCode)
                    .HasColumnName("sHoldPayCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra03)
                    .HasColumnName("sHydra03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra04)
                    .HasColumnName("sHydra04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPaidOnCheck)
                    .HasColumnName("sPaidOnCheck")
                    .HasMaxLength(1111);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUnknown00)
                    .HasColumnName("sUnknown00")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorAndInvoice)
                    .HasColumnName("sVendorAndInvoice")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVendorNumber)
                    .HasColumnName("sVendorNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVoidCode)
                    .HasColumnName("sVoidCode")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TCustS>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tCUST_S");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICustomerNumber).HasColumnName("iCustomerNumber");

                entity.Property(e => e.ICustomerNumber2).HasColumnName("iCustomerNumber2");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen1)
                    .HasColumnName("sOpen1")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen2)
                    .HasColumnName("sOpen2")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDlyshp>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tDLYSHP");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblShipValue)
                    .HasColumnName("dblShipValue")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightShipment)
                    .HasColumnName("dblWeightShipment")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtShipDate)
                    .HasColumnName("dtShipDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INumberPiecesShipped).HasColumnName("iNumberPiecesShipped");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackorderSuffix)
                    .HasColumnName("sBackorderSuffix")
                    .HasMaxLength(1111);

                entity.Property(e => e.SBillCode)
                    .HasColumnName("sBillCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPartialCompleteShipment)
                    .HasColumnName("sPartialCompleteShipment")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShippingCompany)
                    .HasColumnName("sShippingCompany")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE1cust>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE1CUST");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostMtd)
                    .HasColumnName("dblCostMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostYtd)
                    .HasColumnName("dblCostYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCurrentHighBalance)
                    .HasColumnName("dblCurrentHighBalance")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesMtd)
                    .HasColumnName("dblSalesMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesYtd)
                    .HasColumnName("dblSalesYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IArcontrol).HasColumnName("iARControl");

                entity.Property(e => e.ICustomerBackoffDays).HasColumnName("iCustomerBackoffDays");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBlank00)
                    .HasColumnName("sBlank00")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationMailed)
                    .HasColumnName("sCertificationMailed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationMaterial)
                    .HasColumnName("sCertificationMaterial")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCityStateZip)
                    .HasColumnName("sCityStateZip")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContact)
                    .HasColumnName("sContact")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCreditHoldFlag)
                    .HasColumnName("sCreditHoldFlag")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEstimateDays)
                    .HasColumnName("sEstimateDays")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMailToLine1)
                    .HasColumnName("sMailToLine1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMailToLine2)
                    .HasColumnName("sMailToLine2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPayHist)
                    .HasColumnName("sPayHist")
                    .HasMaxLength(1111);

                entity.Property(e => e.SResaleNumber)
                    .HasColumnName("sResaleNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress1)
                    .HasColumnName("sShipToAddress1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddressCityStateZip)
                    .HasColumnName("sShipToAddressCityStateZip")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddressCityStateZip2)
                    .HasColumnName("sShipToAddressCityStateZip2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShiptToAddress2)
                    .HasColumnName("sShiptToAddress2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStreetAddress)
                    .HasColumnName("sStreetAddress")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSuiteNum)
                    .HasColumnName("sSuiteNum")
                    .HasMaxLength(1111);

                entity.Property(e => e.STelephoneNumber)
                    .HasColumnName("sTelephoneNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.STerritory)
                    .HasColumnName("sTerritory")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE2head01>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE2HEAD_01");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BSalesShipHold).HasColumnName("bSalesShipHold");

                entity.Property(e => e.DblAdditionalMaterialCost)
                    .HasColumnName("dblAdditionalMaterialCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblAmountInvoicedToDate)
                    .HasColumnName("dblAmountInvoicedToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCreditMemosToDate)
                    .HasColumnName("dblCreditMemosToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblForgeHoursActual)
                    .HasColumnName("dblForgeHoursActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblForgeHoursEstimated)
                    .HasColumnName("dblForgeHoursEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblFreightAmount)
                    .HasColumnName("dblFreightAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblIncentiveRatePerHour)
                    .HasColumnName("dblIncentiveRatePerHour")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblJobCostToDate)
                    .HasColumnName("dblJobCostToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMiscAmount)
                    .HasColumnName("dblMiscAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTaxAmount)
                    .HasColumnName("dblTaxAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtReceived)
                    .HasColumnName("dtReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtShipBy)
                    .HasColumnName("dtShipBy")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IConcurrentTravNum).HasColumnName("iConcurrentTravNum");

                entity.Property(e => e.IForgeWeek).HasColumnName("iForgeWeek");

                entity.Property(e => e.IOriginalQty).HasColumnName("iOriginalQty");

                entity.Property(e => e.ISplitOffNum).HasColumnName("iSplitOffNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackOrder)
                    .HasColumnName("sBackOrder")
                    .HasMaxLength(1111);

                entity.Property(e => e.SBackOrderIndex)
                    .HasColumnName("sBackOrderIndex")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationMailed)
                    .HasColumnName("sCertificationMailed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationWithMaterial)
                    .HasColumnName("sCertificationWithMaterial")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCommissionPercent)
                    .HasColumnName("sCommissionPercent")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContractNumber)
                    .HasColumnName("sContractNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SConversion)
                    .HasColumnName("sConversion")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCreditMemo)
                    .HasColumnName("sCreditMemo")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerPonum)
                    .HasColumnName("sCustomerPONum")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDivisionCode)
                    .HasColumnName("sDivisionCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFreightCode)
                    .HasColumnName("sFreightCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeCode)
                    .HasColumnName("sGradeCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHardness)
                    .HasColumnName("sHardness")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeat1AndProducer)
                    .HasColumnName("sHeat1AndProducer")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeat2AndProducer)
                    .HasColumnName("sHeat2AndProducer")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatTreatLotNumber)
                    .HasColumnName("sHeatTreatLotNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobSummaryCodeNotUsed)
                    .HasColumnName("sJobSummaryCode_NotUsed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLastScheduled)
                    .HasColumnName("sLastScheduled")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialAvailable)
                    .HasColumnName("sMaterialAvailable")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialAvailableDatesString)
                    .HasColumnName("sMaterialAvailableDatesString")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderStatusCode)
                    .HasColumnName("sOrderStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderWriter)
                    .HasColumnName("sOrderWriter")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPrepSize)
                    .HasColumnName("sPrepSize")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriceInEffectNotification)
                    .HasColumnName("sPriceInEffectNotification")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeMachine)
                    .HasColumnName("sPricingCodeMachine")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeMaterial)
                    .HasColumnName("sPricingCodeMaterial")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeOriginalQty)
                    .HasColumnName("sPricingCodeOriginalQty")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriorityCode)
                    .HasColumnName("sPriorityCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriorityRating)
                    .HasColumnName("sPriorityRating")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipByScheduled)
                    .HasColumnName("sShipByScheduled")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress1)
                    .HasColumnName("sShipToAddress1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress2)
                    .HasColumnName("sShipToAddress2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress3)
                    .HasColumnName("sShipToAddress3")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress4)
                    .HasColumnName("sShipToAddress4")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipVia)
                    .HasColumnName("sShipVia")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStockReliefBackOrderFlag)
                    .HasColumnName("sStockReliefBackOrderFlag")
                    .HasMaxLength(1111);

                entity.Property(e => e.STermsCode)
                    .HasColumnName("sTermsCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.STerritory)
                    .HasColumnName("sTerritory")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerPrinted)
                    .HasColumnName("sTravelerPrinted")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE2head02>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE2HEAD_02");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaterialCostActual)
                    .HasColumnName("dblMaterialCost_Actual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaterialCostEstimate)
                    .HasColumnName("dblMaterialCost_Estimate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPullWeightActual)
                    .HasColumnName("dblPullWeight_Actual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPullWeightEstimate)
                    .HasColumnName("dblPullWeight_Estimate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReplacementCost)
                    .HasColumnName("dblReplacementCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISequenceNumber).HasColumnName("iSequenceNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription01)
                    .HasColumnName("sDescription01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription02)
                    .HasColumnName("sDescription02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription03)
                    .HasColumnName("sDescription03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription04)
                    .HasColumnName("sDescription04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra03)
                    .HasColumnName("sHydra03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra04)
                    .HasColumnName("sHydra04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra05)
                    .HasColumnName("sHydra05")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra06)
                    .HasColumnName("sHydra06")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra07)
                    .HasColumnName("sHydra07")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra08)
                    .HasColumnName("sHydra08")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra09)
                    .HasColumnName("sHydra09")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra10)
                    .HasColumnName("sHydra10")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra21)
                    .HasColumnName("sHydra21")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra22)
                    .HasColumnName("sHydra22")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra23)
                    .HasColumnName("sHydra23")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra24)
                    .HasColumnName("sHydra24")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra25)
                    .HasColumnName("sHydra25")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra26)
                    .HasColumnName("sHydra26")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra27)
                    .HasColumnName("sHydra27")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra28)
                    .HasColumnName("sHydra28")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra29)
                    .HasColumnName("sHydra29")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra30)
                    .HasColumnName("sHydra30")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra31)
                    .HasColumnName("sHydra31")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra32)
                    .HasColumnName("sHydra32")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra33)
                    .HasColumnName("sHydra33")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra34)
                    .HasColumnName("sHydra34")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra35)
                    .HasColumnName("sHydra35")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra36)
                    .HasColumnName("sHydra36")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra37)
                    .HasColumnName("sHydra37")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra38)
                    .HasColumnName("sHydra38")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra39)
                    .HasColumnName("sHydra39")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra40)
                    .HasColumnName("sHydra40")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra41)
                    .HasColumnName("sHydra41")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra42)
                    .HasColumnName("sHydra42")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra43)
                    .HasColumnName("sHydra43")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra44)
                    .HasColumnName("sHydra44")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra45)
                    .HasColumnName("sHydra45")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra46)
                    .HasColumnName("sHydra46")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra47)
                    .HasColumnName("sHydra47")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra48)
                    .HasColumnName("sHydra48")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra49)
                    .HasColumnName("sHydra49")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra50)
                    .HasColumnName("sHydra50")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE3line>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE3LINE");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaterialCostActual)
                    .HasColumnName("dblMaterialCostActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaterialCostEstimated)
                    .HasColumnName("dblMaterialCostEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblOrderValue)
                    .HasColumnName("dblOrderValue")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReplacementCosts)
                    .HasColumnName("dblReplacementCosts")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShippingWeightActual)
                    .HasColumnName("dblShippingWeightActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShippingWeightEstimated)
                    .HasColumnName("dblShippingWeightEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblUnitPrice)
                    .HasColumnName("dblUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightPulledActual)
                    .HasColumnName("dblWeightPulledActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightPulledEstimated)
                    .HasColumnName("dblWeightPulledEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQuantityOrderActual).HasColumnName("iQuantityOrderActual");

                entity.Property(e => e.IQuantityOrderEstimate).HasColumnName("iQuantityOrderEstimate");

                entity.Property(e => e.ISequenceNumber).HasColumnName("iSequenceNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescript)
                    .HasColumnName("sDescript")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty)
                    .HasColumnName("sEmpty")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriceCode)
                    .HasColumnName("sPriceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE4ref>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE4REF");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDateOrderReceived)
                    .HasColumnName("dtDateOrderReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDueDate)
                    .HasColumnName("dtDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtShipDate)
                    .HasColumnName("dtShipDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackOrderCode)
                    .HasColumnName("sBackOrderCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SBackOrderSequence)
                    .HasColumnName("sBackOrderSequence")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMicrofilm)
                    .HasColumnName("sMicrofilm")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPoNumber)
                    .HasColumnName("sPO_Number")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE5grad>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE5GRAD");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SClass)
                    .HasColumnName("sClass")
                    .HasMaxLength(1111);

                entity.Property(e => e.SColorDescription)
                    .HasColumnName("sColorDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeCode)
                    .HasColumnName("sGradeCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeDescription)
                    .HasColumnName("sGradeDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TE6rep>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tE6REP");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDieNumber1EstimatedLife)
                    .HasColumnName("dblDieNumber1EstimatedLife")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1PiecesToDate)
                    .HasColumnName("dblDieNumber1PiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1PurchaseCost)
                    .HasColumnName("dblDieNumber1PurchaseCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1ResinkCost)
                    .HasColumnName("dblDieNumber1ResinkCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2EstimatedLife)
                    .HasColumnName("dblDieNumber2EstimatedLife")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2PiecesToDate)
                    .HasColumnName("dblDieNumber2PiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2PurchaseCost)
                    .HasColumnName("dblDieNumber2PurchaseCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2ResinkCost)
                    .HasColumnName("dblDieNumber2ResinkCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHydra02)
                    .HasColumnName("dblHydra02")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHydra03)
                    .HasColumnName("dblHydra03")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblIncentiveRatePerHour)
                    .HasColumnName("dblIncentiveRatePerHour")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPvafield)
                    .HasColumnName("dblPVAField")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblRepeatQuantityLast)
                    .HasColumnName("dblRepeatQuantityLast")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblStartingStockSize)
                    .HasColumnName("dblStartingStockSize")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalPiecesToDate)
                    .HasColumnName("dblTotalPiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeight)
                    .HasColumnName("dblWeight")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDieActivityCode).HasColumnName("iDieActivityCode");

                entity.Property(e => e.INextRepeatNumber).HasColumnName("iNextRepeatNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCondition)
                    .HasColumnName("sCondition")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDateAndOriginalPonumber)
                    .HasColumnName("sDateAndOriginalPONumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDieNumber1CodeNumber)
                    .HasColumnName("sDieNumber1CodeNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDieNumber2CodeNumber)
                    .HasColumnName("sDieNumber2CodeNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeCode)
                    .HasColumnName("sGradeCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineProcessCode)
                    .HasColumnName("sMachineProcessCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialProcessCode)
                    .HasColumnName("sMaterialProcessCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen1)
                    .HasColumnName("sOpen1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen2)
                    .HasColumnName("sOpen2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen3)
                    .HasColumnName("sOpen3")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPartNumber)
                    .HasColumnName("sPartNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpec)
                    .HasColumnName("sSpec")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerString)
                    .HasColumnName("sTravelerString")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFcsmandata>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tFCSMANDATA");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtConverstionStartDate)
                    .HasColumnName("dtConverstionStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFirestoneCompletionDate)
                    .HasColumnName("dtFirestoneCompletionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtJobStartDate)
                    .HasColumnName("dtJobStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtMaterialReadyDate)
                    .HasColumnName("dtMaterialReadyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPlannedShipDate)
                    .HasColumnName("dtPlannedShipDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtVarstartDate)
                    .HasColumnName("dtVARStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SActionRequiredBy)
                    .HasColumnName("sActionRequiredBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCprJobCode)
                    .HasColumnName("sCPR_JobCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerBackOffDays)
                    .HasColumnName("sCustomerBackOffDays")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDueDateOverride)
                    .HasColumnName("sDueDateOverride")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinishForgeDateOverride)
                    .HasColumnName("sFinishForgeDateOverride")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinishForgeDone)
                    .HasColumnName("sFinishForgeDone")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFirestoneComplete)
                    .HasColumnName("sFirestoneComplete")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobStarted)
                    .HasColumnName("sJobStarted")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLocation)
                    .HasColumnName("sLocation")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLotQuantity)
                    .HasColumnName("sLotQuantity")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialType)
                    .HasColumnName("sMaterialType")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMilestoneNotes)
                    .HasColumnName("sMilestoneNotes")
                    .HasMaxLength(2000);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOverRide)
                    .HasColumnName("sOverRide")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFcspriority>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tFCSPRIORITY");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDueDate)
                    .HasColumnName("dtDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IOriginalQuantityOnOrder).HasColumnName("iOriginalQuantityOnOrder");

                entity.Property(e => e.IQuantityRequiredOnDueDate).HasColumnName("iQuantityRequiredOnDueDate");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCreatedFromMasterOrder)
                    .HasColumnName("sCreatedFromMasterOrder")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDeliveryNumber)
                    .HasColumnName("sDeliveryNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SForgeQuantity)
                    .HasColumnName("sForgeQuantity")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriority)
                    .HasColumnName("sPriority")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFcssched>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tFCSSCHED");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtScheduledDate)
                    .HasColumnName("dtScheduledDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHours).HasColumnName("iHours");

                entity.Property(e => e.IQuantities).HasColumnName("iQuantities");

                entity.Property(e => e.ISteps).HasColumnName("iSteps");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(42);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGDollarGCaretL>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tG_DOLLAR_G_CARET_L");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAccountsPayableCrCurrent)
                    .HasColumnName("dblAccountsPayableCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblAccountsPayableCrFull)
                    .HasColumnName("dblAccountsPayableCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblAccountsPayableDrCurrent)
                    .HasColumnName("dblAccountsPayableDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblAccountsPayableDrFull)
                    .HasColumnName("dblAccountsPayableDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblBalanceForward)
                    .HasColumnName("dblBalanceForward")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashDisbursementsCrCurrent)
                    .HasColumnName("dblCashDisbursementsCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashDisbursementsCrFull)
                    .HasColumnName("dblCashDisbursementsCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashDisbursementsDrCurrent)
                    .HasColumnName("dblCashDisbursementsDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashDisbursementsDrFull)
                    .HasColumnName("dblCashDisbursementsDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashReceiptsCrCurrent)
                    .HasColumnName("dblCashReceiptsCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashReceiptsCrFull)
                    .HasColumnName("dblCashReceiptsCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashReceiptsDrCurrent)
                    .HasColumnName("dblCashReceiptsDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCashReceiptsDrFull)
                    .HasColumnName("dblCashReceiptsDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDailyProductionCrCurrent)
                    .HasColumnName("dblDailyProductionCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDailyProductionCrFull)
                    .HasColumnName("dblDailyProductionCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDailyProductionDrCurrent)
                    .HasColumnName("dblDailyProductionDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDailyProductionDrFull)
                    .HasColumnName("dblDailyProductionDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDitto01)
                    .HasColumnName("dblDitto01")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDitto02)
                    .HasColumnName("dblDitto02")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal01Cr)
                    .HasColumnName("dblGeneralJournal01CR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal01Dr)
                    .HasColumnName("dblGeneralJournal01DR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal02Cr)
                    .HasColumnName("dblGeneralJournal02CR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal02Dr)
                    .HasColumnName("dblGeneralJournal02DR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal03Cr)
                    .HasColumnName("dblGeneralJournal03CR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal03Dr)
                    .HasColumnName("dblGeneralJournal03DR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal04Cr)
                    .HasColumnName("dblGeneralJournal04CR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGeneralJournal04Dr)
                    .HasColumnName("dblGeneralJournal04DR")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPayrollRegisterCrCurrent)
                    .HasColumnName("dblPayrollRegisterCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPayrollRegisterCrFull)
                    .HasColumnName("dblPayrollRegisterCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPayrollRegisterDrCurrent)
                    .HasColumnName("dblPayrollRegisterDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPayrollRegisterDrFull)
                    .HasColumnName("dblPayrollRegisterDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesJournalCrCurrent)
                    .HasColumnName("dblSalesJournalCR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesJournalCrFull)
                    .HasColumnName("dblSalesJournalCR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesJournalDrCurrent)
                    .HasColumnName("dblSalesJournalDR_Current")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesJournalDrFull)
                    .HasColumnName("dblSalesJournalDR_Full")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountNumber)
                    .HasColumnName("sAccountNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGDollarPst>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tG_DOLLAR_PST");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAmount)
                    .HasColumnName("dblAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPosting)
                    .HasColumnName("dtPosting")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPosting2)
                    .HasColumnName("dtPosting2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPeriod).HasColumnName("iPeriod");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOverwriteProtection)
                    .HasColumnName("sOverwriteProtection")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSourceCode)
                    .HasColumnName("sSourceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGDollarPstArchive>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tG_DOLLAR_PST_ARCHIVE");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAmount)
                    .HasColumnName("dblAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPosting)
                    .HasColumnName("dtPosting")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPosting2)
                    .HasColumnName("dtPosting2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMonth)
                    .HasColumnName("sMonth")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOverwriteProtection)
                    .HasColumnName("sOverwriteProtection")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSourceCode)
                    .HasColumnName("sSourceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SYear)
                    .HasColumnName("sYear")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TI1inv>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tI1INV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBasePriceIn1973)
                    .HasColumnName("dblBasePriceIn1973")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLastProcurementCost)
                    .HasColumnName("dblLastProcurementCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLeadTimeInWeeks)
                    .HasColumnName("dblLeadTimeInWeeks")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReorderPointWeight)
                    .HasColumnName("dblReorderPointWeight")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightLastYear)
                    .HasColumnName("dblSalesInWeightLastYear")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightMtd)
                    .HasColumnName("dblSalesInWeightMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightYtd)
                    .HasColumnName("dblSalesInWeightYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnHand)
                    .HasColumnName("dblTotalWeightOnHand")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnHandReserved)
                    .HasColumnName("dblTotalWeightOnHandReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnOrder)
                    .HasColumnName("dblTotalWeightOnOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnOrderReserved)
                    .HasColumnName("dblTotalWeightOnOrderReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INumberOfTimesSold).HasColumnName("iNumberOfTimesSold");

                entity.Property(e => e.IProcurementPriceCode).HasColumnName("iProcurementPriceCode");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloyCode)
                    .HasColumnName("sAlloyCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCondition)
                    .HasColumnName("sCondition")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TI2heat>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tI2HEAT");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostPerUnitOfMeasureCode)
                    .HasColumnName("dblCostPerUnitOfMeasureCode")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightOnHand)
                    .HasColumnName("dblWeightOnHand")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightReserved)
                    .HasColumnName("dblWeightReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAcquiredDate)
                    .HasColumnName("dtAcquiredDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDepletedDate)
                    .HasColumnName("dtDepletedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILength1Description).HasColumnName("iLength1Description");

                entity.Property(e => e.ILength1OnHand).HasColumnName("iLength1OnHand");

                entity.Property(e => e.ILength1Reserved).HasColumnName("iLength1Reserved");

                entity.Property(e => e.ILength2Description).HasColumnName("iLength2Description");

                entity.Property(e => e.ILength2OnHand).HasColumnName("iLength2OnHand");

                entity.Property(e => e.ILength2Reserved).HasColumnName("iLength2Reserved");

                entity.Property(e => e.ILength3OnHand).HasColumnName("iLength3OnHand");

                entity.Property(e => e.ILength3Reserved).HasColumnName("iLength3Reserved");

                entity.Property(e => e.ILength4OnHand).HasColumnName("iLength4OnHand");

                entity.Property(e => e.ILength4Reserved).HasColumnName("iLength4Reserved");

                entity.Property(e => e.ILength5OnHand).HasColumnName("iLength5OnHand");

                entity.Property(e => e.ILength5Reserved).HasColumnName("iLength5Reserved");

                entity.Property(e => e.IStatusCode).HasColumnName("iStatusCode");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloyCode)
                    .HasColumnName("sAlloyCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCondition)
                    .HasColumnName("sCondition")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatNumber)
                    .HasColumnName("sHeatNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLength345Description)
                    .HasColumnName("sLength3_4_5_Description")
                    .HasMaxLength(1111);

                entity.Property(e => e.SNotUsed01)
                    .HasColumnName("sNotUsed01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SNotUsed02)
                    .HasColumnName("sNotUsed02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SProducer)
                    .HasColumnName("sProducer")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSequence)
                    .HasColumnName("sSequence")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUnitOfMeasureCode)
                    .HasColumnName("sUnitOfMeasureCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TI2rsI>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tI2RS-I");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatSequenceNumber)
                    .HasColumnName("sHeatSequenceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInventoryMasterKey)
                    .HasColumnName("sInventoryMasterKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TI2rsO>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tI2RS-O");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblLenghtReserverdL1)
                    .HasColumnName("dblLenghtReserverd_L1")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLenghtReserverdL2)
                    .HasColumnName("dblLenghtReserverd_L2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLenghtReserverdL3)
                    .HasColumnName("dblLenghtReserverd_L3")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLenghtReserverdL4)
                    .HasColumnName("dblLenghtReserverd_L4")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLenghtReserverdL5)
                    .HasColumnName("dblLenghtReserverd_L5")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelieved)
                    .HasColumnName("dblWeightRelieved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelievedL1)
                    .HasColumnName("dblWeightRelieved_L1")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelievedL2)
                    .HasColumnName("dblWeightRelieved_L2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelievedL3)
                    .HasColumnName("dblWeightRelieved_L3")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelievedL4)
                    .HasColumnName("dblWeightRelieved_L4")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightRelievedL5)
                    .HasColumnName("dblWeightRelieved_L5")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightReserved)
                    .HasColumnName("dblWeightReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDateWeightRelieved)
                    .HasColumnName("dtDateWeightRelieved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDateWeightReserved)
                    .HasColumnName("dtDateWeightReserved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatSequenceNumber)
                    .HasColumnName("sHeatSequenceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInventoryMasterKey)
                    .HasColumnName("sInventoryMasterKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStatusCode)
                    .HasColumnName("sStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUndefined1)
                    .HasColumnName("sUndefined1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUndefined2)
                    .HasColumnName("sUndefined2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUndefined3)
                    .HasColumnName("sUndefined3")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TIdr2009>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tIDR2009");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAcceptedQuantity)
                    .HasColumnName("dblAcceptedQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblClosingValue)
                    .HasColumnName("dblClosingValue")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDaysToClose)
                    .HasColumnName("dblDaysToClose")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDaysToClose2)
                    .HasColumnName("dblDaysToClose2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblInspectedQuantity)
                    .HasColumnName("dblInspectedQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblRejectedQuantity)
                    .HasColumnName("dblRejectedQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReworkCost)
                    .HasColumnName("dblReworkCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblScrapCost)
                    .HasColumnName("dblScrapCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblVdrquantityOnSubmittal)
                    .HasColumnName("dblVDRQuantityOnSubmittal")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblVdrsubmittedQuantity)
                    .HasColumnName("dblVDRSubmittedQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtFinalDispositionDate)
                    .HasColumnName("dtFinalDispositionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFindalCloseDate)
                    .HasColumnName("dtFindalCloseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtIssueDate)
                    .HasColumnName("dtIssueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPreliminaryDisplayDate)
                    .HasColumnName("dtPreliminaryDisplayDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtReworkInstructionIssueDate)
                    .HasColumnName("dtReworkInstructionIssueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtVdrdispositionDate)
                    .HasColumnName("dtVDRDispositionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVdrissueDate)
                    .HasColumnName("dtVDRIssueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVdrsubmittedDate)
                    .HasColumnName("dtVDRSubmittedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloy)
                    .HasColumnName("sAlloy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SComment)
                    .HasColumnName("sComment")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCost)
                    .HasColumnName("sCost")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerPo)
                    .HasColumnName("sCustomerPO")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerTagNumber)
                    .HasColumnName("sCustomerTagNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDepartmentCode)
                    .HasColumnName("sDepartmentCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDepartmentName)
                    .HasColumnName("sDepartmentName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDeviationDescription)
                    .HasColumnName("sDeviationDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalDispositionBy)
                    .HasColumnName("sFinalDispositionBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalDispositionCode)
                    .HasColumnName("sFinalDispositionCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalDispositionComments)
                    .HasColumnName("sFinalDispositionComments")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalReviewBy)
                    .HasColumnName("sFinalReviewBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatCode)
                    .HasColumnName("sHeatCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatNumber)
                    .HasColumnName("sHeatNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SIdrnumber)
                    .HasColumnName("sIDRNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumberSuffix)
                    .HasColumnName("sJobNumberSuffix")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SNonConformanceCode)
                    .HasColumnName("sNonConformanceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPartNumber)
                    .HasColumnName("sPartNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPnrevision)
                    .HasColumnName("sPNRevision")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPreliminaryDisplayCode)
                    .HasColumnName("sPreliminaryDisplayCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPrice)
                    .HasColumnName("sPrice")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReworkInstructions)
                    .HasColumnName("sReworkInstructions")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSalesStatusFeedback)
                    .HasColumnName("sSalesStatusFeedback")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSerialNumbers)
                    .HasColumnName("sSerialNumbers")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStatusOf)
                    .HasColumnName("sStatusOf")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSubmittedBySssalesRep)
                    .HasColumnName("sSubmittedBySSSalesRep")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerStepKey)
                    .HasColumnName("sTravelerStepKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUnitPrice)
                    .HasColumnName("sUnitPrice")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVdrdispositionCode)
                    .HasColumnName("sVDRDispositionCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVdrnumber)
                    .HasColumnName("sVDRNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SVdrwrittenBy)
                    .HasColumnName("sVDRWrittenBy")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TIheatcd>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tIHEATCD");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skey)
                    .HasColumnName("skey")
                    .HasMaxLength(432);
            });

            modelBuilder.Entity<TJ3mach>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tJ3MACH");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostPerHour)
                    .HasColumnName("dblCostPerHour")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHoursMaintenanceMtd)
                    .HasColumnName("dblHoursMaintenanceMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHoursMaintenanceYtd)
                    .HasColumnName("dblHoursMaintenanceYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHoursOperatedMtd)
                    .HasColumnName("dblHoursOperatedMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHoursOperatedYtd)
                    .HasColumnName("dblHoursOperatedYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPartsExpenseMtd)
                    .HasColumnName("dblPartsExpenseMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPartsExpenseYtd)
                    .HasColumnName("dblPartsExpenseYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShipWeightMtd)
                    .HasColumnName("dblShipWeightMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShipWeightYtd)
                    .HasColumnName("dblShipWeightYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShippingCostLbs)
                    .HasColumnName("dblShippingCostLbs")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineDescription)
                    .HasColumnName("sMachineDescription")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineMaster)
                    .HasColumnName("sMachineMaster")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaxUsagePerDay)
                    .HasColumnName("sMaxUsagePerDay")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShultzPonumber)
                    .HasColumnName("sShultzPONumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorReferenceNumber)
                    .HasColumnName("sVendorReferenceNumber")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TLinuxuser>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tLINUXUSER");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFullName)
                    .HasColumnName("sFullName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TMasttrav>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMASTTRAV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostAct)
                    .HasColumnName("dblCostAct")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostEst)
                    .HasColumnName("dblCostEst")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursAct)
                    .HasColumnName("dblMachineHoursAct")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursEst)
                    .HasColumnName("dblMachineHoursEst")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesAct)
                    .HasColumnName("dblPiecesAct")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesEst)
                    .HasColumnName("dblPiecesEst")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalculatedDueDate)
                    .HasColumnName("dtCalculatedDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastDailyProductionDate)
                    .HasColumnName("dtLastDailyProductionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepDurationDays).HasColumnName("iStepDurationDays");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SConvOrMast)
                    .HasColumnName("sConvOrMast")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription1)
                    .HasColumnName("sDescription1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription2)
                    .HasColumnName("sDescription2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra03)
                    .HasColumnName("sHydra03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(42);

                entity.Property(e => e.SOpen)
                    .HasColumnName("sOpen")
                    .HasMaxLength(1111);

                entity.Property(e => e.SRevisionId)
                    .HasColumnName("sRevisionID")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStepNumber)
                    .HasColumnName("sStepNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMse6rep>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSE6REP");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDieNumber1EstimatedLife)
                    .HasColumnName("dblDieNumber1EstimatedLife")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1PiecesToDate)
                    .HasColumnName("dblDieNumber1PiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1PurchaseCost)
                    .HasColumnName("dblDieNumber1PurchaseCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber1ResinkCost)
                    .HasColumnName("dblDieNumber1ResinkCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2EstimatedLife)
                    .HasColumnName("dblDieNumber2EstimatedLife")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2PiecesToDate)
                    .HasColumnName("dblDieNumber2PiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2PurchaseCost)
                    .HasColumnName("dblDieNumber2PurchaseCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDieNumber2ResinkCost)
                    .HasColumnName("dblDieNumber2ResinkCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblIncentiveRatePerHour)
                    .HasColumnName("dblIncentiveRatePerHour")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPvafield)
                    .HasColumnName("dblPVAField")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblRepeatQuantityLast)
                    .HasColumnName("dblRepeatQuantityLast")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblStartingStockSize)
                    .HasColumnName("dblStartingStockSize")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalPiecesToDate)
                    .HasColumnName("dblTotalPiecesToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeight)
                    .HasColumnName("dblWeight")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICustomerNumber).HasColumnName("iCustomerNumber");

                entity.Property(e => e.IDieActivityCode).HasColumnName("iDieActivityCode");

                entity.Property(e => e.INextRepeatNumber).HasColumnName("iNextRepeatNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCondition)
                    .HasColumnName("sCondition")
                    .HasMaxLength(432);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(432);

                entity.Property(e => e.SDateAndOriginalPonumber)
                    .HasColumnName("sDateAndOriginalPONumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SDieNumber1CodeNumber)
                    .HasColumnName("sDieNumber1CodeNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SDieNumber2CodeNumber)
                    .HasColumnName("sDieNumber2CodeNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SGradeCode)
                    .HasColumnName("sGradeCode")
                    .HasMaxLength(432);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SMachineProcessCode)
                    .HasColumnName("sMachineProcessCode")
                    .HasMaxLength(432);

                entity.Property(e => e.SMaterialProcessCode)
                    .HasColumnName("sMaterialProcessCode")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen1)
                    .HasColumnName("sOpen1")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen2)
                    .HasColumnName("sOpen2")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen3)
                    .HasColumnName("sOpen3")
                    .HasMaxLength(432);

                entity.Property(e => e.SPartNumber)
                    .HasColumnName("sPartNumber")
                    .HasMaxLength(432);

                entity.Property(e => e.SSpec)
                    .HasColumnName("sSpec")
                    .HasMaxLength(432);

                entity.Property(e => e.STravelerString)
                    .HasColumnName("sTravelerString")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMshead>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSHEAD");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BSalesShipHold).HasColumnName("bSalesShipHold");

                entity.Property(e => e.DblAdditionalMaterialCost)
                    .HasColumnName("dblAdditionalMaterialCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblAmountInvoicedToDate)
                    .HasColumnName("dblAmountInvoicedToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCreditMemosToDate)
                    .HasColumnName("dblCreditMemosToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblForgeHoursActual)
                    .HasColumnName("dblForgeHoursActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblForgeHoursEstimated)
                    .HasColumnName("dblForgeHoursEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblFreightAmount)
                    .HasColumnName("dblFreightAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblIncentiveRatePerHour)
                    .HasColumnName("dblIncentiveRatePerHour")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblJobCostToDate)
                    .HasColumnName("dblJobCostToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMiscAmount)
                    .HasColumnName("dblMiscAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTaxAmount)
                    .HasColumnName("dblTaxAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IConcurrentTravNum).HasColumnName("iConcurrentTravNum");

                entity.Property(e => e.IForgeWeek).HasColumnName("iForgeWeek");

                entity.Property(e => e.IOriginalQty).HasColumnName("iOriginalQty");

                entity.Property(e => e.ISplitOffNum).HasColumnName("iSplitOffNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackOrder)
                    .HasColumnName("sBackOrder")
                    .HasMaxLength(1111);

                entity.Property(e => e.SBackOrderIndex)
                    .HasColumnName("sBackOrderIndex")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationMailed)
                    .HasColumnName("sCertificationMailed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCertificationWithMaterial)
                    .HasColumnName("sCertificationWithMaterial")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCommissionPercent)
                    .HasColumnName("sCommissionPercent")
                    .HasMaxLength(1111);

                entity.Property(e => e.SContractNumber)
                    .HasColumnName("sContractNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SConversion)
                    .HasColumnName("sConversion")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCreditMemo)
                    .HasColumnName("sCreditMemo")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerPonum)
                    .HasColumnName("sCustomerPONum")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDivisionCode)
                    .HasColumnName("sDivisionCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFreightCode)
                    .HasColumnName("sFreightCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeCode)
                    .HasColumnName("sGradeCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHardness)
                    .HasColumnName("sHardness")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeat1AndProducer)
                    .HasColumnName("sHeat1AndProducer")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeat2AndProducer)
                    .HasColumnName("sHeat2AndProducer")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHeatTreatLotNumber)
                    .HasColumnName("sHeatTreatLotNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobSummaryCodeNotUsed)
                    .HasColumnName("sJobSummaryCode_NotUsed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLastScheduled)
                    .HasColumnName("sLastScheduled")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialAvailable)
                    .HasColumnName("sMaterialAvailable")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialAvailableDatesString)
                    .HasColumnName("sMaterialAvailableDatesString")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderStatusCode)
                    .HasColumnName("sOrderStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderWriter)
                    .HasColumnName("sOrderWriter")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPrepSize)
                    .HasColumnName("sPrepSize")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriceInEffectNotification)
                    .HasColumnName("sPriceInEffectNotification")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeMachine)
                    .HasColumnName("sPricingCodeMachine")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeMaterial)
                    .HasColumnName("sPricingCodeMaterial")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPricingCodeOriginalQty)
                    .HasColumnName("sPricingCodeOriginalQty")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriorityCode)
                    .HasColumnName("sPriorityCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriorityRating)
                    .HasColumnName("sPriorityRating")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReceivedDate)
                    .HasColumnName("sReceivedDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipByDate)
                    .HasColumnName("sShipByDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipByScheduled)
                    .HasColumnName("sShipByScheduled")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress1)
                    .HasColumnName("sShipToAddress1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress2)
                    .HasColumnName("sShipToAddress2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress3)
                    .HasColumnName("sShipToAddress3")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipToAddress4)
                    .HasColumnName("sShipToAddress4")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipVia)
                    .HasColumnName("sShipVia")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStockReliefBackOrderFlag)
                    .HasColumnName("sStockReliefBackOrderFlag")
                    .HasMaxLength(1111);

                entity.Property(e => e.STermsCode)
                    .HasColumnName("sTermsCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.STerritory)
                    .HasColumnName("sTerritory")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerPrinted)
                    .HasColumnName("sTravelerPrinted")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMsi1inv>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSI1INV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBasePriceIn1973)
                    .HasColumnName("dblBasePriceIn1973")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLastProcurementCost)
                    .HasColumnName("dblLastProcurementCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblLeadTimeInWeeks)
                    .HasColumnName("dblLeadTimeInWeeks")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReorderPointWeight)
                    .HasColumnName("dblReorderPointWeight")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightLastYear)
                    .HasColumnName("dblSalesInWeightLastYear")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightMtd)
                    .HasColumnName("dblSalesInWeightMTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesInWeightYtd)
                    .HasColumnName("dblSalesInWeightYTD")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnHand)
                    .HasColumnName("dblTotalWeightOnHand")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnHandReserved)
                    .HasColumnName("dblTotalWeightOnHandReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnOrder)
                    .HasColumnName("dblTotalWeightOnOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalWeightOnOrderReserved)
                    .HasColumnName("dblTotalWeightOnOrderReserved")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAlloyCode).HasColumnName("iAlloyCode");

                entity.Property(e => e.INumberOfTimesSold).HasColumnName("iNumberOfTimesSold");

                entity.Property(e => e.IProcurementPriceCode).HasColumnName("iProcurementPriceCode");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCondition)
                    .HasColumnName("sCondition")
                    .HasMaxLength(432);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(432);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(432);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(432);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMsline>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSLINE");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaterialCostActual)
                    .HasColumnName("dblMaterialCostActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaterialCostEstimated)
                    .HasColumnName("dblMaterialCostEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblOrderValue)
                    .HasColumnName("dblOrderValue")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblReplacementCosts)
                    .HasColumnName("dblReplacementCosts")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShippingWeightActual)
                    .HasColumnName("dblShippingWeightActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblShippingWeightEstimated)
                    .HasColumnName("dblShippingWeightEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblUnitPrice)
                    .HasColumnName("dblUnitPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightPulledActual)
                    .HasColumnName("dblWeightPulledActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightPulledEstimated)
                    .HasColumnName("dblWeightPulledEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQuantityOrderActual).HasColumnName("iQuantityOrderActual");

                entity.Property(e => e.IQuantityOrderEstimate).HasColumnName("iQuantityOrderEstimate");

                entity.Property(e => e.ISequenceNumber).HasColumnName("iSequenceNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescript)
                    .HasColumnName("sDescript")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty)
                    .HasColumnName("sEmpty")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriceCode)
                    .HasColumnName("sPriceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMsspec>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSSPEC");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDateWrittenIntoFile)
                    .HasColumnName("sDateWrittenIntoFile")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGradeInKey)
                    .HasColumnName("sGradeInKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialCode)
                    .HasColumnName("sMaterialCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderNumber)
                    .HasColumnName("sOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPartNumberOrBarSize)
                    .HasColumnName("sPartNumberOrBarSize")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpecAbbreviation)
                    .HasColumnName("sSpecAbbreviation")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpecs)
                    .HasColumnName("sSpecs")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMstrav>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tMSTRAV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostActual)
                    .HasColumnName("dblCostActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostEstimated)
                    .HasColumnName("dblCostEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursActual)
                    .HasColumnName("dblMachineHoursActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursEstimated)
                    .HasColumnName("dblMachineHoursEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesActual)
                    .HasColumnName("dblPiecesActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesEstimated)
                    .HasColumnName("dblPiecesEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblResPieces)
                    .HasColumnName("dblResPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalculatedDue)
                    .HasColumnName("dtCalculatedDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastProduction)
                    .HasColumnName("dtLastProduction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IScheduledDays).HasColumnName("iScheduledDays");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescriptionLine1)
                    .HasColumnName("sDescriptionLine1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescriptionLine2)
                    .HasColumnName("sDescriptionLine2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra03)
                    .HasColumnName("sHydra03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra04)
                    .HasColumnName("sHydra04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra05)
                    .HasColumnName("sHydra05")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra06)
                    .HasColumnName("sHydra06")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra07)
                    .HasColumnName("sHydra07")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra08)
                    .HasColumnName("sHydra08")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(42);

                entity.Property(e => e.SStatusCode)
                    .HasColumnName("sStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserCompletingStep)
                    .HasColumnName("sUserCompletingStep")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TocSpans>(entity =>
            {
                entity.ToTable("TOC_Spans");

                entity.Property(e => e.Ln).HasColumnName("LN");

                entity.Property(e => e.Part)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e._0).HasColumnName("0");

                entity.Property(e => e._10).HasColumnName("10");

                entity.Property(e => e._20).HasColumnName("20");

                entity.Property(e => e._30).HasColumnName("30");

                entity.Property(e => e._40).HasColumnName("40");

                entity.Property(e => e._5).HasColumnName("5");

                entity.Property(e => e._50).HasColumnName("50");

                entity.Property(e => e._60).HasColumnName("60");

                entity.Property(e => e._70).HasColumnName("70");

                entity.Property(e => e._80).HasColumnName("80");

                entity.Property(e => e._90).HasColumnName("90");
            });

            modelBuilder.Entity<TOfctrav>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tOFCTRAV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountingApprovalActDate)
                    .HasColumnName("sAccountingApprovalActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SAccountingApprovalEstDate)
                    .HasColumnName("sAccountingApprovalEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBrownFolderCreateDate)
                    .HasColumnName("sBrownFolderCreateDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SBrownFolderCreator)
                    .HasColumnName("sBrownFolderCreator")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDistrAndAckSentActDate)
                    .HasColumnName("sDistrAndAckSentActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDistrAndAckSentEstDate)
                    .HasColumnName("sDistrAndAckSentEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEngineeringApprovalActDate)
                    .HasColumnName("sEngineeringApprovalActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEngineeringApprovalEstDate)
                    .HasColumnName("sEngineeringApprovalEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEstCashVerifiedActDate)
                    .HasColumnName("sEstCashVerifiedActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEstCashVerifiedEstDate)
                    .HasColumnName("sEstCashVerifiedEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalTravelerApprovalActDate)
                    .HasColumnName("sFinalTravelerApprovalActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalTravelerApprovalEstDate)
                    .HasColumnName("sFinalTravelerApprovalEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalTravelerReprintActDate)
                    .HasColumnName("sFinalTravelerReprintActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinalTravelerReprintEstDate)
                    .HasColumnName("sFinalTravelerReprintEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachiningCopyActDate)
                    .HasColumnName("sMachiningCopyActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachiningCopyEstDate)
                    .HasColumnName("sMachiningCopyEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOeCopiesForPcactDate)
                    .HasColumnName("sOE_CopiesForPCActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOeCopiesForPcestDate)
                    .HasColumnName("sOE_CopiesForPCEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderEnteredActDate)
                    .HasColumnName("sOrderEnteredActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderEnteredEstDate)
                    .HasColumnName("sOrderEnteredEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderPrintedActDate)
                    .HasColumnName("sOrderPrintedActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderPrintedEstDate)
                    .HasColumnName("sOrderPrintedEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SQa180number)
                    .HasColumnName("sQA180Number")
                    .HasMaxLength(1111);

                entity.Property(e => e.SQcmetallurgyApprovalActDate)
                    .HasColumnName("sQCMetallurgyApprovalActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SQcmetallurgyApprovalEstDate)
                    .HasColumnName("sQCMetallurgyApprovalEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SQualityReviewActDate)
                    .HasColumnName("sQualityReviewActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SQualityReviewEstDate)
                    .HasColumnName("sQualityReviewEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSalesManagerReviewActdDate)
                    .HasColumnName("sSalesManagerReviewActdDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSalesManagerReviewEstDate)
                    .HasColumnName("sSalesManagerReviewEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStockReservationActDate)
                    .HasColumnName("sStockReservationActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStockReservationEstDate)
                    .HasColumnName("sStockReservationEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerDistributedActDate)
                    .HasColumnName("sTravelerDistributedActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerDistributedEstDate)
                    .HasColumnName("sTravelerDistributedEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerPrepTrialPrtActDate)
                    .HasColumnName("sTravelerPrepTrialPrtActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelerPrepTrialPrtEstDate)
                    .HasColumnName("sTravelerPrepTrialPrtEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelersPrintedFinalActDate)
                    .HasColumnName("sTravelersPrintedFinalActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravelersPrintedFinalEstDate)
                    .HasColumnName("sTravelersPrintedFinalEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STrialTravelerReprintActDate)
                    .HasColumnName("sTrialTravelerReprintActDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.STrialTravelerReprintEstDate)
                    .HasColumnName("sTrialTravelerReprintEstDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TP2opo>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tP2OPO");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblUnitCost)
                    .HasColumnName("dblUnitCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICostCode).HasColumnName("iCostCode");

                entity.Property(e => e.IVendorNumber).HasColumnName("iVendorNumber");

                entity.Property(e => e.IWeightOnOrder).HasColumnName("iWeightOnOrder");

                entity.Property(e => e.SAbbreviatedProducerName)
                    .HasColumnName("sAbbreviatedProducerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SConfirming)
                    .HasColumnName("sConfirming")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDeliveryRequested)
                    .HasColumnName("sDeliveryRequested")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEta)
                    .HasColumnName("sETA")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInventoryKey)
                    .HasColumnName("sInventoryKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMillNumber)
                    .HasColumnName("sMillNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen04)
                    .HasColumnName("sOpen04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPurchaseOrder)
                    .HasColumnName("sPurchaseOrder")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPurchaseOrderNumber)
                    .HasColumnName("sPurchaseOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShipped)
                    .HasColumnName("sShipped")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccPeriod>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tPCC-PERIOD");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDateOfFirstMondayOfWeek)
                    .HasColumnName("dtDateOfFirstMondayOfWeek")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDayOfTheYear)
                    .HasColumnName("dtDayOfTheYear")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPeriod).HasColumnName("iPeriod");

                entity.Property(e => e.IWeek).HasColumnName("iWeek");

                entity.Property(e => e.IWorkingDayOfPeriod).HasColumnName("iWorkingDayOfPeriod");

                entity.Property(e => e.IWorkingDayOfWeek).HasColumnName("iWorkingDayOfWeek");

                entity.Property(e => e.IWorkingDayOfYear).HasColumnName("iWorkingDayOfYear");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccperiod2>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tPCCPERIOD2");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDateOfFirstMondayOfWeek)
                    .HasColumnName("dtDateOfFirstMondayOfWeek")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDayOfTheYear)
                    .HasColumnName("dtDayOfTheYear")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPeriod).HasColumnName("iPeriod");

                entity.Property(e => e.IWeek).HasColumnName("iWeek");

                entity.Property(e => e.IWorkingDayOfPeriod).HasColumnName("iWorkingDayOfPeriod");

                entity.Property(e => e.IWorkingDayOfWeek).HasColumnName("iWorkingDayOfWeek");

                entity.Property(e => e.IWorkingDayOfYear).HasColumnName("iWorkingDayOfYear");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPcgraf>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tPCGRAF");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblPieces)
                    .HasColumnName("dblPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTimeUsed)
                    .HasColumnName("dblTimeUsed")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtActual)
                    .HasColumnName("dtActual")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTimeEntry)
                    .HasColumnName("dtTimeEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReportRanBy)
                    .HasColumnName("sReportRanBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SStepC)
                    .HasColumnName("sStepC")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TR1jnl>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tR1JNL");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblFreightAmount)
                    .HasColumnName("dblFreightAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGrossAmount)
                    .HasColumnName("dblGrossAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTaxAmount)
                    .HasColumnName("dblTaxAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TR2aCaretR>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tR2A_CARET_R");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtAgeingDate)
                    .HasColumnName("dtAgeingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCallDate)
                    .HasColumnName("dtCallDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEstimatedReceiveDate)
                    .HasColumnName("dtEstimatedReceiveDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInvoiceDate)
                    .HasColumnName("dtInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackOrderNumber)
                    .HasColumnName("sBackOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCode)
                    .HasColumnName("sCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerSoldToName)
                    .HasColumnName("sCustomerSoldToName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SFinancialInvoiceCode)
                    .HasColumnName("sFinancialInvoiceCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceAmount)
                    .HasColumnName("sInvoiceAMount")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPersonContacted)
                    .HasColumnName("sPersonContacted")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReferenceNumber)
                    .HasColumnName("sReferenceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSalesmanNumber)
                    .HasColumnName("sSalesmanNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.STermsCode)
                    .HasColumnName("sTermsCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.STransactionCode)
                    .HasColumnName("sTransactionCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TR5act>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tR5ACT");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtInvoiceDate)
                    .HasColumnName("dtInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPaymentDate)
                    .HasColumnName("dtPaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICostAmountMaterial).HasColumnName("iCostAmountMaterial");

                entity.Property(e => e.ICostAmountTotal).HasColumnName("iCostAmountTotal");

                entity.Property(e => e.IDiscountAmount).HasColumnName("iDiscountAmount");

                entity.Property(e => e.IGrossAmount).HasColumnName("iGrossAmount");

                entity.Property(e => e.IInvoiceAmount).HasColumnName("iInvoiceAmount");

                entity.Property(e => e.IMiscAmount).HasColumnName("iMiscAmount");

                entity.Property(e => e.IPaymentAmount).HasColumnName("iPaymentAmount");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGlnumber)
                    .HasColumnName("sGLNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumberPlusSequence)
                    .HasColumnName("sInvoiceNumberPlusSequence")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineNumber)
                    .HasColumnName("sMachineNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderStatusCode)
                    .HasColumnName("sOrderStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPurchaseOrderNumber)
                    .HasColumnName("sPurchaseOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TR5sls>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tR5SLS");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostAmountMaterial)
                    .HasColumnName("dblCostAmountMaterial")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostAmountTotal)
                    .HasColumnName("dblCostAmountTotal")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblDiscountAmount)
                    .HasColumnName("dblDiscountAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGrossAmount)
                    .HasColumnName("dblGrossAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblInvoiceAmount)
                    .HasColumnName("dblInvoiceAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMiscellaneousAmount)
                    .HasColumnName("dblMiscellaneousAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPaymentAmount)
                    .HasColumnName("dblPaymentAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtInvoiceDate)
                    .HasColumnName("dtInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPaymentDate)
                    .HasColumnName("dtPaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SGlnumber)
                    .HasColumnName("sGLNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineNumber)
                    .HasColumnName("sMachineNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderStatusCode)
                    .HasColumnName("sOrderStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPurchaseOrderNumber)
                    .HasColumnName("sPurchaseOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TR7CaretJnl>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tR7_CARET_JNL");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblActualCost)
                    .HasColumnName("dblActualCost")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblInvoiceAmount)
                    .HasColumnName("dblInvoiceAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackOrderIndex)
                    .HasColumnName("sBackOrderIndex")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceDate)
                    .HasColumnName("sInvoiceDate")
                    .HasMaxLength(1111);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SNotUsed)
                    .HasColumnName("sNotUsed")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOrderWriterInitials)
                    .HasColumnName("sOrderWriterInitials")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSeccheckProg>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tSECCHECK_PROG");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstLine)
                    .HasColumnName("sFirstLine")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SProgram)
                    .HasColumnName("sProgram")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUser)
                    .HasColumnName("sUser")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TSeccheckUser>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tSECCHECK_USER");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstLine)
                    .HasColumnName("sFirstLine")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SProgram)
                    .HasColumnName("sProgram")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUser)
                    .HasColumnName("sUser")
                    .HasMaxLength(1111);
            });

            modelBuilder.Entity<TSjDtl>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tSJ-DTL");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCommisionPercent)
                    .HasColumnName("dblCommisionPercent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblFreightAmount)
                    .HasColumnName("dblFreightAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblGrossAmount)
                    .HasColumnName("dblGrossAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblInvoiceAmount)
                    .HasColumnName("dblInvoiceAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMiscellaneousAmount)
                    .HasColumnName("dblMiscellaneousAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblSalesTaxAmount)
                    .HasColumnName("dblSalesTaxAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtInvoiceDate)
                    .HasColumnName("dtInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumCode)
                    .HasColumnName("sJobNumCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.STerritory)
                    .HasColumnName("sTerritory")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar90008>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_90-008");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblInvoiceCmToDate)
                    .HasColumnName("dblInvoiceCM_ToDate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaterialCostActualTotal)
                    .HasColumnName("dblMaterialCostActualTotal")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaterialCostAdditional)
                    .HasColumnName("dblMaterialCostAdditional")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtProcessDate)
                    .HasColumnName("dtProcessDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerNumber)
                    .HasColumnName("sCustomerNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobOrderNumber)
                    .HasColumnName("sJobOrderNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineProcessCode)
                    .HasColumnName("sMachineProcessCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMaterialProcessCode)
                    .HasColumnName("sMaterialProcessCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar901068>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_901-068");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IForgeMaxLotQuantity).HasColumnName("iForgeMaxLotQuantity");

                entity.Property(e => e.IFromFirestoneToDueDate).HasColumnName("iFromFirestoneToDueDate");

                entity.Property(e => e.IFromJobStartToFirestone).HasColumnName("iFromJobStartToFirestone");

                entity.Property(e => e.IHeatTreatMaxLotQuantity).HasColumnName("iHeatTreatMaxLotQuantity");

                entity.Property(e => e.IWeeksFromCnv).HasColumnName("iWeeksFromCNV");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLastUpdated)
                    .HasColumnName("sLastUpdated")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLastUpdatedBy)
                    .HasColumnName("sLastUpdatedBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar90184>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_90-184");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtApprovedRevision)
                    .HasColumnName("dtApprovedRevision")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCustomerLatestRevision)
                    .HasColumnName("dtCustomerLatestRevision")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtShultzSteelReview)
                    .HasColumnName("dtShultzSteelReview")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCommentExceptionLine1)
                    .HasColumnName("sCommentExceptionLine1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCommentExceptionLine2)
                    .HasColumnName("sCommentExceptionLine2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerLatestRevisionLetter)
                    .HasColumnName("sCustomerLatestRevisionLetter")
                    .HasMaxLength(1111);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty01)
                    .HasColumnName("sEmpty01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty02)
                    .HasColumnName("sEmpty02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty03)
                    .HasColumnName("sEmpty03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty04)
                    .HasColumnName("sEmpty04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty05)
                    .HasColumnName("sEmpty05")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty06)
                    .HasColumnName("sEmpty06")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty07)
                    .HasColumnName("sEmpty07")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmpty08)
                    .HasColumnName("sEmpty08")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SLatestRevisionApproved)
                    .HasColumnName("sLatestRevisionApproved")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpecTitleLine1)
                    .HasColumnName("sSpecTitleLine1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpecTitleLine2)
                    .HasColumnName("sSpecTitleLine2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpecificationNumberId)
                    .HasColumnName("sSpecificationNumberId")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSpectTitleLine3)
                    .HasColumnName("sSpectTitleLine3")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar90549>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_90-549");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtShipDate)
                    .HasColumnName("dtShipDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar90551>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_90-551");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCounter2)
                    .HasColumnName("dblCounter2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUsed)
                    .HasColumnName("dtUsed")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICounter).HasColumnName("iCounter");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SProgram)
                    .HasColumnName("sProgram")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUser)
                    .HasColumnName("sUser")
                    .HasMaxLength(432);
            });

            modelBuilder.Entity<TStar90551t>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_90-551T");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUsed)
                    .HasColumnName("dtUsed")
                    .HasColumnType("datetime");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen04)
                    .HasColumnName("sOpen04")
                    .HasMaxLength(432);

                entity.Property(e => e.SOpen05)
                    .HasColumnName("sOpen05")
                    .HasMaxLength(432);

                entity.Property(e => e.SProgramName)
                    .HasColumnName("sProgramName")
                    .HasMaxLength(432);

                entity.Property(e => e.SSession)
                    .HasColumnName("sSession")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUser)
                    .HasColumnName("sUser")
                    .HasMaxLength(432);

                entity.Property(e => e.SUser2)
                    .HasColumnName("sUser2")
                    .HasMaxLength(432);
            });

            modelBuilder.Entity<TStar91260>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_91-260");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblEmployeeHours)
                    .HasColumnName("dblEmployeeHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblFinishedPieces)
                    .HasColumnName("dblFinishedPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHours)
                    .HasColumnName("dblMachineHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineRateDollars)
                    .HasColumnName("dblMachineRateDollars")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblProcedureStepNumber)
                    .HasColumnName("dblProcedureStepNumber")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEventDate)
                    .HasColumnName("dtEventDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDepartment).HasColumnName("iDepartment");

                entity.Property(e => e.IHolder01).HasColumnName("iHolder01");

                entity.Property(e => e.IHolder02).HasColumnName("iHolder02");

                entity.Property(e => e.IHolder03).HasColumnName("iHolder03");

                entity.Property(e => e.IHolder04).HasColumnName("iHolder04");

                entity.Property(e => e.IHydra01).HasColumnName("iHydra01");

                entity.Property(e => e.IHydra02).HasColumnName("iHydra02");

                entity.Property(e => e.IHydra03).HasColumnName("iHydra03");

                entity.Property(e => e.IProcedureStep).HasColumnName("iProcedureStep");

                entity.Property(e => e.ITravelerStep).HasColumnName("iTravelerStep");

                entity.Property(e => e.ITravelerStepNumber).HasColumnName("iTravelerStepNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeName)
                    .HasColumnName("sEmployeeName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SEmployeeNumber)
                    .HasColumnName("sEmployeeNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode2)
                    .HasColumnName("sMachineCode2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOperationCode)
                    .HasColumnName("sOperationCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOperationStatus)
                    .HasColumnName("sOperationStatus")
                    .HasMaxLength(1111);

                entity.Property(e => e.SShift)
                    .HasColumnName("sShift")
                    .HasMaxLength(1111);

                entity.Property(e => e.STravellerPrintedCode)
                    .HasColumnName("sTravellerPrintedCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar91325>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_91-325");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblFinishedPieces)
                    .HasColumnName("dblFinishedPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblHoursPerPiece)
                    .HasColumnName("dblHoursPerPiece")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTotalPieces)
                    .HasColumnName("dblTotalPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtApproved)
                    .HasColumnName("dtApproved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAuthorized)
                    .HasColumnName("dtAuthorized")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.ITravelerChargeStep).HasColumnName("iTravelerChargeStep");

                entity.Property(e => e.ITravelerReferenceStep).HasColumnName("iTravelerReferenceStep");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApprovedBy)
                    .HasColumnName("sApprovedBy")
                    .HasMaxLength(2500);

                entity.Property(e => e.SAuthorization)
                    .HasColumnName("sAuthorization")
                    .HasMaxLength(2500);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(2500);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(2500);

                entity.Property(e => e.SIdealMachineCode)
                    .HasColumnName("sIdealMachineCode")
                    .HasMaxLength(2500);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(2500);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(2500);

                entity.Property(e => e.SMachiningDescription)
                    .HasColumnName("sMachiningDescription")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(42);

                entity.Property(e => e.SOpen01)
                    .HasColumnName("sOpen01")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen02)
                    .HasColumnName("sOpen02")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen03)
                    .HasColumnName("sOpen03")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen04)
                    .HasColumnName("sOpen04")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen05)
                    .HasColumnName("sOpen05")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen06)
                    .HasColumnName("sOpen06")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen07)
                    .HasColumnName("sOpen07")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen08)
                    .HasColumnName("sOpen08")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen09)
                    .HasColumnName("sOpen09")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen10)
                    .HasColumnName("sOpen10")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen11)
                    .HasColumnName("sOpen11")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen12)
                    .HasColumnName("sOpen12")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen13)
                    .HasColumnName("sOpen13")
                    .HasMaxLength(2500);

                entity.Property(e => e.SOpen14)
                    .HasColumnName("sOpen14")
                    .HasMaxLength(2500);

                entity.Property(e => e.SRevision)
                    .HasColumnName("sRevision")
                    .HasMaxLength(2500);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar92036>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_92-036");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIsThisJobAmasterOrOrder)
                    .HasColumnName("sIsThisJobAMasterOrOrder")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStar93551>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("t_STAR_93-551");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDigit02)
                    .HasColumnName("dblDigit02")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntry)
                    .HasColumnName("dtEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(432);

                entity.Property(e => e.SProgram)
                    .HasColumnName("sProgram")
                    .HasMaxLength(432);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUser)
                    .HasColumnName("sUser")
                    .HasMaxLength(432);
            });

            modelBuilder.Entity<TTmopn>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tTMOPN");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCapacityHours)
                    .HasColumnName("dblCapacityHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblConversionHours)
                    .HasColumnName("dblConversionHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblOverCapacityHours)
                    .HasColumnName("dblOverCapacityHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblScheduledHours)
                    .HasColumnName("dblScheduledHours")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICostActualMtd).HasColumnName("iCostActualMTD");

                entity.Property(e => e.ICostActualYtd).HasColumnName("iCostActualYTD");

                entity.Property(e => e.ICostEstimatedMtd).HasColumnName("iCostEstimatedMTD");

                entity.Property(e => e.ICostEstimatedYtd).HasColumnName("iCostEstimatedYTD");

                entity.Property(e => e.IHoursActualMtd).HasColumnName("iHoursActualMTD");

                entity.Property(e => e.IHoursActualYtd).HasColumnName("iHoursActualYTD");

                entity.Property(e => e.IHoursEstimatedMtd).HasColumnName("iHoursEstimatedMTD");

                entity.Property(e => e.IHoursEstimatedYtd).HasColumnName("iHoursEstimatedYTD");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentName)
                    .HasColumnName("sDepartmentName")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription01)
                    .HasColumnName("sDescription01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescription02)
                    .HasColumnName("sDescription02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOperationMaster)
                    .HasColumnName("sOperationMaster")
                    .HasMaxLength(1111);

                entity.Property(e => e.SScheduledDays)
                    .HasColumnName("sScheduledDays")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TToccur>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tTOCCUR");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastMoved)
                    .HasColumnName("dtLastMoved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtMoved)
                    .HasColumnName("dtMoved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPriorQuantity).HasColumnName("iPriorQuantity");

                entity.Property(e => e.IQuantityMoved).HasColumnName("iQuantityMoved");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEnteredBy)
                    .HasColumnName("sEnteredBy")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SNewLocation)
                    .HasColumnName("sNewLocation")
                    .HasMaxLength(1111);

                entity.Property(e => e.SPriorLocation)
                    .HasColumnName("sPriorLocation")
                    .HasMaxLength(1111);

                entity.Property(e => e.SReword)
                    .HasColumnName("sReword")
                    .HasMaxLength(1111);

                entity.Property(e => e.SSplit)
                    .HasColumnName("sSplit")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTstrav>(entity =>
            {
                entity.HasKey(e => e.IRecId);

                entity.ToTable("tTSTRAV");

                entity.Property(e => e.IRecId).HasColumnName("iRecID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblActualPieces)
                    .HasColumnName("dblActualPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostActual)
                    .HasColumnName("dblCostActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblCostEstimated)
                    .HasColumnName("dblCostEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursActual)
                    .HasColumnName("dblMachineHoursActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMachineHoursEstimated)
                    .HasColumnName("dblMachineHoursEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesActual)
                    .HasColumnName("dblPiecesActual")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblPiecesEstimated)
                    .HasColumnName("dblPiecesEstimated")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblResPieces)
                    .HasColumnName("dblResPieces")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalculatedDue)
                    .HasColumnName("dtCalculatedDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtIn)
                    .HasColumnName("dtIn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastProduction)
                    .HasColumnName("dtLastProduction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOut)
                    .HasColumnName("dtOut")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IScheduledDays).HasColumnName("iScheduledDays");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescriptionLine1)
                    .HasColumnName("sDescriptionLine1")
                    .HasMaxLength(1111);

                entity.Property(e => e.SDescriptionLine2)
                    .HasColumnName("sDescriptionLine2")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra01)
                    .HasColumnName("sHydra01")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra02)
                    .HasColumnName("sHydra02")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra03)
                    .HasColumnName("sHydra03")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra04)
                    .HasColumnName("sHydra04")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra05)
                    .HasColumnName("sHydra05")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra06)
                    .HasColumnName("sHydra06")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra07)
                    .HasColumnName("sHydra07")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra08)
                    .HasColumnName("sHydra08")
                    .HasMaxLength(1111);

                entity.Property(e => e.SHydra09)
                    .HasColumnName("sHydra09")
                    .HasMaxLength(1111);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(1111);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(1111);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(42);

                entity.Property(e => e.SStatusCode)
                    .HasColumnName("sStatusCode")
                    .HasMaxLength(1111);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
