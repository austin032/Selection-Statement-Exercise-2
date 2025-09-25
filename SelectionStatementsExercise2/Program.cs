namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't do well with numbers");
                    break;
                case "science":
                    Console.WriteLine("Science is not my favorite school subject");
                    break;
                case "history":
                    Console.WriteLine("History is not my favorite school subject");
                    break;
                case "english":
                    Console.WriteLine("I don't like writing essays");
                    break;
                case "gym":
                    Console.WriteLine("Gym is my favorite school subject because I like to exercise");
                    break;
                default:
                    Console.WriteLine("I enjoy that subject as well");
                    break;
            }
        }
    }
}