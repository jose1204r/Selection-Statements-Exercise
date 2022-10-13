namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ******************** Exercise Selection Statement *********************************


            Console.WriteLine("******** Welcome to Ramdon Game********* ");
            Console.WriteLine("Try if can guess the correct number!");
            Console.WriteLine("What is the upper limit for the rang");

            Console.WriteLine(" PLEASE ENTER THE NUMBER : ");

            var userResponse = int.Parse(Console.ReadLine());
            var userpick = (userResponse);

            var r = new Random();
            var favoriteNumber = r.Next(1,userpick);
           

            if (userResponse > favoriteNumber)
            {
                Console.WriteLine("Hi Player! too high ");

            }

            else if (userResponse < favoriteNumber) {
                Console.WriteLine("opp! Player too low ");

            }
            else 
                    {
                Console.WriteLine("*** Great! Player you got the rigth number ****");
            }

            
        }
    }
}