// using System;

// class Game
// {
//     static void Main(string[] args)
//     {
//         Random rd = new Random();
//         string[] options = { "Rock", "Paper", "Scissor" };
//         string comp, user;
//         int cpoints = 0, upoints = 0;

//         Console.WriteLine("Welcome to the Rock, Paper, Scissors game!!");

//         for (int i = 0; i < 3; i++)
//         {

//             int compinput = rd.Next(1, 4);
//             comp = options[compinput - 1];

//             Console.WriteLine("Choose: 1 for Rock, 2 for Paper, 3 for Scissor");
//             user = Console.ReadLine();


//             if (user != "1" && user != "2" && user != "3")
//             {
//                 Console.WriteLine("OOPS! Invalid input!!! Please enter 1, 2, or 3.");
//                 continue;
//             }


//             string userChoice = options[int.Parse(user) - 1];
//             Console.WriteLine($"You chose {userChoice}!");
//             Console.WriteLine($"Computer chose {comp}!");


//             if (userChoice == comp)
//             {
//                 Console.WriteLine("It's a tie! No points.");
//             }
//             else if ((userChoice == "Rock" && comp == "Scissor") ||
//                      (userChoice == "Paper" && comp == "Rock") ||
//                      (userChoice == "Scissor" && comp == "Paper"))
//             {
//                 Console.WriteLine("You won this round!");
//                 upoints++;
//             }
//             else
//             {
//                 Console.WriteLine("Computer won this round!");
//                 cpoints++;
//             }

//             Console.WriteLine($"Score - You: {upoints} | Computer: {cpoints}");
//             Console.WriteLine("-------------------------------------");
//         }


//         if (upoints == cpoints)
//         {
//             Console.WriteLine("It's a tie after 3 rounds!");
//         }
//         else if (upoints > cpoints)
//         {
//             Console.WriteLine("You won the game!");
//         }
//         else
//         {
//             Console.WriteLine("Computer won the game!");
//         }
//     }
// }
