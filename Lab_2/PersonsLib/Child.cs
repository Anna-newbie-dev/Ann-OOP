using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsLib
{
    /// <summary>
    /// A child
    /// </summary>
    public class Child : PersonBase
    {
        #region Constants

        /// <summary>
        /// Minimal age of a child
        /// </summary>
        public const int MINAGE = 0;

        /// <summary>
        /// Maximum age of a child
        /// </summary>
        public const int MAXAGE = 17;

        #endregion

        #region Fields

        //private IsOrphan _orphan;

        /// <summary>
        /// Mother name
        /// </summary>
        private string _motherName;
        
        /// <summary>
        /// Mother surname
        /// </summary>
        private string _motherSurname;

        /// <summary>
        /// Father name
        /// </summary>
        private string _fatherName;
        
        /// <summary>
        /// Father surname
        /// </summary>
        private string _fatherSurname;

        /// <summary>
        /// Kindergarten or school
        /// </summary>
        private string _kindergartenOrSchool;

        #endregion

        #region Properties

        /// <summary>
        /// A flag showing whether
        /// a child is an orphan
        /// </summary>
        //public IsOrphan Orphan
        //{
        //    get { return _orphan; }
        //    set { _orphan = value; }
        //}

        /// <summary>
        /// Age of a child
        /// </summary>
        public override byte Age
        {
            get { return base.Age; }
            set
            {
                //
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between " +
                        $"${MINAGE} and ${MAXAGE}.");
                }

                base.Age = value;
            }
        }

        /// <summary>
        /// Mother's name
        /// </summary>
        public string MotherName
        {
            get { return _motherName; }
            set 
            {
                _motherName = FirstLetterUpperCase
                    (ChecksInput(IfParentsExist(value)));
            }
        }

        /// <summary>
        /// Mother's surname
        /// </summary>
        public string MotherSurname
        {
            get { return _motherSurname; }
            set 
            {
                _motherSurname = FirstLetterUpperCase
                    (ChecksInput(IfParentsExist(value)));
            }
        }

        /// <summary>
        /// Father's name
        /// </summary>
        public string FatherName
        {
            get { return _fatherName; }
            set 
            {
                _fatherName = FirstLetterUpperCase
                    (ChecksInput(IfParentsExist(value)));
            }
        }

        /// <summary>
        /// Father's surname
        /// </summary>
        public string FatherSurname
        {
            get { return _fatherSurname; }
            set
            {
                _fatherSurname = FirstLetterUpperCase
                    (ChecksInput(IfParentsExist(value)));
            }
        }
       
        /// <summary>
        /// Kindergarten or school
        /// </summary>
        public string KindergartenOrSchool
        {
            get { return _kindergartenOrSchool; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "The string is null or empty!");
                }

                _kindergartenOrSchool = value;
            }
        }
        #endregion

        #region Consructors

        /// <summary>
        /// A child constructor
        /// </summary>
        /// <param name="firstName">Name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="motherName">Mother's name</param>
        /// <param name="motherSurname">Mother's surname</param>
        /// <param name="fatherName">Father's name</param>
        /// <param name="fatherName">Father's surname</param>
        public Child(string firstname, string lastname, byte age, Gender gender,
           string motherName, string motherSurname, string fatherName,
           string fatherSurname, string kindergartenOrSchool)
           : base(firstname, lastname, age, gender)
        {
            MotherName = motherName;
            MotherSurname = motherSurname;
            FatherName = fatherName;
            FatherSurname = fatherSurname;
            KindergartenOrSchool = kindergartenOrSchool;
        }
        #endregion

        #region Methods

        public string ChecksInput(string value)
        {
            if (!IsNameCorrect(value))
            {
                throw new FormatException(
                   "The input parameter must contain Cyrillic or " +
                   "Latin symbols only.");
            }
            return value;
        }
        /// <summary>
        /// Form information about child
        /// </summary>
        public override string FormInfoAboutPerson()
        {
            var infoAboutPerson = base.FormInfoAboutPerson() +
                $"{KindergartenOrSchool}\t" +
                $"{MotherName}\t" +
                $"{MotherSurname}\t" +
                $"{FatherName}\t" +
                $"{FatherSurname}\t";
            //TODO: Дубли(!)
            PrintChildHeader();
            return infoAboutPerson;
        }

        /// <summary>
        /// Prints header before
        /// data is displayed
        /// </summary>
        public void PrintChildHeader()
        {
            Console.WriteLine("Name\tSurname\tAge\tGender\t" +
                "Kindergarten/School\tMother's name\tMother's surname\t" +
                "Father's name\tFather's surname");
        }

        /// <summary>
        /// To play a beep song
        /// </summary>
        public void Beep()
        {

            Console.WriteLine($"{WhoIs()} tries to play Metallica ;-)");   
            
            Console.Beep(329, 250); //E
            Console.Beep(400, 300); //B
            Console.Beep(698, 250); //F^
            Console.Beep(659, 500); //E^

            Console.Beep(780, 300); //G^
            Console.Beep(620, 300); //F^
            Console.Beep(650, 500); //E^

            Console.Beep(329, 100);
            Console.Beep(493, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 600);

            Console.Beep(392, 250);
            Console.Beep(300, 200);
            Console.Beep(587, 300);

            Console.Beep(349, 250);
            Console.Beep(587, 500);

            Console.Beep(329, 250);
            Console.Beep(493, 300);
            Console.Beep(700, 300);
            Console.Beep(659, 600);
        }

        public string IfParentsExist(string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return "None";
            }
            else
            {
                return $"{field}";
            }
        }

        #endregion
    }
}
