using System;

bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 101);
            Console.WriteLine("Guess the right number \n");
            Console.WriteLine("Select a number between 1-100");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Which number are you guessing?");
                int guess = Convert.ToInt32(Console.ReadLine());

                int diff = Math.Abs(guess - randomNum);
                switch (diff)
                {
                    case int n when n > 100:
                        Console.WriteLine("That guess was damm wrong");
                        break;
                    case int n when n > 25:
                        Console.WriteLine("Good guessing but you can do better");
                        break;
                    case int n when n > 5:
                        Console.WriteLine("Pretty glose now");
                        break;
                    case int n when n > 0:
                        Console.WriteLine("Now you're damn close");
                        break;
                    default:
                        Console.WriteLine("Congratulations, you guessed the right number!");
                        return;
                }
            }
            Console.ReadKey();
 
