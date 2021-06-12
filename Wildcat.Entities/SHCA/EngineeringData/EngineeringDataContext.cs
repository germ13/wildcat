using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class EngineeringDataContext : DbContext
    {
        public EngineeringDataContext()
        {
        }

        public EngineeringDataContext(DbContextOptions<EngineeringDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AqmdAirQualityAudit> AqmdAirQualityAudit { get; set; }
        public virtual DbSet<ConditioningCgr> ConditioningCgr { get; set; }
        public virtual DbSet<ConditioningFlowMeter> ConditioningFlowMeter { get; set; }
        public virtual DbSet<ConditioningThreshold> ConditioningThreshold { get; set; }
        public virtual DbSet<Dc1> Dc1 { get; set; }
        public virtual DbSet<Dc2> Dc2 { get; set; }
        public virtual DbSet<Dc3> Dc3 { get; set; }
        public virtual DbSet<Dc4> Dc4 { get; set; }
        public virtual DbSet<Dc5> Dc5 { get; set; }
        public virtual DbSet<Dc6> Dc6 { get; set; }
        public virtual DbSet<Dob> Dob { get; set; }
        public virtual DbSet<Fbe> Fbe { get; set; }
        public virtual DbSet<Fbf> Fbf { get; set; }
        public virtual DbSet<Fbp> Fbp { get; set; }
        public virtual DbSet<Fbr> Fbr { get; set; }
        public virtual DbSet<Fg1> Fg1 { get; set; }
        public virtual DbSet<Fg6> Fg6 { get; set; }
        public virtual DbSet<Fga> Fga { get; set; }
        public virtual DbSet<Fgd1> Fgd1 { get; set; }
        public virtual DbSet<Fgd2> Fgd2 { get; set; }
        public virtual DbSet<Fgd3> Fgd3 { get; set; }
        public virtual DbSet<Fgd4> Fgd4 { get; set; }
        public virtual DbSet<Fgd5> Fgd5 { get; set; }
        public virtual DbSet<Fgd6> Fgd6 { get; set; }
        public virtual DbSet<Fgh> Fgh { get; set; }
        public virtual DbSet<Fgl1> Fgl1 { get; set; }
        public virtual DbSet<Fgl2> Fgl2 { get; set; }
        public virtual DbSet<Fgn> Fgn { get; set; }
        public virtual DbSet<FgnAd> FgnAd { get; set; }
        public virtual DbSet<Fgq> Fgq { get; set; }
        public virtual DbSet<Fgrl> Fgrl { get; set; }
        public virtual DbSet<Fgru> Fgru { get; set; }
        public virtual DbSet<Fgx> Fgx { get; set; }
        public virtual DbSet<Fhh> Fhh { get; set; }
        public virtual DbSet<Fhn> Fhn { get; set; }
        public virtual DbSet<Fhr> Fhr { get; set; }
        public virtual DbSet<Fnh> Fnh { get; set; }
        public virtual DbSet<Fnp> Fnp { get; set; }
        public virtual DbSet<Frr> Frr { get; set; }
        public virtual DbSet<Fup> Fup { get; set; }
        public virtual DbSet<Fur> Fur { get; set; }
        public virtual DbSet<Fus> Fus { get; set; }
        public virtual DbSet<Fxp> Fxp { get; set; }
        public virtual DbSet<Fxr> Fxr { get; set; }
        public virtual DbSet<Fxt> Fxt { get; set; }
        public virtual DbSet<GrinderData> GrinderData { get; set; }
        public virtual DbSet<KepwareMachine> KepwareMachine { get; set; }
        public virtual DbSet<KepwareMachineProperty> KepwareMachineProperty { get; set; }
        public virtual DbSet<KepwareMachineValue> KepwareMachineValue { get; set; }
        public virtual DbSet<KepwareMetaProperty> KepwareMetaProperty { get; set; }
        public virtual DbSet<KepwareMetaValue> KepwareMetaValue { get; set; }
        public virtual DbSet<KepwareTag> KepwareTag { get; set; }
        public virtual DbSet<KepwareTagOld> KepwareTagOld { get; set; }
        public virtual DbSet<Rcr> Rcr { get; set; }
        public virtual DbSet<Rhc> Rhc { get; set; }
        public virtual DbSet<Rht> Rht { get; set; }
        public virtual DbSet<Rvd> Rvd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHCA-SQL03;Database=EngineeringData;user id=ShultzEngineeringUser;password=ShultzEngineeringUserPwd123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AqmdAirQualityAudit>(entity =>
            {
                entity.ToTable("AQMD_AirQualityAudit");

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

                entity.Property(e => e.Property)
                    .HasColumnName("_PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STableName)
                    .IsRequired()
                    .HasColumnName("sTableName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STagGuid).HasColumnName("sTagGUID");

                entity.Property(e => e.STagName)
                    .IsRequired()
                    .HasColumnName("sTagName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConditioningCgr>(entity =>
            {
                entity.ToTable("Conditioning_CGR");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConditioningFlowMeter>(entity =>
            {
                entity.ToTable("Conditioning_FlowMeter");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConditioningThreshold>(entity =>
            {
                entity.ToTable("Conditioning_Threshold");

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

                entity.Property(e => e.DblValue).HasColumnName("dblValue");

                entity.Property(e => e.KepwareId).HasColumnName("kepwareId");

                entity.Property(e => e.Property)
                    .HasColumnName("_PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dc1>(entity =>
            {
                entity.ToTable("DC1");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Dc2>(entity =>
            {
                entity.ToTable("DC2");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dc3>(entity =>
            {
                entity.ToTable("DC3");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dc4>(entity =>
            {
                entity.ToTable("DC4");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dc5>(entity =>
            {
                entity.ToTable("DC5");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dc6>(entity =>
            {
                entity.ToTable("DC6");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dob>(entity =>
            {
                entity.ToTable("DOB");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fbe>(entity =>
            {
                entity.ToTable("FBE");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fbf>(entity =>
            {
                entity.ToTable("FBF");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fbp>(entity =>
            {
                entity.ToTable("FBP");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fbr>(entity =>
            {
                entity.ToTable("FBR");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fg1>(entity =>
            {
                entity.ToTable("FG1");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fg6>(entity =>
            {
                entity.ToTable("FG6");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fga>(entity =>
            {
                entity.ToTable("FGA");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fgd1>(entity =>
            {
                entity.ToTable("FGD1");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgd2>(entity =>
            {
                entity.ToTable("FGD2");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgd3>(entity =>
            {
                entity.ToTable("FGD3");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgd4>(entity =>
            {
                entity.ToTable("FGD4");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgd5>(entity =>
            {
                entity.ToTable("FGD5");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgd6>(entity =>
            {
                entity.ToTable("FGD6");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgh>(entity =>
            {
                entity.ToTable("FGH");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgl1>(entity =>
            {
                entity.ToTable("FGL1");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fgl2>(entity =>
            {
                entity.ToTable("FGL2");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fgn>(entity =>
            {
                entity.ToTable("FGN");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FgnAd>(entity =>
            {
                entity.ToTable("FGN_AD");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgq>(entity =>
            {
                entity.ToTable("FGQ");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fgrl>(entity =>
            {
                entity.ToTable("FGRL");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgru>(entity =>
            {
                entity.ToTable("FGRU");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fgx>(entity =>
            {
                entity.ToTable("FGX");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fhh>(entity =>
            {
                entity.ToTable("FHH");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fhn>(entity =>
            {
                entity.ToTable("FHN");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fhr>(entity =>
            {
                entity.ToTable("FHR");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fnh>(entity =>
            {
                entity.ToTable("FNH");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fnp>(entity =>
            {
                entity.ToTable("FNP");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Frr>(entity =>
            {
                entity.ToTable("FRR");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fup>(entity =>
            {
                entity.ToTable("FUP");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fur>(entity =>
            {
                entity.ToTable("FUR");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fus>(entity =>
            {
                entity.ToTable("FUS");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fxp>(entity =>
            {
                entity.ToTable("FXP");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fxr>(entity =>
            {
                entity.ToTable("FXR");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Fxt>(entity =>
            {
                entity.ToTable("FXT");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<KepwareMachine>(entity =>
            {
                entity.Property(e => e.KepwareMachineId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KepwareMachineProperty>(entity =>
            {
                entity.HasKey(e => e.MachinePropertyId);

                entity.Property(e => e.MachinePropertyId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KepwareMachineValue>(entity =>
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

                entity.Property(e => e.KepwareMachineId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MachinePropertyId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.KepwareMachine)
                    .WithMany(p => p.KepwareMachineValue)
                    .HasForeignKey(d => d.KepwareMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareMachineValue_KepwareMachine");

                entity.HasOne(d => d.MachineProperty)
                    .WithMany(p => p.KepwareMachineValue)
                    .HasForeignKey(d => d.MachinePropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareMachineValue_KepwareMachineProperty");
            });

            modelBuilder.Entity<KepwareMetaProperty>(entity =>
            {
                entity.HasKey(e => e.MetaPropertyId);

                entity.Property(e => e.MetaPropertyId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KepwareMetaValue>(entity =>
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

                entity.Property(e => e.KepwareTagId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MetaPropertyId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.KepwareTag)
                    .WithMany(p => p.KepwareMetaValue)
                    .HasForeignKey(d => d.KepwareTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareMetaValue_KepwareTag1");

                entity.HasOne(d => d.KepwareTagNavigation)
                    .WithMany(p => p.KepwareMetaValue)
                    .HasForeignKey(d => d.KepwareTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareMetaValue_KepwareTag");

                entity.HasOne(d => d.MetaProperty)
                    .WithMany(p => p.KepwareMetaValue)
                    .HasForeignKey(d => d.MetaPropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareMetaValue_KepwareMetaProperty");
            });

            modelBuilder.Entity<KepwareTag>(entity =>
            {
                entity.Property(e => e.KepwareTagId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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

                entity.Property(e => e.KepwareMachineId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareProperty)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareTable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareTagDisplay)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KepwareTagName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.KepwareMachine)
                    .WithMany(p => p.KepwareTag)
                    .HasForeignKey(d => d.KepwareMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KepwareTag_KepwareMachine");
            });

            modelBuilder.Entity<KepwareTagOld>(entity =>
            {
                entity.HasKey(e => e.KepwareTagId);

                entity.ToTable("KepwareTag_old");

                entity.HasIndex(e => e.KepwareProperty)
                    .HasName("IX_KepwareProperty");

                entity.HasIndex(e => new { e.KepwareTagName, e.Machine })
                    .HasName("IX_KepwareTagMachine");

                entity.Property(e => e.KepwareTagId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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

                entity.Property(e => e.KepwareProperty)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareTable)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KepwareTagDisplay)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KepwareTagName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Machine)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rcr>(entity =>
            {
                entity.ToTable("RCR");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rhc>(entity =>
            {
                entity.ToTable("RHC");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Rht>(entity =>
            {
                entity.ToTable("RHT");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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

            modelBuilder.Entity<Rvd>(entity =>
            {
                entity.ToTable("RVD");

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

                entity.Property(e => e.Numericid).HasColumnName("_NUMERICID");

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
