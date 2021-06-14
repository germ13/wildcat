using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wildcat.App.Classes
{
    //TODO renamespace
    public class ScatterDataStructure
    {
        public string date { get; set; }
        public int pct05 { get; set; }
        public int pct25 { get; set; }
        public int pct50 { get; }
        public int pct75 { get; set; }
        public int pct95 { get; set; }

        public ScatterDataStructure()
        {
            date = new DateTime(2000, 1, 1).ToString("yyyy-MM-dd");

            pct05 = -500;
            pct25 = -300;
            pct50 = 0;
            pct75 = 300;
            pct95 = 500;
        }
    }
}
