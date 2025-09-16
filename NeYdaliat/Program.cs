class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Здаров,это игра камень ножницы бумага!");
            var WordsUsed = new List<string>{ "rock", "paper", "scissors" };
            var Player1 = Console.ReadLine().ToLower();
            if (!WordsUsed.Contains(Player1))
            {
                Console.WriteLine("Error! You Fucking stupid SCOVORODKA Blyat!!!!");
                continue;
            }
            var Player2 = Console.ReadLine().ToLower();
            if (!WordsUsed.Contains(Player2))
            {
                Console.WriteLine("Error! You Fucking stupid SCOVORODKA Blyat!!!!");
                continue;
            }
            if (Player1 == "rock" && Player2 == "scissors")
            {
                Console.WriteLine("Player1 Wins!");
            }
            if (Player1 == "rock" && Player2 == "paper")
            {
                Console.WriteLine("Player2 Wins!");
            }
            if (Player1 == Player2)
            {
                Console.WriteLine("Draw!!! Restart Game");
            }
            if (Player1 == "paper" && Player2 == "scissors")
            {
                Console.WriteLine("Player2 Wins!");
            }
            if (Player1 == "paper" && Player2 == "rock")
            {
                Console.WriteLine("Player1 Wins!");
            }
            if (Player1 == "scissors" && Player2 == "rock")
            {
                Console.WriteLine("Player2 Wins!");
            }
            if (Player1 == "scissors" && Player2 == "paper")
            {
                Console.WriteLine("Player1 Wins!");
            }
        }
            
    }
        enum Game { Rock, paper, scissors }
        
}