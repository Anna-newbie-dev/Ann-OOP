using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonsLib;

namespace LaunchLab
{
    /// <summary>
    /// RandomPerson class
    /// </summary>
    public static class RandomPerson
    {
        #region Fields

        /// <summary>
        /// Random object
        /// </summary>
        private static Random _random = new Random();


        #region Objects array

        /// <summary>
        /// Objects array of Adult class
        /// </summary>
        public static Adult[] _adultSource = new Adult[]
        {
            new Adult("Max","Payne", 38, Gender.Male, "12345",
                Status.Divorced, "", "", "Bethesda"),
            new Adult ("Doom","Guy", 26, Gender.Male, "12356",
                Status.Single, "", "", "Mars"),
            new Adult("Lisa","Su", 45, Gender.Female, "56565",
                Status.Married, "Ryzen", "CPU", "AMD"),
            new Adult ("A","wise-man", 100, Gender.Male, "12390",
                Status.Single, "uii", "jn", "Colorado"),
            new Adult("Dora","Explorer", 25, Gender.Female, "00345",
                Status.Married, "Who", "Knows", "Disney"),
            new Adult ("Prince","Charles", 85, Gender.Male, "12345",
                Status.Married, "Queen", "Elizabeth", "Palace"),
            new Adult("Commander","Shepard", 33, Gender.Female, "56565",
                Status.Single, "", "", "SSV Normandy"),
            new Adult ("Jeff","Moreau", 35, Gender.Male, "12300",
                Status.Single, "", "", "SSV Normandy"),
        };

        /// <summary>
        /// Objects array of Child class
        /// </summary>
        public static Child[] _childSource = new Child[]
        {
            new Child("Peppa","Pig", 3, Gender.Female, "Mommy", "Pig",
                "Daddy", "Pig", "PeppyGarten"),
            new Child("Gordon","Freeman", 16, Gender.Male, "Anna", "Freeman",
                "Daddy", "Freeman", "BlackMesaSchool"),
            new Child("Qwerty","Boi", 13, Gender.Male, "", "",
                "", "", "School_13"),
            new Child("Samurai","Champloo", 10, Gender.Male, "", "",
                "", "", "TokyoGakko"),
            new Child("Christopher","Robin", 5, Gender.Male, "Mom", "Robin",
                "Dad", "Robin", "PeppyGarten"),
            new Child("Garrus","Vakarian", 3, Gender.Male, "", "",
                "Dad", "Vakarian", "SpaceGarten"),
            new Child("Qwerty","uIOP", 10, Gender.Male, "Mom", "Keyboard",
                "Dad", "Keyboard", "School_13"),
            new Child("Kaiden","Alenko", 15, Gender.Male, "", "",
                "", "", "Grissom Academy"),
        };
        #endregion

        #region Methods

        /// <summary>
        /// Picks a random entry from Adult list
        /// </summary>
        public static PersonBase PickAdult()
        {
            int index = _random.Next(0, _adultSource.Length);
            return _adultSource[index];
        }

        /// <summary>
        /// Picks a random entry from Child list
        /// </summary>
        public static PersonBase PickChild()
        {
            int index = _random.Next(0, _childSource.Length);
            return _childSource[index];
        }

        /// <summary>
        /// Picks Adult/Child objects from source lists
        /// </summary>
        /// <returns>Adult/Child objects</returns>
        public static PersonBase PickRandomPerson()
        {
            if (_random.Next(0, 2) == 0)
            {
                return PickAdult();
            }
            else
            {
                return PickChild();
            }
        }

        #endregion

    }
}
