﻿using System;
using System.Linq;

namespace PersonsLib
{
    /// <summary>
    /// Class containing persons description
    /// </summary>
    public class Person
    {
        #region Fields

        /// <summary>
        /// Имя
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол
        /// </summary>
        private Gender _gender;

        #endregion

        #region Properties

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                CheckInput(value);
                //!TODO: Убрать комментарии
                _firstName = FirstLetterUpperCase(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                CheckInput(value);
                //!TODO: Убрать комментарии
                _lastName = FirstLetterUpperCase(value);
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentOutOfRangeException(
                        "Age must be between 0 and 150! "+
                        "Please, again");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// A person
        /// </summary>
        public Person() { }

        /// <summary>
        /// A person
        /// </summary>
        /// <param name="firstName">Name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        public Person(string firstName, string lastName, byte age,
            Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        #endregion
      
        #region Methods

        /// <summary>
        /// Checks if an input parameter
        /// consists of alphabet symbols
        /// </summary>
        /// <param name="input">Param to check</param>
        /// <returns>Whether it matches or not </returns>
        private static bool IsNameCorrect(string input)
        {
           if (input.All(c => Char.IsLetter(c) || c =='-'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        /// <summary>
        /// Checks if name/surname input is correct
        /// </summary>
        /// <param name="value">Param to check</param>
        private void CheckInput(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "The input parameter is null or empty.");
            }
            if (!IsNameCorrect(value))
            {
                 throw new FormatException(
                    "The input parameter must contain Cyrillic or " +
                    "Latin symbols only.");
            }
        }
        
        /// <summary>
        /// Checks the case of input string
        /// </summary>
        /// <param name="wordToUpdate">Input string</param>
        /// <returns>Edited string</returns>
        private static string FirstLetterUpperCase(string wordToUpdate)
        {
            string[] buffer = wordToUpdate.Split('-');
            wordToUpdate = null;

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = buffer[i].First().ToString().ToUpper() +
                    buffer[i].Substring(1);

                wordToUpdate += buffer[i] + "-";
            }

            return wordToUpdate.Substring(0, wordToUpdate.Length - 1);
        }
        #endregion

    }

}