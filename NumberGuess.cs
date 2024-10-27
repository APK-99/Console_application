using System;
class Guess_Number
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome To the number guessing game !");
        Console.WriteLine("-----------------------------------------");
        int userinput = 0;
        Random rand = new Random();
        int number = rand.Next(1, 20);

        bool correct_ans = false;

        while (!correct_ans)
        {
            Console.WriteLine("Guess  the number !");
            userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == number)
            {
                Console.WriteLine("Waw!!You Guessed it right!!");
                correct_ans = true;

            }
            else if (userinput > number)
            {
                Console.WriteLine("Sorry guess is too high!");

            }
            else
            {
                Console.WriteLine("Im sorry your guess is too low");

            }

        }
    }
}