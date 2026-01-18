using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    /// <summary>
    /// Contains a problem and represents a conflict.
    /// </summary>
    internal class Conflict
    {
        public string Problem { get; private set; }

        /// <summary>
        /// Sets the problem of the conflict.
        /// </summary>
        /// <param name="problem"></param>
        public Conflict(string problem)
        {
            Problem = problem;
        }
    }
}
