using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsLib
{
    /// <summary>
    /// An adult person
    /// </summary>
    public class Adult : PersonBase
    {
        #region Constants

        /// <summary>
        /// Min age
        /// </summary>
        public const int MINAGE = 18;

        /// <summary>
        /// Max age
        /// </summary>
        public const int MAXAGE = 122;

        /// <summary>
        /// Allowed number od digits in ID
        /// </summary>
        public const int IDNUMALLOWED = 10;

        #endregion

        #region Fields

        /// <summary>
        /// ID number
        /// </summary>
        private string _id;

        /// <summary>
        /// Married or not
        /// </summary>
        private Status _maritalStatus;

        /// <summary>
        /// Партнер
        /// </summary>
        private string _partnerName;

        /// <summary>
        /// Партнер
        /// </summary>
        private string _partnerSurname;

        /// <summary>
        /// Workplace
        /// </summary>
        private string _workPlace;

        #endregion

        #region Properties

        /// <summary>
        /// Возраст
        /// </summary>
        public override byte Age
        {
            get { return base.Age; }
            set
            {
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be from " +
                        $"{MINAGE} to {MAXAGE}.");
                }
                base.Age = value;
            }
        }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string ID
        {
            get { return _id; }
            set
            {
                CheckID(value, IDNUMALLOWED);
                _id = value;
            }
        }

        /// <summary>
        /// Состояние брака
        /// </summary>
        public Status MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        /// <summary>
        /// Partner's name
        /// </summary>
        public string PartnerName
        {
            get { return _partnerName; }
            set { _partnerName = value; }
        }

        /// <summary>
        /// Partner's Surname
        /// </summary>
        public string PartnerSurname
        {
            get { return _partnerSurname; }
            set { _partnerSurname = value; }
        }

        /// <summary>
        /// Место работы
        /// </summary>
        public string WorkPlace
        {
            get { return _workPlace; }
            set { _workPlace = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// A child constructor
        /// </summary>
        /// <param name="firstName">Name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="id">ID</param>
        /// <param name="status">Marital status</param>
        /// <param name="partnerName">Partner's name</param>
        /// <param name="partnerSurname">Partner's surname</param>
        /// <param name ="workPlace">Place of work</param>
        public Adult(string firstname, string lastname, byte age, Gender gender,
            string id, Status status, string partnerName,
            string partnerSurname, string workPlace)
            : base(firstname, lastname, age, gender)
        {
            ID = id;
            MaritalStatus = status;
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
            WorkPlace = workPlace;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks whether an input string
        /// exceeds allowed size
        /// </summary>
        /// <param name="value">ID</param>
        /// <param name="digitsAmount">Number of digits in ID</param>
        private void CheckID(string value,
            byte digitsAmount)
        {
            if (value.Length != digitsAmount)
            {
                throw new ArgumentException(
                    $"{nameof(value)} must contain exactly " + digitsAmount +
                        "digits!");
            }

            if (!Int64.TryParse(value, out _))
            {
                throw new FormatException(
                    $"{nameof(value)} must be numeric!");
            }
        }
        
        /// <summary>
        /// Сформировать информацию о взрослом
        /// </summary>
        /// <returns>Информация о взрослом</returns>
        //public override string FormInfoAboutPerson()
        //{
        //    var infoAboutPerson = base.FormInfoAboutPerson() +
        //        $"\nDocument " +
        //        $"{ID}\n" +
        //        $"Семейное положение: {MaritalStatus}";

        //    if (MaritalStatus == Status.Married)
        //    {
        //        infoAboutPerson += $"\nПартнер: {Partner.FirstName} " +
        //            $"{Partner.LastName}";
        //    }

        //    infoAboutPerson += "\nМесто работы: ";

        //    if (string.IsNullOrEmpty(WorkPlace))
        //    {
        //        infoAboutPerson += "Безработный";
        //    }
        //    else
        //    {
        //        infoAboutPerson += WorkPlace;
        //    }

        //    return infoAboutPerson;
        //}

        /// <summary>
        /// Сформировать информацию о взрослом
        /// </summary>
        /// <returns>Информация о взрослом</returns>
        public override string FormInfoAboutPerson()
        {
            var infoAboutPerson = base.FormInfoAboutPerson() +
                $"{ID}\t" +
                $"{MaritalStatus}\t";
           
            if (MaritalStatus != Status.Married)
            {
                infoAboutPerson += "None\t";
            }
            
            if (string.IsNullOrEmpty(WorkPlace))
            {
                infoAboutPerson += "Unemployed\t";
            }
            else
            {
                infoAboutPerson += WorkPlace;
            }
            PrintAdultHeader();
            return infoAboutPerson;
        }
        /// <summary>
        /// Prints header before
        /// data is displayed
        /// </summary>
        static void PrintAdultHeader()
        {
            Console.WriteLine("Name\tSurname\tAge\tGender\tID\tStatus\t" +
                "PartnerName\tPartnerSurname\tPlace of work");
        }

        /// <summary>
        /// To play 
        /// </summary>
        public void Beep()
        {
            Console.WriteLine($"{WhoIs()} is playing...");
            for (int i = 1; i < 2; i++)
            {
                Console.Beep(329, 280); 
                Console.Beep(493, 280); 
                Console.Beep(698, 280); 
                Console.Beep(659, 550); 

                Console.Beep(783, 280); 
                Console.Beep(698, 280); 
                Console.Beep(659, 550); 

                Console.Beep(329, 100);
                Console.Beep(493, 300);
                Console.Beep(698, 300);
                Console.Beep(659, 600);

                Console.Beep(392, 250);
                Console.Beep(440, 200);
                Console.Beep(587, 300);

                Console.Beep(349, 250);
                Console.Beep(587, 500);

                Console.Beep(329, 300);
                Console.Beep(493, 300);
                Console.Beep(698, 300);
                Console.Beep(659, 600);

                Console.Beep(783, 300);
                Console.Beep(698, 300);
                Console.Beep(659, 600);

                Console.Beep(329, 100);
                Console.Beep(493, 300);
                Console.Beep(698, 300);
                Console.Beep(659, 600);

                Console.Beep(392, 250);
                Console.Beep(440, 200);
                Console.Beep(587, 300);

                Console.Beep(349, 250);
                Console.Beep(587, 400);

            }
        }
        #endregion
    }
}
