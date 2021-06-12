using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class ShultzProContext : DbContext
    {
        public virtual DbSet<CheckRunDates> CheckRuns { get; set; }
    }

    public partial class CheckRunDates
    {
        [Key]
        public DateTime TransactionDate { get; set; }
        public int itemcount { get; set; }
    }
}
