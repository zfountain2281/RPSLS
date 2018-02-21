using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class HumanVsComputer
    {
        public void HvC()
        {


            List<string> listOfGestures = new List<string>();
            listOfGestures.Add("rock");
            listOfGestures.Add("paper");
            listOfGestures.Add("scissors");
            listOfGestures.Add("lizard");
            listOfGestures.Add("spock");

            int win = 0;
            int lose = 0;
            int tie = 0;

            var newGame = true;
            while (newGame)
            {
                var playerGesture = "";
                var validInput = false;
                while (!validInput)
                {
                    var playerChoice = -1;
                    Console.WriteLine("Please choose your Gesture ");
                    gameSetup(listOfGestures);
                    try
                    {
                        playerChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        validInput = false;
                    }

                    if (playerChoice > 0 && playerChoice <= listOfGestures.Count)
                    {
                        playerGesture = listOfGestures[playerChoice - 1];
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                }

                var computerPlay = ComputerGesture(listOfGestures);

                Console.WriteLine("Computer: " + computerPlay);
                Console.WriteLine("your Gesture: " + playerGesture);

                if (playerGesture == computerPlay)
                {
                    tie++;
                    Console.WriteLine("you have tied with the computer");
                    Console.WriteLine("Computer: " + computerPlay);
                    Console.WriteLine("your Gesture: " + playerGesture);
                }
                else
                {
                    if (playerGesture == "rock")
                    {
                        if (computerPlay == "lizard" || computerPlay == "scissors")
                        {
                            Console.WriteLine("You Win, " + playerGesture + " Crushes " + computerPlay);
                            win++;
                        }
                        else if (computerPlay == "paper")
                        {
                            Console.WriteLine("You Lose, Paper Covers Rock");
                            lose++;
                        }
                        else if (computerPlay == "spock")
                        {
                            Console.WriteLine("You Lose, Spock Vaporizes Rock");
                            lose++;
                        }
                    }
                    else if (playerGesture == "paper")
                    {
                        if (computerPlay == "spock")
                        {
                            Console.WriteLine("You Win, Paper Disproves Spock");
                            win++;
                        }
                        else if (computerPlay == "rock")
                        {
                            Console.WriteLine("You Win, Paper Covers Rock");
                            win++;
                        }
                        else if (computerPlay == "lizard")
                        {
                            Console.WriteLine("You Lose, Lizard Eats Paper");
                            lose++;
                        }
                        else if (computerPlay == "scissors")
                        {
                            Console.WriteLine("You Lose, Scissors Cut Paper");
                            lose++;
                        }
                    }
                    else if (playerGesture == "scissors")
                    {
                        if (computerPlay == "paper")
                        {
                            Console.WriteLine("You Win, Scissors Cut Paper");
                            win++;
                        }
                        else if (computerPlay == "lizard")
                        {
                            Console.WriteLine("You Win, Scissors Decapitate Lizard");
                            win++;
                        }
                        else if (computerPlay == "rock")
                        {
                            Console.WriteLine("You Lose, Rock Crushes Scissors");
                            lose++;
                        }
                        else if (computerPlay == "spock")
                        {
                            Console.WriteLine("You Lose, Spock Smashes Scissors");
                            lose++;
                        }
                    }
                    else if (playerGesture == "lizard")
                    {
                        if (computerPlay == "paper")
                        {
                            Console.WriteLine("You Win, Lizard Eats Paper");
                            win++;
                        }
                        else if (computerPlay == "spock")
                        {
                            Console.WriteLine("You Win, Lizard Poisons Spock");
                            win++;
                        }
                        else if (computerPlay == "scissors")
                        {
                            Console.WriteLine("You Lose, Scissors Decapitates Lizard");
                            lose++;
                        }
                        else if (computerPlay == "rock")
                        {
                            Console.WriteLine("You Lose, Rock Crushes Lizard");
                            lose++;
                        }
                    }
                    else if (playerGesture == "spock")
                    {
                        if (computerPlay == "rock")
                        {
                            Console.WriteLine("You Win, Spock Vaporizes Rock");
                            win++;
                        }
                        else if (computerPlay == "scissors")
                        {
                            Console.WriteLine("You Win, Spock Smashes Scissors");
                            win++;
                        }
                        else if (computerPlay == "paper")
                        {
                            Console.WriteLine("You Lose, Paper Disproves Spock");
                            lose++;
                        }
                        else if (computerPlay == "lizard")
                        {
                            Console.WriteLine("You Lose, Lizard Poisons Spock");
                            lose++;
                        }
                    }
                }
                Console.WriteLine("Your Score is (W:L:T:) : {0}:{1}:{2}", win, lose, tie);

                Console.WriteLine("Again? Type 'no' to leave game.");
                if (Convert.ToString(Console.ReadLine().ToLower()) == "no")
                {
                    Console.WriteLine("would you like to reset your Score?");
                    if (Convert.ToString(Console.ReadLine().ToLower()) == "yes")
                    {
                        win = 0;
                        lose = 0;
                        tie = 0;
                    }
                    Console.WriteLine("would you like to play another game?");
                    Console.WriteLine("if you type 'no' the game will end.");
                    if (Convert.ToString(Console.ReadLine().ToLower()) == "no")
                    {
                        newGame = false;
                    }
                }
            }
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

        public static void gameSetup(List<string> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + List[i]);
            }
        }

        public static string ComputerGesture(List<string> options)
        {
            Random rand = new Random();
            return options[rand.Next(0, options.Count)];
        }
    }
}
