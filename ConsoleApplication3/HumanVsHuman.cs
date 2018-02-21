using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class HumanVsHuman
    {
        public void HvH()
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
                    catch (FormatException )
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
                var playerTwoGesture = "";
                validInput = false;
                while (!validInput)
                {
                    
                        var playerTwoChoice = -1;
                        Console.WriteLine("Please choose your Gesture ");
                        gameSetup(listOfGestures);
                        try
                        {
                            playerTwoChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            validInput = false;
                        }

                        if (playerTwoChoice > 0 && playerTwoChoice <= listOfGestures.Count)
                        {
                            playerTwoGesture = listOfGestures[playerTwoChoice - 1];
                            validInput = true;
                        }
                        else
                        {
                            validInput = false;
                        }
                    

                }


                var playerTwoPlay = playerTwoGesture;


                Console.WriteLine("player 1 gesture: " + playerGesture);
                Console.WriteLine("player 2 gesture: " + playerTwoGesture);

                if (playerGesture == playerTwoGesture)
                {
                    tie++;
                    Console.WriteLine("The players have tied");
                    Console.WriteLine("Player 1 gesture:  " + playerGesture);
                    Console.WriteLine("Player 2 gesture: " + playerTwoGesture);
                }
                else
                {
                    if (playerGesture == "rock")
                    {
                        if (playerTwoPlay == "lizard" || playerTwoPlay == "scissors")
                        {
                            Console.WriteLine("Player 1 Win, " + playerGesture + " Crushes " + playerTwoPlay);
                            win++;
                        }
                        else if (playerTwoPlay == "paper")
                        {
                            Console.WriteLine("Player 1 Loss, Paper Covers Rock");
                            lose++;
                        }
                        else if (playerTwoPlay == "spock")
                        {
                            Console.WriteLine("Player 1 Loss, Spock Vaporizes Rock");
                            lose++;
                        }
                    }
                    else if (playerGesture == "paper")
                    {
                        if (playerTwoPlay == "spock")
                        {
                            Console.WriteLine("Player 1 Win, Paper Disproves Spock");
                            win++;
                        }
                        else if (playerTwoPlay == "rock")
                        {
                            Console.WriteLine("Player 1 Win, Paper Covers Rock");
                            win++;
                        }
                        else if (playerTwoPlay == "lizard")
                        {
                            Console.WriteLine("Player 1 Loss, Lizard Eats Paper");
                            lose++;
                        }
                        else if (playerTwoPlay == "scissors")
                        {
                            Console.WriteLine("Player 1 Loss, Scissors Cut Paper");
                            lose++;
                        }
                    }
                    else if (playerGesture == "scissors")
                    {
                        if (playerTwoPlay == "paper")
                        {
                            Console.WriteLine("Player 1 Win, Scissors Cut Paper");
                            win++;
                        }
                        else if (playerTwoPlay == "lizard")
                        {
                            Console.WriteLine("Player 1 Win, Scissors Decapitate Lizard");
                            win++;
                        }
                        else if (playerTwoPlay == "rock")
                        {
                            Console.WriteLine("Player 1 Loss, Rock Crushes Scissors");
                            lose++;
                        }
                        else if (playerTwoPlay == "spock")
                        {
                            Console.WriteLine("Player 1 Loss, Spock Smashes Scissors");
                            lose++;
                        }
                    }
                    else if (playerGesture == "lizard")
                    {
                        if (playerTwoPlay == "paper")
                        {
                            Console.WriteLine("Player 1 Win, Lizard Eats Paper");
                            win++;
                        }
                        else if (playerTwoPlay == "spock")
                        {
                            Console.WriteLine("Player 1 Win, Lizard Poisons Spock");
                            win++;
                        }
                        else if (playerTwoPlay == "scissors")
                        {
                            Console.WriteLine("Player 1 Loss, Scissors Decapitates Lizard");
                            lose++;
                        }
                        else if (playerTwoPlay == "rock")
                        {
                            Console.WriteLine("Player 1 Loss, Rock Crushes Lizard");
                            lose++;
                        }
                    }
                    else if (playerGesture == "spock")
                    {
                        if (playerTwoPlay == "rock")
                        {
                            Console.WriteLine("Player 1 Win, Spock Vaporizes Rock");
                            win++;
                        }
                        else if (playerTwoPlay == "scissors")
                        {
                            Console.WriteLine("Player 1 Win, Spock Smashes Scissors");
                            win++;
                        }
                        else if (playerTwoPlay == "paper")
                        {
                            Console.WriteLine("Player 1 Loss, Paper Disproves Spock");
                            lose++;
                        }
                        else if (playerTwoPlay == "lizard")
                        {
                            Console.WriteLine("Player 1 Loss, Lizard Poisons Spock");
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

     
    }
}
