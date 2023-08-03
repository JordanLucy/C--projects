using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program will create an Mad Libs word game
            Author: Jordan Lucy
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Let the Mad Lib games begin!");

            // Give the Mad Lib a title:
            string title = "Lab Mibs";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name for the main character: ");
            string name = Console.ReadLine();

            // Adjectives
            Console.WriteLine("Please enter 3 different adjectives for your story: ");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Adjective 2:");
            string adj2 = Console.ReadLine();
            Console.WriteLine("Adjective 3:");
            string adj3 = Console.ReadLine();

            // Verbs
            Console.WriteLine("Please enter a verb, maybe something along the lines of 'sit', 'eat', 'sleep': ");
            string verb = Console.ReadLine();

            // Nouns
            Console.WriteLine("Now, please enter a noun: ");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Another one: ");
            string noun2 = Console.ReadLine();

            // Animal
            Console.WriteLine("Now for the weird part, please enter the following. An animal: ");
            string animal = Console.ReadLine();

            // Food
            Console.WriteLine("A food: ");
            string food = Console.ReadLine();

            // Fruit
            Console.WriteLine("A fruit: ");
            string fruit = Console.ReadLine();

            // Superhero
            Console.WriteLine("A superhero: ");
            string superhero = Console.ReadLine();

            // Country
            Console.WriteLine("A country: ");
            string country = Console.ReadLine();

            // Dessert
            Console.WriteLine("A dessert: ");
            string dessert = Console.ReadLine();

            // Year
            Console.WriteLine("A year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
