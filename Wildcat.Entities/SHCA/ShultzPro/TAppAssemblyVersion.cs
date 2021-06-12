using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAppAssemblyVersion
    {
        public int IDbversionKey { get; set; }
        public string SAssemblyName { get; set; }
        public int IAssemblyMajor { get; set; }
        public int IAssemblyMinor { get; set; }
        public int IAssemblyBuild { get; set; }
        public DateTime DtCreatedDate { get; set; }
        public string SUpdateUser { get; set; }

        public TAppDbversion IDbversionKeyNavigation { get; set; }
    }
}
