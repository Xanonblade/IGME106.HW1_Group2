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
        /// <summary>
        /// Constructs actor with corresponding name, profession age
        /// </summary>
        /// <param name="name">Name of actor</param>
        /// <param name="profession">Profession of actor</param>
        /// <param name="age">Age of actor</param>
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
