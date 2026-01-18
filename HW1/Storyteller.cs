// Corey Stinson
// 1/18/26
// Handles creating random stories

namespace HW1
{
    internal class Storyteller
    {
        private List<Setting> settings;
        private List<Actor> actors;
        private List<Conflict> conflicts;
        private List<Resolution> resolutions;

        public Storyteller()
        {
            settings = new List<Setting>();
            actors = new List<Actor>();
            conflicts = new List<Conflict>();
            resolutions = new List<Resolution>();
        }

        public void ReadFile(string storyType)
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

            sr = new StreamReader("../../../Actor.txt");

            // Read Actors
            while ((line = sr.ReadLine()!) != null)
            {
                string name = line.Substring(0, line.IndexOf('|'));
                string age = line.Substring(line.IndexOf('|') + 1);
                string profession = line.Substring(line.IndexOf('|') + 1);

            }
        }
    }
}
