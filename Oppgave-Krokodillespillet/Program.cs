namespace Oppgave_Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int points = 0;
            bool gameOn = true;

            Console.WriteLine("Write in the correct operator to gain points!");
            Console.WriteLine("And when you write the wrong operator you lose points >:)");
            Console.WriteLine("The operators are < , > and =");
            Console.WriteLine();

            CrocodileGame();
            void CrocodileGame()
            {
                while(gameOn){
                int num1 = r.Next(1,11);
                int num2 = r.Next(1,11);
                
                Console.WriteLine($"points: {points}");
                Console.WriteLine($"{num1} _ {num2}");

                string userInput = Console.ReadLine();

                if (userInput == "=")
                {
                    if (num1 == num2) points++;
                    else points--;
                } 
                else if (userInput == "<")
                {
                    if (num1 < num2) points++;
                    else points--;
                }
                else if (userInput == ">")
                {
                    if (num1 > num2) points++;
                    else points--;
                }
                else
                {
                    gameOn = false;
                    Console.WriteLine($"Your final score was {points}!");
                }
                

                Console.WriteLine();
                CrocodileGame();
                }
            }


        }
    }
}
