using System;
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
        /// Отчество
        /// </summary>
        private string _patronymic;

        ///// <summary>
        ///// Возраст
        ///// </summary>
        //private int _age;

        ///// <summary>
        ///// Пол
        ///// </summary>
        //private Gender _gender;

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
                _lastName = FirstLetterUpperCase(value);
            }
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                CheckInput(value);
                _patronymic = FirstLetterUpperCase(value);
            }
        }

        ///// <summary>
        ///// Возраст
        ///// </summary>
        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value < 0 || value > 150)
        //        {
        //            throw new ArgumentOutOfRangeException(
        //                "Age must be between 0 and 150! "+
        //                "Please, again");
        //        }
        //        _age = value;
        //    }
        //}

        ///// <summary>
        ///// Gender
        ///// </summary>
        //public Gender Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}

        #endregion

        #region Constructors

        /// <summary>
        /// A person
        /// </summary>
        public Person() { }

        /// <summary>
        /// A person
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>

        public Person(string firstName, string lastName, 
            string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            //Age = age;
            //Gender = gender;
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
                throw new Exception(
                    "Поля ФИО не могут быть пустыми! " +
                    "Проверьте, все ли поля заполнены");
            }
            if (!IsNameCorrect(value))
            {
                 throw new Exception(
                    "ФИО может содержать только" +
                    "латинские или кириллические символы!");
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