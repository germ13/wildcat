using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wildcat.App.Classes
{
    //TODO renamespace
    public class ScatterMarkerStructure
    {
        public string date { get; set; }
        public string type { get; }
        public double altitude { get; set; }

        public ScatterMarkerStructure()
        {
            date = new DateTime(2000, 1, 1).ToString("yyyy-MM-dd");
            type = "hollowBall";
        }
    }
}
