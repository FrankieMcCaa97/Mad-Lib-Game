using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a Mad Libs word game! that are short stories with blanks for the player to fill in that represents different parts of the speech.
      Author: Frankie McCaa
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Frankie & Tashera: The Next Generation";

      Console.WriteLine(title);
      // Define user input and variables:


      // The template for the story:
			Console.WriteLine("Mad Libs is starting");
      Console.Write("Frankie");
      string name = Console.ReadLine();
      Console.WriteLine("strong");
      string adj1 = Console.ReadLine();
      Console.WriteLine("black");
      string adj2 = Console.ReadLine();
      Console.WriteLine("skinny");
      string adj3 = Console.ReadLine();
      Console.WriteLine("eat");
      string verb = Console.ReadLine();
      Console.WriteLine("man");
      string noun1 = Console.ReadLine();
      Console.WriteLine("rocket");
      string noun2 = Console.ReadLine();
      Console.WriteLine("lion");
      string animal = Console.ReadLine();
      Console.WriteLine("tofu");
      string food = Console.ReadLine();
      Console.WriteLine("dragonfruit");
      string fruit = Console.ReadLine();
      Console.WriteLine("batman");
      string superhero = Console.ReadLine();
      Console.WriteLine("Africa");
      string country = Console.ReadLine();
      Console.WriteLine("cake");
      string dessert = Console.ReadLine();
      Console.WriteLine("2047");
      string year = Console.ReadLine();
      string story = $"This morning {"Frankie"} woke up feeling {"black"}. 'It is going to be a {"skinny"} day!' Outside, a bunch of {"lion"}s were protesting to keep {"dragonfruit"} in stores. They began to {"man"} to the rhythm of the {"rocket"}, which made all the {"batman"}s very {"eat"}. Concerned, {"Frankie"} texted {"batman"}, who flew {"Frankie"} to {"Africa"} and dropped {"Frankie"} in a puddle of frozen {"2047"}. {"Frankie"} woke up in the year {"2047"}, in a world where {"lion"}s ruled the world.";


      // Print the story:
			Console.WriteLine(story);
    }
  }
}
