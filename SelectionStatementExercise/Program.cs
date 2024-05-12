
namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 10);
            int userInput = 0;

            while(userInput != favNumber)
            {
                
            }
            Console.WriteLine("Guess my favorite number (1:");
            userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"Too low!\nYour guess: {userInput}");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"Too high!\nYour guess: {userInput}");
            }
            else
            {
                Console.WriteLine($"You guessed it!\nYour guess: {userInput}");
            }
        }
    }
}
