// Corey Stinson
// 1/18/26
// Handles creating random stories

namespace HW1
{
    internal class Storyteller
    {
        // Fields
        private List<Setting> settings;
        private List<Actor> actors;
        private List<Conflict> conflicts;
        private List<Resolution> resolutions;

        // Constructor
        public Storyteller()
        {
            settings = new List<Setting>();
            actors = new List<Actor>();
            conflicts = new List<Conflict>();
            resolutions = new List<Resolution>();
        }

        /// <summary>
        /// Reads all of the files and stores their information in a corresponding list
        /// </summary>
        public void ReadFile()
        {
            StreamReader sr = new StreamReader("../../../Setting.txt");
            string line = "";

            // Read Settings
            while ((line = sr.ReadLine()!) != null)
            {
                string location = line.Substring(0, line.IndexOf('|'));
                string timePeriod = line.Substring(line.IndexOf('|') + 1);
                settings.Add(new Setting(location, timePeriod));
            }
            sr.Close();

            sr = new StreamReader("../../../Actor.txt");
            // Read Actors
            while ((line = sr.ReadLine()!) != null)
            {
                string name = line.Substring(0, line.IndexOf('|'));
                line = line.Substring(line.IndexOf('|') + 1);
                string age = line.Substring(0, line.IndexOf('|'));
                line = line.Substring(line.IndexOf('|') + 1);
                string profession = line;

                actors.Add(new Actor(name, profession, age));
            }
            sr.Close();

            sr = new StreamReader("../../../Conflict.txt");
            // Read conflict
            while ((line = sr.ReadLine()!) != null)
            {
                conflicts.Add(new Conflict(line));
            }
            sr.Close();

            sr = new StreamReader("../../../Resolution.txt");
            // Read Resolution
            while ((line = sr.ReadLine()!) != null)
            {
                string type = line.Substring(0, line.IndexOf('|'));
                string solution = line.Substring(line.IndexOf('|') + 1);
                resolutions.Add(new Resolution(type, solution));
            }
            sr.Close();
        }

    }
}
