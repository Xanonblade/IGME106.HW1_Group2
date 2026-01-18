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
            storyteller.ReadFile();

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
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a happy ending>");
                        Console.WriteLine();
                        // Run print method with 'happy' parameter
                        storyteller.PrintStory("happy");

                        break;
                    case "tragic":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a tragic ending>");
                        Console.WriteLine();
                        // Run print method with 'tragic' parameter
                        storyteller.PrintStory("tragic");
                        break;
                    case "romantic":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a romantic ending>");
                        Console.WriteLine();
                        // Run print method with 'romantic' parameter
                        storyteller.PrintStory("romantic");
                        break;
                    case "funny":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a funny ending>");
                        Console.WriteLine();
                        // Run print method with 'funny' parameter
                        storyteller.PrintStory("funny");
                        break;
                    case "twist":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a twist ending>");
                        Console.WriteLine();
                        // Run print method with 'twist' parameter
                        storyteller.PrintStory("twist");
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
                        else
                            ending = "twist";
                        // Run print method with 'ending' parameter
                        Console.WriteLine();
                        storyteller.PrintStory(ending);
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        Console.WriteLine();
                        break;
                }
                // Extra space for readability
                Console.WriteLine();

                // Prompt user to continue or exit
                Console.WriteLine("Would you like another story? ('yes' or 'no')");
                string continueInput = Console.ReadLine()!.ToLower();
                if (continueInput == "no")
                    running = false;
            }
        }
    }
}
