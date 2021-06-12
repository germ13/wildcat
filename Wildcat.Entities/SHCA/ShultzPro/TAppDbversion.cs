using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAppDbversion
    {
        public TAppDbversion()
        {
            TAppAssemblyVersion = new HashSet<TAppAssemblyVersion>();
        }

        public int IDbversionKey { get; set; }
        public int IMajorVersion { get; set; }
        public int IMinorVersion { get; set; }
        public int IRevision { get; set; }
        public DateTime DtVersionDate { get; set; }
        public string SUpdateUser { get; set; }

        public ICollection<TAppAssemblyVersion> TAppAssemblyVersion { get; set; }
    }
}
