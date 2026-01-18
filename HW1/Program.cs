//Laurin Zanon
//Corey Stinson
//Sly Cash
//Lucas Kishore
//1/18/26
namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Storyteller Object and read files
            Storyteller storyteller = new Storyteller();
            storyteller.ReadFile("Adventure");

            // Run program for user to generate stories
            bool running = true;
            while (running)
            {
                // Prompt user for type of ending
                Console.WriteLine("Choose a type of ending: 'happy'  'tragic'  'romantic'  'funny'  'twist'  'any ending' ");
                string userInput = Console.ReadLine()!.ToLower();
                // Extra space
                Console.WriteLine();

                // Chooses ending based on user input
                switch (userInput)
                {
                    case "happy":
                        // Run print method with 'happy' parameter
                        break;
                    case "tragic":
                        // Run print method with 'tragic' parameter
                        break;
                    case "romantic":
                        // Run print method with 'romantic' parameter
                        break;
                    case "funny":
                        // Run print method with 'funny' parameter
                        break;
                    case "twist":
                        // Run print method with 'twist' parameter
                        break;
                    case "any ending":
                        // Generate random ending type
                        Random rng = new Random();
                        int endingType = rng.Next(1, 6);
                        string ending = "";
                        if (endingType == 1)
                            ending = "happy";
                        else if (endingType == 2)
                            ending = "tragic";
                        else if (endingType == 3)
                            ending = "romantic";
                        else if (endingType == 4)
                            ending = "funny";
                        else if (endingType == 5)
                            ending = "twist";
                        // Run print method with 'ending' parameter
                        break;
                }
            }
        }
    }
}
