using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsLibrary
{
    public class Features
    {
        public bool Laundry { get; set; }
        public bool Aircon { get; set; }
        public bool Breakfast { get; set; }
        public bool Shuttle { get; set; }

        public Features(bool laundry, bool aircon, bool breakfast, bool shuttle)
        {
            this.Laundry = laundry;
            this.Aircon = aircon;
            this.Breakfast = breakfast;
            this.Shuttle = shuttle;
        }
        
        public Features()
        {

        }
    }
}