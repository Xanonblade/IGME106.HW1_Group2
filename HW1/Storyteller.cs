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
            StreamReader sr;
            string line = "";
            try
            {
                sr = new StreamReader("../../../Setting.txt");

                // Read Settings
                while ((line = sr.ReadLine()!) != null)
                {
                    string location = line.Substring(0, line.IndexOf('|'));
                    string timePeriod = line.Substring(line.IndexOf('|') + 1);
                    settings.Add(new Setting(location, timePeriod));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Setting: " + e.Message);
            }
            
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Actor: " + e.Message);
            }

            try
            {
                sr = new StreamReader("../../../Conflict.txt");
                // Read conflict
                while ((line = sr.ReadLine()!) != null)
                {
                    conflicts.Add(new Conflict(line));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Conflict: " + e.Message);
            }

            try
            {
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
            catch (Exception e)
            {
                Console.WriteLine("Error reading Resolution: " + e.Message);
            }

        }

        /// <summary>
        /// Prints a random story based on the specified story type.
        /// </summary>
        /// <param name="storyType"></param>
        public void PrintStory(string storyType)
        {
            // Select random elements from each list and print the story
            Random rand = new Random();
            Setting setting = settings[rand.Next(settings.Count)];
            Actor char1 = actors[rand.Next(actors.Count)];
            Actor char2 = actors[rand.Next(actors.Count)];
            Conflict conflict = conflicts[rand.Next(conflicts.Count)];
            foreach (Resolution res in resolutions)
            {
                if (res.Type == storyType)
                {
                    Console.WriteLine("Once upon a time in " + setting.Location + " during the " + setting.TimePeriod + ", there lived a " + char1.Age + " year old " + char1.Profession + " named " + char1.Name + ".");
                    Console.WriteLine("One day, " + char1.Name + " met a " + char2.Age + " year old " + char2.Profession + " named " + char2.Name + ".");
                    Console.WriteLine("However, they soon faced a problem: " + conflict.Problem);
                    Console.WriteLine("In the end, they managed to resolve it by: " + res.Solution);
                    break;
                }
            }
        }

    }
}
