//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WageLib
//{
//    public class ConsoleReader : Reader
//    {
//        public override double DataInput(Bounds bounds)
//        {
//            while (true)
//            {
//                try
//                {
//                    temp = Math.Round(double.Parse(Console.ReadLine().
//                        Replace('.', ',')));
//                    //TODO: СПРЯТАТЬ ПРОВЕРКУ БИЗНЕС-ЛОГИКИ

//                    switch (bounds)
//                    {
//                        case Bounds.MAXRATE:
//                            return BoundsCheck(temp, )

//                    }

//                }

//                catch (FormatException)
//                {
//                    Console.WriteLine("Возможно, Вы ввели " +
//                        "не численное значение. Повторите ввод.");
//                }
//            }
//        }

//        private double BoundsCheck(double temp, int constant)
//        {
//            if (temp >= 0 & temp <= constant)
//            {
//                return temp;
//            }
//            else
//            {
//                Console.WriteLine("Кажется, Вы вышли " +
//                    "за границы допустимого диапазона. " +
//                    "Повторите ввод параметра:");
//                return 0;
//            }
//        }
//    }
//}
