using System;

namespace Wildcat.Entities.CFCA.Planning
{
    public partial class WipEntitiesShell
    {
        public int WipEntityId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedBy { get; set; }
        public int? LastUpdateLogin { get; set; }
        public int? RequestId { get; set; }
        public int? ProgramApplicationId { get; set; }
        public int? ProgramId { get; set; }
        public DateTime? ProgramUpdateDate { get; set; }
        public string WipEntityName { get; set; }
        public int EntityType { get; set; }
        public string Description { get; set; }
        public int? PrimaryItemId { get; set; }
        public int? GenObjectId { get; set; }
    }
}
