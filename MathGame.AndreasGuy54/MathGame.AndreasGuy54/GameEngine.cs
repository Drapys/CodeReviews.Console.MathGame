﻿using MathGame.AndreasGuy54.Models;

namespace MathGame.AndreasGuy54
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int result = firstNumber + secondNumber;

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string userAnswer = Console.ReadLine();
                userAnswer = Helpers.ValidateResult(userAnswer);

                if (int.Parse(userAnswer) == result)
                {
                    Console.WriteLine("Correct! Type any key for the next question:");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question:");
                    Console.ReadLine();
                }

                if (i == 5)
                {
                    Console.WriteLine($@"Game over. Your final score is {score}/{i}
Press any key to go back to the game menu:");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {
            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int result = firstNumber - secondNumber;

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string userAnswer = Console.ReadLine();
                userAnswer = Helpers.ValidateResult(userAnswer);

                if (int.Parse(userAnswer) == result)
                {
                    Console.WriteLine("Correct! Type any key for the next question:");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question:");
                    Console.ReadLine();
                }

                if (i == 5)
                {
                    Console.WriteLine($@"Game over. Your final score is {score}/{i}
Press any key to go back to the game menu:");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Random random = new();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int result = firstNumber * secondNumber;

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string userAnswer = Console.ReadLine();
                userAnswer = Helpers.ValidateResult(userAnswer);

                if (int.Parse(userAnswer) == result)
                {
                    Console.WriteLine("Correct! Type any key for the next question:");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question:");
                    Console.ReadLine();
                }

                if (i == 5)
                {
                    Console.WriteLine($@"Game over. Your final score is {score}/{i}
Press any key to go back to the game menu:");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];
                int result = firstNumber / secondNumber;

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string userAnswer = Console.ReadLine();
                userAnswer = Helpers.ValidateResult(userAnswer);

                if (int.Parse(userAnswer) == result)
                {
                    Console.WriteLine("Correct! Type any key for the next question:");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question:");
                    Console.ReadLine();
                }

                if (i == 5)
                {
                    Console.WriteLine($@"Game over. Your final score is {score}/{i}
Press any key to go back to the game menu:");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
