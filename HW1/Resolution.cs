using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    /// <summary>
    /// Contains a solution and represents a resolution.
    /// </summary>
    internal class Resolution
    {
        public enum ResolutionType
        {
            happy,
            tragic,
            romantic,
            funny,
            twist
        }
        public ResolutionType Type { get; private set; }
        public string Solution { get; private set; }

        /// <summary>
        /// Sets the type and solution of the resolution.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="solution"></param>
        public Resolution(ResolutionType type, string solution)
        {
            Type = type;
            Solution = solution;
        }
    }
}
