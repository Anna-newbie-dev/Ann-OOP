using System;
using System.Collections.Generic;

namespace PersonsLib
{
    /// <summary>
    /// Contains methods
    /// </summary>
    public class PersonList
    {
        #region Fields

        /// <summary>
        /// A persons list
        /// </summary>
        private Person[] _persons;

        #endregion

        #region Properties

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        public int Length
        {
            get { return _persons.Length; }
        }

        #endregion

        #region Indexator

        /// <summary>
        /// Возвращает человека из списка по указанному индексу
        /// </summary>
        /// <param name="index">Индекс человека в списке</param>
        /// <returns></returns>
        public Person this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new IndexOutOfRangeException(
                        "Index must be non-negative and less than the " +
                        "size of the collection.");
                }
                return _persons[index];
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an empty list
        /// </summary>
        public PersonList()
        {
            _persons = new Person[0];
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adding a new person to a list
        /// </summary>
        /// <param name="person">A person</param>
        public void AddPerson(Person person)
        {
            var buffer = _persons;

            _persons = new Person[buffer.Length + 1];
            for (int i = 0; i < buffer.Length; i++)
            {
                _persons[i] = buffer[i];
            }
            _persons[buffer.Length] = person;
        }

        /// <summary>
        /// Adds new people to the end of the list
        /// </summary>
        /// <param name="persons">Objects array</param>
        public void AddRange(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }

        /// <summary>
        /// Delete an entry by its index
        /// </summary>
        /// <param name="indexOfPerson">Index</param>
        public void DeletePersonByIndex(int indexOfPerson)
        {
            if (indexOfPerson < 0 || indexOfPerson > _persons.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            var buffer = _persons;
            uint counter = 0;

            _persons = new Person[buffer.Length - 1];
            for (int i = 0; i < buffer.Length; i++)
            {
                if (i != indexOfPerson)
                {
                    _persons[counter] = buffer[i];
                    counter++;
                }
            }
        }

        /// <summary>
        /// Delete an entry by its index
        /// </summary>
        /// <param name="person">Person class instance</param>
        public void DeletePerson(Person person)
        {
            DeletePersonByIndex(GetPersonByIndex(person));
        }

        //TODO: Переименоваь
        /// <summary>
        /// Поиск человека в списке по переданному
        /// экземпляру объекта класса Person
        /// </summary>
        /// <param name="person">Экземпляр объекта класса Person</param>
        /// <returns>
        /// Индекс человека в списке
        /// </returns>
        public int GetPersonByIndex(Person person)
        {
            for (int i = 0; i < _persons.Length; i++)
            {
                if (_persons[i] == person)
                {
                    return i;
                }
            }

            throw new KeyNotFoundException("There is no such person in " +
                "this list.");
        }

        /// <summary>
        /// Flush
        /// </summary>
        public void Clear()
        {
            _persons = new Person[0];
        }

        #endregion
    }

}

