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
        /// Age of a child
        /// </summary>
        public override byte Age
        {
            get { return base.Age; }
            set
            {
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 17.");
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
            set { _motherName = value; }
        }

        /// <summary>
        /// Mother's surname
        /// </summary>
        public string MotherSurname
        {
            get { return _motherSurname; }
            set { _motherSurname = value; }
        }

        /// <summary>
        /// Father's name
        /// </summary>
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        /// <summary>
        /// Father's surname
        /// </summary>
        public string FatherSurname
        {
            get { return _fatherSurname; }
            set { _fatherSurname = value; }
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

        /// <summary>
        /// Form information about child
        /// </summary>
        public override string FormInfoAboutPerson()
        {
            var infoAboutPerson = base.FormInfoAboutPerson() +
                $"{KindergartenOrSchool}\t";

            if (MotherName != null)
            {
                infoAboutPerson += $" {MotherName}\t";
            }
            else
            {
                infoAboutPerson += "None\t";
            }
                
            if (MotherSurname != null)
            {
                infoAboutPerson += $"{MotherSurname}\t";
            }
            else
            {
                infoAboutPerson += "None\t";
            }
            if (FatherName != null)
            {
                infoAboutPerson += $"{FatherName}\t";
            }
            else
            {
                infoAboutPerson += "  None  ";
            }

            if (FatherSurname != null)
            {
                infoAboutPerson += $"{FatherSurname}\t";
            }
            else
            {
                infoAboutPerson += "None\t";
            }

            PrintChildHeader();
            return infoAboutPerson;
        }
        /// <summary>
        /// Prints header before
        /// data is displayed
        /// </summary>
        static void PrintChildHeader()
        {
            Console.WriteLine("Name\tSurname\tAge\tGender\t" +
                "Kindergarten/School\tMother's name\tMother's surname" +
                "\tFather's name\tFather's surname");
        }

        /// <summary>
        /// To play music
        /// </summary>
        public void Beep()
        {

            Console.WriteLine($"{WhoIs()} tries to play Metallica ;-)");   
            
            Console.Beep(329, 250); //E
            Console.Beep(493, 300); //B
            Console.Beep(698, 250); //F^
            Console.Beep(659, 500); //E^

            Console.Beep(780, 300); //G^
            Console.Beep(698, 300); //F^
            Console.Beep(650, 500); //E^

            Console.Beep(329, 100);
            Console.Beep(493, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 600);

            Console.Beep(392, 250);
            Console.Beep(440, 200);
            Console.Beep(587, 300);

            Console.Beep(349, 250);
            Console.Beep(587, 500);

            Console.Beep(329, 250);
            Console.Beep(493, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 600);
        }

        #endregion
    }
}
