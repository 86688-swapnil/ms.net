using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Month
        {
            get { return month; }
            set { month = value; }
        }


        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public void Accept()
        {
            Console.WriteLine("enter day ");
            day=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter month ");
            month=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year ");
            year=Convert.ToInt32(Console.ReadLine());

        }
        public void Print()
        {
            Console.WriteLine("day " +day+ " - " +month+ " - " +year);
        }
        public bool IsValid()
        {
           if(day<1||day>=31||month<1||month>=12)
            {
                Console.WriteLine("Invalid date ");
            }
            else
            {
               if(year%2==0)
                {


                    Console.WriteLine("date is " +day+ "/" + month+ "/" +year);
                }
            }
           return true;
        }

        public override string ToString()
        {
            return $"{{{nameof(Year)}={Year.ToString()}, {nameof(Month)}={Month.ToString()}, {nameof(Day)}={Day.ToString()}}}";
        }

        public static int DifferneceInYear(Date date1, Date date2)
        {
            return (date1.Year - date2.Year);
        }

        public static int operator -(Date date1, Date date2)
        {
            return DifferneceInYear(date1 ,date2);
        }
    }
}
