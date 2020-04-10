using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonsLib;

namespace LaunchLab
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Arguments</param>
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 30);
            Console.WriteLine("Press any key to create lists ");
            Console.ReadKey();
            Console.WriteLine("\nCreating lists... ");

            var listOne = new PersonList();

            for (int i = 0; i <= 6; i++)
            {
                listOne.AddPerson(RandomPerson.PickRandomPerson());
            }

            for (int i = 0; i < listOne.Length; i++)
            {
                Console.WriteLine(listOne[i].FormInfoAboutPerson());
                Console.WriteLine();
            }

            Console.Write("And fourth entry is ");
            switch (listOne[3])
            {
                case Adult adult:
                    {
                        Console.WriteLine("an adult!");
                        adult.Beep();
                        break;
                    }
                case Child child:
                    {
                        Console.WriteLine("a child!");
                        Console.WriteLine("The child is just learning, be kind to" +
                            PickPronoun(child));
                        child.Beep();
                        break;
                    }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Picks appropriate pronoun
        /// </summary>
        static string PickPronoun(Child child)
        {
            if (child.Gender == Gender.Female)
                return " her";
            else
                return " him";
        }

    } 
}

