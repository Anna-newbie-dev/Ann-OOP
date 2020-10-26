using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonsLib;
namespace Lab_4
{
    /// <summary>
    /// Класс, содержащий список данных
    /// для генерирования произвольных записей
    /// </summary>
    public static class RandomData
    {
        //TODO: XML
        private static Random _random = new Random();

        private static Person[] _source = new Person[]
        {
            new Person("Max","Payne", "Mc"),
            new Person("Lara", "Croft", "Mc"),
            new Person("Duke", "Nukem", "Mc"),
            new Person("Takumi", "Fujiwara", "Mc"),
            new Person("Ryosuke", "Takahashi","Mc"),
            new Person("Jane", "Shepard", "Mc"),
            new Person("Ezio", "Auditore", "Mc"),
            new Person("Catherina", "Sforza","Mc" ),
            new Person("Lorenzo", "Medici","Mc"),
            new Person("Annie", "Lennox", "Mc"),
            new Person("Великий", "Петр", "Иосифович"),
            new Person("Ландау", "Лев", "Давидович"),
            new Person("Яблочков", "Павел", "Николаевич"),
            new Person("Лифшиц", "Евгений", "Михайлович"),
            new Person("Яблочков", "Павел", "Николаевич"),
        };

        /// <summary>
        /// Выбор произвольной персоны
        /// из ранее подготовленного списка
        /// </summary>
        /// <returns></returns>
        public static Person PickPerson()
        {
            int index = _random.Next(0, _source.Length);
            return _source[index];
        }

        /// <summary>
        /// Получение произвольного числа
        /// </summary>
        /// <returns></returns>
        public static int GenerateNumber()
        {
            int randomNumber = _random.Next(50, 300);
            return randomNumber;
        }
    }
}
