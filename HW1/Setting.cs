using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Setting
    {
        // Fields
        private string location;
        private string timePeriod;

        // Constructor
        public Setting(string location, string timePeriod)
        {
            this.location = location;
            this.timePeriod = timePeriod;
        }

        // Properties

        /// <summary>
        /// Getter for location
        /// </summary>
        public string Location { get { return location; } }

        /// <summary>
        /// Getter for timePeriod
        /// </summary>
        public string TimePeriod { get { return timePeriod; } }
    }
}
