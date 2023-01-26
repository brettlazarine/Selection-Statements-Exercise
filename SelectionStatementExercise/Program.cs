namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var favNumber = 44;
            Console.Write("Guess my favorite number: ");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
            // Completed Extra Switch Statement Practice on Codewars
        }
    }
}
