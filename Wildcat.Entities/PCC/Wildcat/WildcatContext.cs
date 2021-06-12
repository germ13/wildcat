using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class WildcatContext : DbContext
    {
        public WildcatContext()
        {
        }

        public WildcatContext(DbContextOptions<WildcatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<BarShape> BarShape { get; set; }
        public virtual DbSet<Camera> Camera { get; set; }
        public virtual DbSet<CameraJob> CameraJob { get; set; }
        public virtual DbSet<CameraJobSnapshot> CameraJobSnapshot { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<CustomerContact> CustomerContact { get; set; }
        public virtual DbSet<DeleteEndUserToTeam> DeleteEndUserToTeam { get; set; }
        public virtual DbSet<DeleteNavigationMenuToTeam> DeleteNavigationMenuToTeam { get; set; }
        public virtual DbSet<DeleteTeam> DeleteTeam { get; set; }
        public virtual DbSet<EndUser> EndUser { get; set; }
        public virtual DbSet<EndUserToLocation> EndUserToLocation { get; set; }
        public virtual DbSet<EndUserToSecurityGroup> EndUserToSecurityGroup { get; set; }
        public virtual DbSet<Furnace> Furnace { get; set; }
        public virtual DbSet<FurnaceAlarm> FurnaceAlarm { get; set; }
        public virtual DbSet<FurnaceAlarmToWorker> FurnaceAlarmToWorker { get; set; }
        public virtual DbSet<FurnaceSmslog> FurnaceSmslog { get; set; }
        public virtual DbSet<GasMeter> GasMeter { get; set; }
        public virtual DbSet<GasMeterLog> GasMeterLog { get; set; }
        public virtual DbSet<GasMeterReading> GasMeterReading { get; set; }
        public virtual DbSet<HelpDeskStatistic> HelpDeskStatistic { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineNote> MachineNote { get; set; }
        public virtual DbSet<MachineProperty> MachineProperty { get; set; }
        public virtual DbSet<MachinePropertyMetadata> MachinePropertyMetadata { get; set; }
        public virtual DbSet<MachinePropertyMetadataValue> MachinePropertyMetadataValue { get; set; }
        public virtual DbSet<MachineType> MachineType { get; set; }
        public virtual DbSet<MachineTypeMachineProperty> MachineTypeMachineProperty { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MetadataValue> MetadataValue { get; set; }
        public virtual DbSet<Metal> Metal { get; set; }
        public virtual DbSet<NavGroup> NavGroup { get; set; }
        public virtual DbSet<NavigationMenu> NavigationMenu { get; set; }
        public virtual DbSet<NavigationMenuToLocation> NavigationMenuToLocation { get; set; }
        public virtual DbSet<NavigationMenuToSecurityGroup> NavigationMenuToSecurityGroup { get; set; }
        public virtual DbSet<NavLocation> NavLocation { get; set; }
        public virtual DbSet<ReportAttribute> ReportAttribute { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReportToTeam> ReportToTeam { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<SecurityGroup> SecurityGroup { get; set; }
        public virtual DbSet<SerialNumber> SerialNumber { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<SubscriptionCategory> SubscriptionCategory { get; set; }
        public virtual DbSet<SubscriptionWorker> SubscriptionWorker { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
        public virtual DbSet<WorkerToTeam> WorkerToTeam { get; set; }

        // Unable to generate entity type for table 'dbo.Nav'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=Wildcat;user id=WildcatUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BarShape>(entity =>
            {
                entity.HasKey(e => e.ShapeCode);

                entity.Property(e => e.ShapeCode)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedByUserId)
                    .HasColumnName("AddedByUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShapeDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedByUserId)
                    .HasColumnName("UpdatedByUserID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'system')");

                entity.Property(e => e.Archiver)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Details).HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Firmware).HasMaxLength(50);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.NetworkAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.Property(e => e.UserName).HasMaxLength(32);

                entity.Property(e => e.UserNamePassword).HasMaxLength(32);
            });

            modelBuilder.Entity<CameraJob>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'Wildcat')");

                entity.Property(e => e.EndTimeThreshold).HasColumnType("datetime");

                entity.Property(e => e.JobStatus)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Camera)
                    .WithMany(p => p.CameraJob)
                    .HasForeignKey(d => d.CameraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CameraJob_Camera");
            });

            modelBuilder.Entity<CameraJobSnapshot>(entity =>
            {
                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy).HasMaxLength(32);

                entity.Property(e => e.FileNamePath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CameraJob)
                    .WithMany(p => p.CameraJobSnapshot)
                    .HasForeignKey(d => d.CameraJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CameraJobSnapshot_CameraJob");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Location");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddress_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddress_Customer");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Definition)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContact)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContact_Customer");
            });

            modelBuilder.Entity<DeleteEndUserToTeam>(entity =>
            {
                entity.HasKey(e => e.EndUserToTeamId);

                entity.ToTable("_Delete_EndUserToTeam");

                entity.Property(e => e.EndUserToTeamId).HasColumnName("EndUserToTeamID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUserId).HasColumnName("EndUserID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DeleteNavigationMenuToTeam>(entity =>
            {
                entity.ToTable("_Delete_NavigationMenuToTeam");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.DeleteNavigationMenuToTeam)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavigationMenuToTeam_Team");
            });

            modelBuilder.Entity<DeleteTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("_Delete_Team");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EndUser>(entity =>
            {
                entity.HasKey(e => e.AppLoginName);

                entity.Property(e => e.AppLoginName)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Locked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EndUserToLocation>(entity =>
            {
                entity.HasKey(e => new { e.AppLoginName, e.LocationCode });

                entity.Property(e => e.AppLoginName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('ERROR:FIX')");

                entity.Property(e => e.LocationCode).HasMaxLength(6);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AppLoginNameNavigation)
                    .WithMany(p => p.EndUserToLocation)
                    .HasForeignKey(d => d.AppLoginName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.EndUserToLocation)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EndUserToSecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.EndUserAppLoginName, e.SecurityName });

                entity.Property(e => e.EndUserAppLoginName).HasMaxLength(128);

                entity.Property(e => e.SecurityName).HasMaxLength(128);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EndUserAppLoginNameNavigation)
                    .WithMany(p => p.EndUserToSecurityGroup)
                    .HasForeignKey(d => d.EndUserAppLoginName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EndUserToSecurityGroup_EndUser_AppLoginName");

                entity.HasOne(d => d.SecurityNameNavigation)
                    .WithMany(p => p.EndUserToSecurityGroup)
                    .HasForeignKey(d => d.SecurityName)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Furnace>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DbinstanceName)
                    .HasColumnName("DBInstanceName")
                    .HasMaxLength(32);

                entity.Property(e => e.Dbname)
                    .IsRequired()
                    .HasColumnName("DBName")
                    .HasMaxLength(32);

                entity.Property(e => e.DbuserName)
                    .IsRequired()
                    .HasColumnName("DBUserName")
                    .HasMaxLength(32);

                entity.Property(e => e.DbuserPassword)
                    .IsRequired()
                    .HasColumnName("DBUserPassword")
                    .HasMaxLength(32);

                entity.Property(e => e.FurnaceName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(15);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.Furnace)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Furnace_Location");
            });

            modelBuilder.Entity<FurnaceAlarm>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.AlarmType).HasMaxLength(16);

                entity.Property(e => e.CodeName).HasMaxLength(32);

                entity.Property(e => e.DisplayName).HasMaxLength(128);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);
            });

            modelBuilder.Entity<FurnaceAlarmToWorker>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.FurnaceAlarm)
                    .WithMany(p => p.FurnaceAlarmToWorker)
                    .HasForeignKey(d => d.FurnaceAlarmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FurnaceAlarmToWorker_Worker");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.FurnaceAlarmToWorker)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FurnaceAlarmToWorker_FurnaceAlarm");
            });

            modelBuilder.Entity<FurnaceSmslog>(entity =>
            {
                entity.ToTable("FurnaceSMSLog");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage).HasMaxLength(256);

                entity.Property(e => e.FromNumber).HasMaxLength(32);

                entity.Property(e => e.FurnaceName).HasMaxLength(64);

                entity.Property(e => e.MessageStatus).HasMaxLength(16);

                entity.Property(e => e.MessagingServiceSid).HasMaxLength(64);

                entity.Property(e => e.NumberMedia)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfSegments)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 5)");

                entity.Property(e => e.PriceUnit).HasMaxLength(8);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Sid).HasMaxLength(64);

                entity.Property(e => e.TextBody).HasMaxLength(256);

                entity.Property(e => e.ToNumber).HasMaxLength(32);
            });

            modelBuilder.Entity<GasMeter>(entity =>
            {
                entity.HasKey(e => e.MeterName);

                entity.Property(e => e.MeterName)
                    .HasMaxLength(6)
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
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeterIp)
                    .IsRequired()
                    .HasColumnName("MeterIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GasMeterLog>(entity =>
            {
                entity.Property(e => e.GasMeterLogId).HasColumnName("GasMeterLogID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AveragePressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.AverageTemperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.AvgCorrectedFlowRate).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.BatteryVoltage).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.CorrectionFactor).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.EndingPressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.EndingTemperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.MaxPressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.MaxTemperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.MeterName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MinTemperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.MinimumPressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.PeakCorrectedFlowRate).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.SupperCompressibility).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UncorrectedVolUnderFault).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GasMeterReading>(entity =>
            {
                entity.Property(e => e.GasMeterReadingId).HasColumnName("GasMeterReadingID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BatteryVoltage).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.CorrectedResidual).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.CorrectionFactor).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.FlowRate).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.MeterName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OccurredAlarms).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.OccurredFaults).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.PresentAlarms).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.PresentFaults).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Pressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.RawPressure).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.RawTemperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Temperature).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UncorrectedResidual).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.UncorrectedUnderFault).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zfactor)
                    .HasColumnName("ZFactor")
                    .HasColumnType("numeric(18, 9)");
            });

            modelBuilder.Entity<HelpDeskStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticId);

                entity.Property(e => e.StatisticId).HasColumnName("StatisticID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SnapshotDate).HasColumnType("date");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.JobNumber);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
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
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.MaterialNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QualityNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestingNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WeightNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationCode);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.LocationAddress1).HasMaxLength(100);

                entity.Property(e => e.LocationAddress2).HasMaxLength(100);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_Location_Country");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Machine_MachineType");
            });

            modelBuilder.Entity<MachineNote>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NoteType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachineNote)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachineNote_Machine");
            });

            modelBuilder.Entity<MachineProperty>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachineProperty)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachineProperty_Machine");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.MachineProperty)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachineProperty_MachinePropertyMetadata");
            });

            modelBuilder.Entity<MachinePropertyMetadata>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datatype)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Definition)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachinePropertyMetadataValue>(entity =>
            {
                entity.HasKey(e => new { e.MachinePropertyId, e.MetadataValueId });

                entity.Property(e => e.MachinePropertyId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MetadataValueId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MachineProperty)
                    .WithMany(p => p.MachinePropertyMetadataValue)
                    .HasForeignKey(d => d.MachinePropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachinePropertyMetadataValue_MachinePropertyMetadata");

                entity.HasOne(d => d.MetadataValue)
                    .WithMany(p => p.MachinePropertyMetadataValue)
                    .HasForeignKey(d => d.MetadataValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachinePropertyMetadataValue_MetadataValue");
            });

            modelBuilder.Entity<MachineType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Definition)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType1)
                    .IsRequired()
                    .HasColumnName("MachineType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineTypeMachineProperty>(entity =>
            {
                entity.HasKey(e => new { e.MachineId, e.PropertyTypeId });

                entity.Property(e => e.MachineId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyTypeId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Folder).HasMaxLength(16);

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<MetadataValue>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MetadataDisplay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MetadataValue1)
                    .IsRequired()
                    .HasColumnName("MetadataValue")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Metal>(entity =>
            {
                entity.Property(e => e.MetalId).HasColumnName("MetalID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MetalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NavGroup>(entity =>
            {
                entity.HasKey(e => new { e.NavigationMenu, e.SecurityName });

                entity.Property(e => e.NavigationMenu)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName).HasMaxLength(128);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);
            });

            modelBuilder.Entity<NavigationMenu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionName).HasMaxLength(64);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy).HasMaxLength(32);

                entity.Property(e => e.AppName).HasMaxLength(32);

                entity.Property(e => e.ControllerName).HasMaxLength(64);

                entity.Property(e => e.CssClass).HasMaxLength(128);

                entity.Property(e => e.DisplayName).HasMaxLength(32);

                entity.Property(e => e.IconCss).HasMaxLength(32);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.ToolTip).HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_NavigationMenu_ParentId_Id");
            });

            modelBuilder.Entity<NavigationMenuToLocation>(entity =>
            {
                entity.HasKey(e => new { e.NavigationMenu, e.LocationCode });

                entity.Property(e => e.LocationCode).HasMaxLength(6);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.NavigationMenuToLocation)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavigationMenuToLocation_Location");

                entity.HasOne(d => d.NavigationMenuNavigation)
                    .WithMany(p => p.NavigationMenuToLocation)
                    .HasForeignKey(d => d.NavigationMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabigationMenuToLocation_NavigationMenu");
            });

            modelBuilder.Entity<NavigationMenuToSecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.NavigationMenu, e.SecurityName });

                entity.Property(e => e.SecurityName).HasMaxLength(128);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.NavigationMenuNavigation)
                    .WithMany(p => p.NavigationMenuToSecurityGroup)
                    .HasForeignKey(d => d.NavigationMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavigationMenuToSecurityGroup_NavigationMenu");

                entity.HasOne(d => d.SecurityNameNavigation)
                    .WithMany(p => p.NavigationMenuToSecurityGroup)
                    .HasForeignKey(d => d.SecurityName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavigationMenuToSecurityGroup_SecurityGroup");
            });

            modelBuilder.Entity<NavLocation>(entity =>
            {
                entity.HasKey(e => new { e.NavigationMenu, e.LocationCode });

                entity.Property(e => e.NavigationMenu)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode).HasMaxLength(6);

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);
            });

            modelBuilder.Entity<ReportAttribute>(entity =>
            {
                entity.Property(e => e.ReportAttributeId)
                    .HasColumnName("ReportAttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BackgroundStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatorUserGuid).HasColumnName("CreatorUserGUID");

                entity.Property(e => e.ElementType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FilterCriteria).HasColumnType("text");

                entity.Property(e => e.FormLetterRtf)
                    .HasColumnName("FormLetterRTF")
                    .HasColumnType("text");

                entity.Property(e => e.Module)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Preview).HasColumnType("image");

                entity.Property(e => e.ReportAsXml).HasColumnType("xml");

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Stream).HasColumnType("image");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.LayoutData).HasColumnType("image");
            });

            modelBuilder.Entity<ReportToTeam>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedByEndUserId)
                    .HasColumnName("AddedByEndUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUserId).HasColumnName("EndUserID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedByEndUserId)
                    .HasColumnName("UpdatedByEndUserID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportToTeam)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportToTeam_Report");
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SecurityGroup>(entity =>
            {
                entity.HasKey(e => e.SecurityName);

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SerialNumber>(entity =>
            {
                entity.Property(e => e.SerialNumberId).HasColumnName("SerialNumberID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Alphanumeric)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.JobNumberNavigation)
                    .WithMany(p => p.SerialNumber)
                    .HasForeignKey(d => d.JobNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerialNumber_Job");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.DisplayName).HasMaxLength(128);

                entity.Property(e => e.NameCode)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subscription)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_SubscriptionCategory");
            });

            modelBuilder.Entity<SubscriptionCategory>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.DetailDescription).HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);
            });

            modelBuilder.Entity<SubscriptionWorker>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(32);

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionWorker)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionWorker_Subscription");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.SubscriptionWorker)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionWorker_Worker");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BadgeNumber).HasMaxLength(10);

                entity.Property(e => e.DaysOfWeek)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstName).HasMaxLength(25);

                entity.Property(e => e.IsSalary).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(25);

                entity.Property(e => e.ShiftEnd)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('16:00:00')");

                entity.Property(e => e.ShiftStart)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("('06:30:00')");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkerToTeam>(entity =>
            {
                entity.Property(e => e.WorkerToTeamId).HasColumnName("WorkerToTeamID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.WorkerToTeam)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkerToTeam_Team");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.WorkerToTeam)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkerToTeam_Worker");
            });
        }
    }
}
