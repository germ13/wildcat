using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.CFCA.Planning
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CfwAccuBarDistro> CfwAccuBarDistro { get; set; }
        public virtual DbSet<CfwAccuCutTicket> CfwAccuCutTicket { get; set; }
        public virtual DbSet<CfwAccuInventory> CfwAccuInventory { get; set; }
        public virtual DbSet<CfwAccuMultCount> CfwAccuMultCount { get; set; }
        public virtual DbSet<CfwAccuPlanHeader> CfwAccuPlanHeader { get; set; }
        public virtual DbSet<CfwAccuSn> CfwAccuSn { get; set; }
        public virtual DbSet<WipEntitiesShell> WipEntitiesShell { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("data source=houcfwdb2.precastcorp.com:1613/pccfw;user id=apps;password=appsnprd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "APPS_TS_TX_DATA");

            modelBuilder.Entity<CfwAccuBarDistro>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_BAR_DISTRO_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_BAR_DISTRO_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.BarIngotNumber)
                    .HasColumnName("BAR_INGOT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("GROSS_WEIGHT")
                    .HasMaxLength(20);

                entity.Property(e => e.JobNumber)
                    .HasColumnName("JOB_NUMBER")
                    .HasMaxLength(20);

                entity.Property(e => e.MultCount)
                    .HasColumnName("MULT_COUNT")
                    .HasMaxLength(20);

                entity.Property(e => e.OneEquals)
                    .HasColumnName("ONE_EQUALS")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingBarWeight).HasColumnName("STARTING_BAR_WEIGHT");

                entity.Property(e => e.TotalWeight).HasColumnName("TOTAL_WEIGHT");

                entity.Property(e => e.WgHeatNumber)
                    .HasColumnName("WG_HEAT_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");
            });

            modelBuilder.Entity<CfwAccuCutTicket>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_CUT_TICKET_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_CUT_TICKET_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.BarIngotNumber)
                    .IsRequired()
                    .HasColumnName("BAR_INGOT_NUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.BarIngotNumberId).HasColumnName("BAR_INGOT_NUMBER_ID");

                entity.Property(e => e.CutWeight)
                    .HasColumnName("CUT_WEIGHT")
                    .HasMaxLength(40);

                entity.Property(e => e.PieceCount).HasColumnName("PIECE_COUNT");

                entity.Property(e => e.StartingBarWeight).HasColumnName("STARTING_BAR_WEIGHT");

                entity.Property(e => e.Stockshape)
                    .HasColumnName("STOCKSHAPE")
                    .HasMaxLength(40);

                entity.Property(e => e.Stocksize1)
                    .HasColumnName("STOCKSIZE1")
                    .HasMaxLength(40);

                entity.Property(e => e.WgHeatNumber)
                    .IsRequired()
                    .HasColumnName("WG_HEAT_NUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");
            });

            modelBuilder.Entity<CfwAccuInventory>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_INVENTORY_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_INVENTORY_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateReceived)
                    .HasColumnName("DATE_RECEIVED")
                    .HasColumnType("DATE");

                entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");

                entity.Property(e => e.LotNumber)
                    .HasColumnName("LOT_NUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.MaterialCost).HasColumnName("MATERIAL_COST");

                entity.Property(e => e.MetalAlloy)
                    .HasColumnName("METAL_ALLOY")
                    .HasMaxLength(480);

                entity.Property(e => e.MetalName)
                    .HasColumnName("METAL_NAME")
                    .HasMaxLength(480);

                entity.Property(e => e.MetalShape)
                    .HasColumnName("METAL_SHAPE")
                    .HasMaxLength(480);

                entity.Property(e => e.MetalSize).HasColumnName("METAL_SIZE");

                entity.Property(e => e.MetalSpec1)
                    .HasColumnName("METAL_SPEC1")
                    .HasMaxLength(480);

                entity.Property(e => e.MetalSpec2)
                    .HasColumnName("METAL_SPEC2")
                    .HasMaxLength(480);

                entity.Property(e => e.RmItemNumber)
                    .HasColumnName("RM_ITEM_NUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.TransactionQuantity).HasColumnName("TRANSACTION_QUANTITY");
            });

            modelBuilder.Entity<CfwAccuMultCount>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_MULT_COUNT_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_MULT_COUNT_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.CutWeight)
                    .HasColumnName("CUT_WEIGHT")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("GROSS_WEIGHT")
                    .HasMaxLength(20);

                entity.Property(e => e.MultCount)
                    .HasColumnName("MULT_COUNT")
                    .HasMaxLength(20);

                entity.Property(e => e.OneEquals)
                    .HasColumnName("ONE_EQUALS")
                    .HasMaxLength(20);

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");
            });

            modelBuilder.Entity<CfwAccuPlanHeader>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_PLAN_HEADER_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_PLAN_HEADER_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.AltDescription)
                    .HasColumnName("ALT_DESCRIPTION")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("CUSTOMER_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerNumber)
                    .HasColumnName("CUSTOMER_NUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(40);

                entity.Property(e => e.EngineProgram)
                    .HasColumnName("ENGINE_PROGRAM")
                    .HasMaxLength(40);

                entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");

                entity.Property(e => e.JobStatus)
                    .HasColumnName("JOB_STATUS")
                    .HasMaxLength(40);

                entity.Property(e => e.LotSize)
                    .HasColumnName("LOT_SIZE")
                    .HasMaxLength(40);

                entity.Property(e => e.Material1)
                    .HasColumnName("MATERIAL1")
                    .HasMaxLength(40);

                entity.Property(e => e.Material2)
                    .HasColumnName("MATERIAL2")
                    .HasMaxLength(40);

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("MATERIAL_CODE")
                    .HasMaxLength(40);

                entity.Property(e => e.Materialnotes)
                    .HasColumnName("MATERIALNOTES")
                    .HasMaxLength(40);

                entity.Property(e => e.MetalSpec1)
                    .HasColumnName("METAL_SPEC1")
                    .HasMaxLength(40);

                entity.Property(e => e.Partdescription)
                    .HasColumnName("PARTDESCRIPTION")
                    .HasMaxLength(40);

                entity.Property(e => e.Partnumber)
                    .HasColumnName("PARTNUMBER")
                    .HasMaxLength(40);

                entity.Property(e => e.PrimaryItemId).HasColumnName("PRIMARY_ITEM_ID");

                entity.Property(e => e.Primarygrossweight)
                    .HasColumnName("PRIMARYGROSSWEIGHT")
                    .HasMaxLength(40);

                entity.Property(e => e.Primarymultcount)
                    .HasColumnName("PRIMARYMULTCOUNT")
                    .HasMaxLength(40);

                entity.Property(e => e.Primarymultweight)
                    .HasColumnName("PRIMARYMULTWEIGHT")
                    .HasMaxLength(40);

                entity.Property(e => e.RmSize)
                    .HasColumnName("RM_SIZE")
                    .HasMaxLength(40);

                entity.Property(e => e.ShortText)
                    .HasColumnName("SHORT_TEXT")
                    .HasMaxLength(40);

                entity.Property(e => e.Stockshape)
                    .HasColumnName("STOCKSHAPE")
                    .HasMaxLength(40);

                entity.Property(e => e.Stocksize1)
                    .HasColumnName("STOCKSIZE1")
                    .HasMaxLength(40);

                entity.Property(e => e.Totalweight).HasColumnName("TOTALWEIGHT");

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");

                entity.Property(e => e.WipEntityName)
                    .HasColumnName("WIP_ENTITY_NAME")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CfwAccuSn>(entity =>
            {
                entity.HasKey(e => e.TableKey);

                entity.ToTable("CFW_ACCU_SN_V");

                entity.HasIndex(e => e.TableKey)
                    .HasName("CFW_ACCU_SN_PK")
                    .IsUnique();

                entity.Property(e => e.TableKey)
                    .HasColumnName("TABLE_KEY")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerSerialNumber)
                    .HasColumnName("CUSTOMER_SERIAL_NUMBER")
                    .HasMaxLength(200);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasMaxLength(200);

                entity.Property(e => e.SnAssignmentId).HasColumnName("SN_ASSIGNMENT_ID");

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");

                entity.Property(e => e.WipEntityName)
                    .IsRequired()
                    .HasColumnName("WIP_ENTITY_NAME")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<WipEntitiesShell>(entity =>
            {
                entity.HasKey(e => new { e.WipEntityId, e.OrganizationId });

                entity.ToTable("WIP_ENTITIES");

                entity.HasIndex(e => new { e.WipEntityId, e.OrganizationId })
                    .HasName("WIP_ENTITIES_SHELL_PK")
                    .IsUnique();

                entity.Property(e => e.WipEntityId).HasColumnName("WIP_ENTITY_ID");

                entity.Property(e => e.OrganizationId).HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100);

                entity.Property(e => e.EntityType).HasColumnName("ENTITY_TYPE");

                entity.Property(e => e.GenObjectId).HasColumnName("GEN_OBJECT_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.LastUpdateLogin).HasColumnName("LAST_UPDATE_LOGIN");

                entity.Property(e => e.LastUpdatedBy).HasColumnName("LAST_UPDATED_BY");

                entity.Property(e => e.PrimaryItemId).HasColumnName("PRIMARY_ITEM_ID");

                entity.Property(e => e.ProgramApplicationId).HasColumnName("PROGRAM_APPLICATION_ID");

                entity.Property(e => e.ProgramId).HasColumnName("PROGRAM_ID");

                entity.Property(e => e.ProgramUpdateDate)
                    .HasColumnName("PROGRAM_UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.RequestId).HasColumnName("REQUEST_ID");

                entity.Property(e => e.WipEntityName)
                    .IsRequired()
                    .HasColumnName("WIP_ENTITY_NAME")
                    .HasMaxLength(100);
            });
        }
    }
}
