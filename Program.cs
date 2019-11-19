using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>()
            {
                new Movie("Toy Story", "Animated"),
                new Movie("Shawshank Redemption", "Drama"),
                new Movie("Scream", "Horror"),
                new Movie("Up", "Animated"),
                new Movie("Forest Gump", "Drama"),
                new Movie("The Ring", "Horror"),
                new Movie("WALL-E", "Animated"),
                new Movie("Appolo 13", "Drama"),
                new Movie("The Shining", "Horror"),
                new Movie("Coco", "Animated"),
                new Movie("The Post", "Drama"),
                new Movie("Psycho", "Horror"),
                new Movie("Star Wars", "Sci-Fi"),
                new Movie("The Abyss", "Sci-Fi"),
                new Movie("Blade Runner", "Sci-Fi"),
                new Movie("Avatar", "Sci-Fi")
            };

            Console.WriteLine("Welcome to the Movie List!---------------\n\n" +
                "Please enter a category and we will display the options.");

            bool startOver = true;
            while (startOver)
            {
                Console.WriteLine("\nChoose from the following:\nDrama\nHorror\nAnimated\nSci-Fi\n");
                bool repeat = true;
                while (repeat)
                {
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "drama")
                    {
                        foreach (var m in movieList)
                        {
                            if (userInput.ToLower() == "drama" && m.Category == "Drama")
                            {
                                Console.WriteLine(m.Title);
                            }
                            repeat = false;
                        }
                    }
                    else if (userInput.ToLower() == "horror")
                    {
                        foreach (var m in movieList)
                        {
                            if (userInput.ToLower() == "horror" && m.Category == "Horror")
                            {
                                Console.WriteLine(m.Title);
                            }
                            repeat = false;
                        }
                    }
                    else if (userInput.ToLower() == "animated")
                    {
                        foreach (var m in movieList)
                        {
                            if (userInput.ToLower() == "animated" && m.Category == "Animated")
                            {
                                Console.WriteLine(m.Title);
                            }
                            repeat = false;
                        }
                    }
                    else if (userInput.ToLower() == "sci-fi")
                    {
                        foreach (var m in movieList)
                        {
                            if (userInput.ToLower() == "sci-fi" && m.Category == "Sci-Fi")
                            {
                                Console.WriteLine(m.Title);
                            }
                            repeat = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter the following:\nHorror\nDrama\nAnimated\nSci-Fi");
                        repeat = true;
                    }
                }
                Console.WriteLine("\nWould you like a new Category?");
                string doAgain = Console.ReadLine();
                bool cont = true;

                while (cont)
                {
                    Validation validation = new Validation();

                    validation.GetValidate(Console.ReadLine());

                    if (doAgain == "n" || doAgain == "N")
                    {
                        Console.WriteLine("\nThanks for the chat.  Have a great day!");
                        return;
                    }
                    else if (doAgain == "y" || doAgain == "Y")
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        doAgain = Console.ReadLine();
                        cont = true;
                    }
                }
                if (doAgain == "y" || doAgain == "Y")
                {
                }
                startOver = true;
            }
        }
    }
}
