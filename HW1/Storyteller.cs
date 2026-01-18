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

            sr = new StreamReader("../../../Setting.txt");
            try
            {
                // Read Settings
                while ((line = sr.ReadLine()!) != null)
                {
                    string location = line.Substring(0, line.IndexOf('|'));
                    string timePeriod = line.Substring(line.IndexOf('|') + 1);
                    settings.Add(new Setting(location, timePeriod));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Setting: " + e.Message);
            }
            finally
            {
                if (sr != null!)
                {
                    sr.Close();
                }
            }

            sr = new StreamReader("../../../Actor.txt");
            try
            {
                
                // Read Actors
                while ((line = sr.ReadLine()!) != null)
                {
                    string name = line.Substring(0, line.IndexOf('|'));
                    line = line.Substring(line.IndexOf('|') + 1);
                    string age = line.Substring(0, line.IndexOf('|'));
                    line = line.Substring(line.IndexOf('|') + 1);
                    string profession = line;

                    actors.Add(new Actor(name, age, profession));
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Actor: " + e.Message);
            }
            finally
            {
                if (sr != null!)
                {
                    sr.Close();
                }
            }

            sr = new StreamReader("../../../Conflict.txt");
            try
            {
                // Read conflict
                while ((line = sr.ReadLine()!) != null)
                {
                    conflicts.Add(new Conflict(line));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Conflict: " + e.Message);
            }
            finally
            {
                if (sr != null!)
                {
                    sr.Close();
                }
            }

            sr = new StreamReader("../../../Resolution.txt");
            try
            {
                // Read Resolution
                while ((line = sr.ReadLine()!) != null)
                {
                    string type = line.Substring(0, line.IndexOf('|'));
                    string solution = line.Substring(line.IndexOf('|') + 1);
                    resolutions.Add(new Resolution(type, solution));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading Resolution: " + e.Message);
            }
            finally
            {
                if (sr != null!)
                {
                    sr.Close();
                }
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
            // Ensure char1 and char2 are different
            int index1 = rand.Next(actors.Count);
            Actor char1 = actors[index1];
            int index2 = rand.Next(actors.Count);
            while (index2 == index1)
                index2 = rand.Next(actors.Count);

            Actor char2 = actors[index2];

            Conflict conflict = conflicts[rand.Next(conflicts.Count)];
            foreach (Resolution res in resolutions)
            {
                if (res.Type == storyType)
                {
                    Console.WriteLine("Once upon a time in " + setting.Location + " during the year " + setting.TimePeriod + ", there lived a " + char1.Age + " year old " + char1.Profession + " named " + char1.Name + ".");
                    Console.WriteLine("One day, " + char1.Name + " met a " + char2.Age + " year old " + char2.Profession + " named " + char2.Name + ".");
                    Console.WriteLine("However, they soon faced a problem: " + conflict.Problem);
                    string resolution = res.Solution;
                    if (resolution.IndexOf("@1") != -1)
                    {
                        resolution = resolution.Replace("@1", char1.Name);
                    }
                    if (resolution.IndexOf("#1") != -1)
                    {
                        resolution = resolution.Replace("#1", char2.Name);
                    }
                    if (resolution.IndexOf("@2") != -1)
                    {
                        resolution = resolution.Replace("@2", char1.Profession);
                    }
                    if (resolution.IndexOf("#2") != -1)
                    {
                        resolution = resolution.Replace("#2", char1.Profession);
                    }
                    if (resolution.IndexOf("@3") != -1)
                    {
                        resolution = resolution.Replace("@3", char1.Age);
                    }
                    if (resolution.IndexOf("#3") != -1)
                    {
                        resolution = resolution.Replace("#3", char1.Age);
                    }
                    Console.WriteLine(resolution);
                    break;
                }
            }
        }

    }
}
