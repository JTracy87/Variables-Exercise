namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string customerName = "Joseph";

            int disneylandTrips = 4;

            char tripScore = 'A';

            bool isSatisfied = true;

            double parkHop = 2;

            decimal moneySpent = 725.25m;

            Console.WriteLine($"Hello {customerName}, you have been to Disneyland {disneylandTrips} times.");
            Console.WriteLine($"You have given your trip a score of {tripScore}.");
            Console.WriteLine($"When asked if you were satisfied with your trip, you responded with {isSatisfied}.");
            Console.WriteLine($"On your last trip, you park hopped {parkHop} times and spent ${moneySpent}.");
        }
    }
}
