using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.PCC.PCC03Integration
{
    public partial class PCC03_IntegrationContext : DbContext
    {
        public PCC03_IntegrationContext()
        {
        }

        public PCC03_IntegrationContext(DbContextOptions<PCC03_IntegrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmailAddresses> EmailAddresses { get; set; }
        public virtual DbSet<Int002Item> Int002Item { get; set; }
        public virtual DbSet<Int003SalesOrder> Int003SalesOrder { get; set; }
        public virtual DbSet<Int004Router> Int004Router { get; set; }
        public virtual DbSet<Int005Job> Int005Job { get; set; }
        public virtual DbSet<Int006Job> Int006Job { get; set; }
        public virtual DbSet<Int007ResourceTran> Int007ResourceTran { get; set; }
        public virtual DbSet<Int008MoveTran> Int008MoveTran { get; set; }
        public virtual DbSet<Int010CompleteTran> Int010CompleteTran { get; set; }
        public virtual DbSet<MasterTable> MasterTable { get; set; }
        public virtual DbSet<MasterTableCopy> MasterTableCopy { get; set; }
        public virtual DbSet<OracleLink> OracleLink { get; set; }
        public virtual DbSet<TestOracle> TestOracle { get; set; }
        public virtual DbSet<TestPcc03> TestPcc03 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01\\PCC03;Database=PCC03_Integration;user id=IntegrationUser;password=IntegrationUserPwd123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailAddresses>(entity =>
            {
                entity.HasKey(e => e.EmailAddress);

                entity.Property(e => e.EmailAddress)
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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int002Item>(entity =>
            {
                entity.ToTable("Int002_Item");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int003SalesOrder>(entity =>
            {
                entity.ToTable("Int003_SalesOrder");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int004Router>(entity =>
            {
                entity.ToTable("Int004_Router");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int005Job>(entity =>
            {
                entity.ToTable("Int005_Job");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int006Job>(entity =>
            {
                entity.ToTable("Int006_Job");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int007ResourceTran>(entity =>
            {
                entity.ToTable("Int007_ResourceTran");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int008MoveTran>(entity =>
            {
                entity.ToTable("Int008_MoveTran");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.InProcess)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Int010CompleteTran>(entity =>
            {
                entity.ToTable("Int010_CompleteTran");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionObject).IsUnicode(false);

                entity.Property(e => e.InProcess)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JsonChildObject).IsUnicode(false);

                entity.Property(e => e.JsonParentObject)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseObject).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTable>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTableCopy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.AddedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OracleLink>(entity =>
            {
                entity.HasKey(e => e.IdOracleLink);

                entity.ToTable("oracle_link");

                entity.Property(e => e.IdOracleLink).HasColumnName("id_oracle_link");

                entity.Property(e => e.ColumnCheck)
                    .IsRequired()
                    .HasColumnName("column_check")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdName)
                    .IsRequired()
                    .HasColumnName("id_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasColumnName("table")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestOracle>(entity =>
            {
                entity.ToTable("Test_Oracle");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Testcol)
                    .HasColumnName("testcol")
                    .HasMaxLength(10);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestPcc03>(entity =>
            {
                entity.ToTable("Test_PCC03");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC03')");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Processor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
