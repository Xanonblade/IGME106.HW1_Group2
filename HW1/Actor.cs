using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Actor
    {
        // Fields
        private string name;
        private string profession;
        private string age;

        // Constructor
        public Actor(string name, string profession, string age)
        {
            this.name = name;
            this.profession = profession;
            this.age = age;
        }

        // Properties

        /// <summary>
        /// Getter for name
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Getter for profession
        /// </summary>
        public string Profession { get { return profession; } }

        /// <summary>
        /// Getter for age
        /// </summary>
        public string Age { get { return age; } }
    }
}
