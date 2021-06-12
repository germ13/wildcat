using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Wildcat.Entities.SHCA.EngineeringData
{
    public partial class EngineeringDataContext : DbContext
    {
        public virtual DbSet<DatetimeDTO> GrinderTimeDTO { get; set; }
    }

    public partial class DatetimeDTO
    {
        [Key]
        public DateTime? _TIMESTAMP { get; set; }
    }
}
