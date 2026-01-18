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
                        // Run print method with 'happy' parameter
                        //Resolution.ResolutionType.happy;

                        break;
                    case "tragic":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a tragic ending>");
                        // Run print method with 'tragic' parameter
                        break;
                    case "romantic":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a romantic ending>");
                        // Run print method with 'romantic' parameter
                        break;
                    case "funny":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a funny ending>");
                        // Run print method with 'funny' parameter
                        break;
                    case "twist":
                        Console.WriteLine("Story idea: ");
                        Console.WriteLine("<Story with a twist ending>");
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
