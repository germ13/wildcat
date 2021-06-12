using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Wildcat.Entities.SHCA.Grinders.FGD
{
    public partial class FGDContext : DbContext
    {
        public virtual DbSet<DatetimeDTO> TimeDTO { get; set; }
    }

    public partial class DatetimeDTO
    {
        [Key]
        public DateTime? _TIMESTAMP { get; set; }
    }
}
