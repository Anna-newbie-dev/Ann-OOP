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

        /// <summary>
        /// Displays two lists on the screen
        /// </summary>
        /// <param name="firstList">Первый список</param>
        /// <param name="secondList">Второй список</param>
        static void PrintLists(PersonList firstList,
            PersonList secondList)
        {
            var personLists = new PersonList[]
            {
                firstList,
                secondList
            };

            for (int i = 0; i < personLists.Length; i++)
            {
                Console.WriteLine("Список " + (i + 1) + "\n");
                Console.WriteLine("   Name      Surname     Age      Gender");
                for (int j = 0; j < personLists[i].Length; j++)
                {
                    Console.WriteLine("{0,10} | {1,10} | {2,3} | {3,7}",
                        personLists[i][j].FirstName, personLists[i][j].LastName,
                        personLists[i][j].Age, personLists[i][j].Gender);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------\n");
        }

        /// <summary>
        /// Displays a list on the screen
        /// </summary>
        /// <param name="personList">A list to be displayed</param>
        static void PrintLists(PersonList personList)
        {
            var personLists = new PersonList[]
            {
                personList,
            };

            for (int i = 0; i < personLists.Length; i++)
            {
                //Console.WriteLine("Список " + (i + 1) + "\n");

                for (int j = 0; j < personLists[i].Length; j++)
                {
                    Console.WriteLine(
                        personLists[i][j].FirstName + "\t" + personLists[i][j].LastName +
                        "\t" + personLists[i][j].Age + "\t" + personLists[i][j].Gender);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("----------\n");
        }

    } 
}

