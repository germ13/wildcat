using System.ComponentModel.DataAnnotations.Schema;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class GasMeter
    {
        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public float PercentComplete { get; set; }
        [NotMapped]
        public float PercentIncomplete { get; set; }


    }
}
