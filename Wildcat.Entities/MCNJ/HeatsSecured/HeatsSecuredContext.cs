using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class HeatsSecuredContext : DbContext
    {
        public HeatsSecuredContext()
        {
        }

        public HeatsSecuredContext(DbContextOptions<HeatsSecuredContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CertsMcW> CertsMcW { get; set; }
        public virtual DbSet<CertsMill> CertsMill { get; set; }
        public virtual DbSet<Dies> Dies { get; set; }
        public virtual DbSet<HeatIssues> HeatIssues { get; set; }
        public virtual DbSet<HeatReceipts> HeatReceipts { get; set; }
        public virtual DbSet<MailingList> MailingList { get; set; }
        public virtual DbSet<RawMaterial> RawMaterial { get; set; }
        public virtual DbSet<SwitchboardItems> SwitchboardItems { get; set; }
        public virtual DbSet<TblCustomers> TblCustomers { get; set; }
        public virtual DbSet<TblDieWoqtyHt> TblDieWoqtyHt { get; set; }
        public virtual DbSet<TblDisclamerNote> TblDisclamerNote { get; set; }
        public virtual DbSet<TblPackingSlips> TblPackingSlips { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }

        // Unable to generate entity type for table 'dbo.TblAirFreight'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WGFC-DEV-SQL01;Database=HeatsSecured;user id=LoupeUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertsMcW>(entity =>
            {
                entity.HasKey(e => e.McWCn)
                    .IsClustered(false);

                entity.ToTable("Certs - McW");

                entity.HasIndex(e => e.Crn)
                    .HasName("CRN");

                entity.HasIndex(e => e.CustId)
                    .HasName("CustID");

                entity.HasIndex(e => e.Heat)
                    .HasName("Certs - McWHeat");

                entity.HasIndex(e => e.McWCn)
                    .HasName("McW-CN")
                    .IsUnique();

                entity.HasIndex(e => e.NoteType)
                    .HasName("Certs - McWNote Type");

                entity.Property(e => e.McWCn).HasColumnName("McW-CN");

                entity.Property(e => e.CertificationNotes)
                    .HasColumnName("Certification Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.Crn)
                    .HasColumnName("CRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustPo)
                    .HasColumnName("CustPO")
                    .HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Die).HasMaxLength(50);

                entity.Property(e => e.GsMcW)
                    .HasColumnName("GS-McW")
                    .HasMaxLength(10);

                entity.Property(e => e.Hardness).HasMaxLength(50);

                entity.Property(e => e.Heat).HasMaxLength(20);

                entity.Property(e => e.HeatTreatNotes)
                    .HasColumnName("Heat Treat Notes")
                    .HasColumnType("ntext");

                entity.Property(e => e.NoteType)
                    .HasColumnName("Note Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessNo)
                    .HasColumnName("Process No")
                    .HasMaxLength(50);

                entity.Property(e => e.QtyShipped).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrder)
                    .HasColumnName("Work Order")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CertsMill>(entity =>
            {
                entity.HasKey(e => e.Crn)
                    .IsClustered(false);

                entity.ToTable("Certs - Mill");

                entity.HasIndex(e => e.Heat)
                    .HasName("Certs - MillHeat");

                entity.HasIndex(e => e.MillId)
                    .HasName("Mill-ID");

                entity.HasIndex(e => e.Pwcode)
                    .HasName("PWCode");

                entity.Property(e => e.Crn).HasColumnName("CRN");

                entity.Property(e => e.BetaTransus)
                    .HasColumnName("Beta Transus")
                    .HasMaxLength(50);

                entity.Property(e => e.DateIn)
                    .HasColumnName("Date In")
                    .HasColumnType("datetime");

                entity.Property(e => e.Heat).HasMaxLength(20);

                entity.Property(e => e.HtDesc).HasMaxLength(20);

                entity.Property(e => e.Material).HasMaxLength(25);

                entity.Property(e => e.MillCn)
                    .HasColumnName("Mill-CN")
                    .HasMaxLength(15);

                entity.Property(e => e.MillId)
                    .HasColumnName("Mill-ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pwcode)
                    .HasColumnName("PWCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Spec).HasMaxLength(255);
            });

            modelBuilder.Entity<Dies>(entity =>
            {
                entity.HasKey(e => e.Die)
                    .IsClustered(false);

                entity.HasIndex(e => e.Die)
                    .HasName("Die");

                entity.HasIndex(e => e.PartNum)
                    .HasName("PartNum");

                entity.Property(e => e.Die)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AuxDoc)
                    .HasColumnName("Aux Doc")
                    .HasMaxLength(50);

                entity.Property(e => e.PartDescription)
                    .HasColumnName("Part Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PartNum).HasMaxLength(100);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.ProcessNo)
                    .HasColumnName("Process No")
                    .HasMaxLength(50);

                entity.Property(e => e.Revision).HasMaxLength(30);

                entity.Property(e => e.StdcertNotes)
                    .HasColumnName("STDCertNotes")
                    .HasColumnType("ntext");

                entity.Property(e => e.StdhtrNotes)
                    .HasColumnName("STDHtrNotes")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<HeatIssues>(entity =>
            {
                entity.HasKey(e => e.Crn)
                    .IsClustered(false);

                entity.ToTable("Heat Issues");

                entity.HasIndex(e => e.Crn)
                    .HasName("MCRN")
                    .IsUnique();

                entity.HasIndex(e => e.Die)
                    .HasName("Die");

                entity.HasIndex(e => e.Hrn)
                    .HasName("HRN");

                entity.HasIndex(e => e.HtCode)
                    .HasName("HtCode");

                entity.Property(e => e.Crn)
                    .HasColumnName("CRN")
                    .ValueGeneratedNever();

                entity.Property(e => e.Billet)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.BilletOut).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Die).HasMaxLength(10);

                entity.Property(e => e.Hrn)
                    .HasColumnName("HRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HtCode).HasMaxLength(4);

                entity.Property(e => e.Pieces).HasDefaultValueSql("((0))");

                entity.Property(e => e.Range).HasMaxLength(5);

                entity.Property(e => e.WorkOrder)
                    .HasColumnName("Work Order")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<HeatReceipts>(entity =>
            {
                entity.HasKey(e => e.Hrn)
                    .IsClustered(false);

                entity.ToTable("Heat Receipts");

                entity.HasIndex(e => e.BilletId)
                    .HasName("BilletID");

                entity.HasIndex(e => e.Crn)
                    .HasName("CRN");

                entity.HasIndex(e => e.Hrn)
                    .HasName("HRN")
                    .IsUnique();

                entity.HasIndex(e => e.VendorId)
                    .HasName("VendorID");

                entity.Property(e => e.Hrn).HasColumnName("HRN");

                entity.Property(e => e.BilletId)
                    .HasColumnName("BilletID")
                    .HasMaxLength(100);

                entity.Property(e => e.Billets).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsr)
                    .HasColumnName("BSR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crn)
                    .HasColumnName("CRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CutBillets).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.McWPo)
                    .HasColumnName("McW-PO")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Size).HasMaxLength(10);

                entity.Property(e => e.TotWt)
                    .HasColumnName("Tot-Wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CrnNavigation)
                    .WithMany(p => p.HeatReceipts)
                    .HasForeignKey(d => d.Crn)
                    .HasConstraintName("Heat Receipts_FK00");
            });

            modelBuilder.Entity<MailingList>(entity =>
            {
                entity.HasKey(e => e.MailingListId)
                    .IsClustered(false);

                entity.ToTable("Mailing List");

                entity.Property(e => e.MailingListId).HasColumnName("Mailing ListID");

                entity.Property(e => e.RollsRoyce)
                    .HasColumnName("Rolls Royce")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<RawMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialField)
                    .IsClustered(false);

                entity.ToTable("Raw Material");

                entity.HasIndex(e => e.MaterialField)
                    .HasName("Material Field")
                    .IsUnique();

                entity.Property(e => e.MaterialField)
                    .HasColumnName("Material Field")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SwitchboardItems>(entity =>
            {
                entity.HasKey(e => new { e.SwitchboardId, e.ItemNumber })
                    .IsClustered(false);

                entity.ToTable("Switchboard Items");

                entity.Property(e => e.SwitchboardId).HasColumnName("SwitchboardID");

                entity.Property(e => e.Argument).HasMaxLength(255);

                entity.Property(e => e.ItemText).HasMaxLength(255);
            });

            modelBuilder.Entity<TblCustomers>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .IsClustered(false);

                entity.HasIndex(e => e.CustomerName)
                    .HasName("Name1");

                entity.Property(e => e.CustId)
                    .HasColumnName("CustID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addr1).HasMaxLength(40);

                entity.Property(e => e.Addr2).HasMaxLength(40);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Contact).HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(40);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Name2).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.Zip).HasMaxLength(9);
            });

            modelBuilder.Entity<TblDieWoqtyHt>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("TblDieWOQtyHT");

                entity.HasIndex(e => e.McwHtCodes)
                    .HasName("HTCode");

                entity.Property(e => e.ControlNo).HasColumnName("Control No");

                entity.Property(e => e.Crn)
                    .HasColumnName("CRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.McwHtCodes)
                    .HasColumnName("MCW HT CODES")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessNo).HasMaxLength(50);

                entity.Property(e => e.Woqty)
                    .HasColumnName("WOQty")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkOrder).HasMaxLength(10);
            });

            modelBuilder.Entity<TblDisclamerNote>(entity =>
            {
                entity.HasKey(e => e.NoteType)
                    .IsClustered(false);

                entity.Property(e => e.NoteType)
                    .HasColumnName("Note Type")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.TestReportNotes)
                    .HasColumnName("Test Report Notes")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TblPackingSlips>(entity =>
            {
                entity.HasKey(e => e.Psn);

                entity.Property(e => e.Psn).HasColumnName("PSN");

                entity.Property(e => e.Crn)
                    .HasColumnName("CRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crn2)
                    .HasColumnName("CRN2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustPo)
                    .HasColumnName("Cust-PO")
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Die).HasMaxLength(50);

                entity.Property(e => e.Freight).HasMaxLength(50);

                entity.Property(e => e.ItemNumber)
                    .HasColumnName("Item Number")
                    .HasMaxLength(50);

                entity.Property(e => e.McWCn)
                    .HasColumnName("McW-CN")
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.NumberOfBoxes)
                    .HasColumnName("Number of Boxes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumberOfSkids)
                    .HasColumnName("Number of skids")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessNo)
                    .HasColumnName("Process No")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("Serial Number")
                    .HasColumnType("ntext");

                entity.Property(e => e.ShipAir).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipTo)
                    .HasColumnName("Ship to")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipVia)
                    .HasColumnName("Ship Via")
                    .HasMaxLength(50);

                entity.Property(e => e.SoldTo)
                    .HasColumnName("Sold to")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalWeight)
                    .HasColumnName("Total Weight")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkOrder)
                    .HasColumnName("Work Order")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vendors>(entity =>
            {
                entity.HasKey(e => e.MillId)
                    .IsClustered(false);

                entity.HasIndex(e => e.ZipCode)
                    .HasName("Zip Code");

                entity.Property(e => e.MillId)
                    .HasColumnName("Mill-ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Print).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("Zip Code")
                    .HasMaxLength(15);
            });
        }
    }
}
