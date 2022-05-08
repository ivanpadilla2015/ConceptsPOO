using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)  //ctor y tab tab te crea el contructor
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year,month,day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >=1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new DayException("Invalid day"); //min 59:03 video 001
        }

        private bool IsleapYear(int year)
        {


            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //if (year % 4 == 0) // Ctr + k + c   crear comentarios
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }else
            //        {
            //            return false;
            //        }
            //    }else
            //    {
            //        return true;
            //    }
            //}else
            //{
            //    return false;
            //}
            throw new NotImplementedException();
        }

        private int CheckMonth(int month)
        {
            if(month >= 0 && month <= 12)
            {
                return month;
            }
            throw new MonthException("Invalid Month");
        }

        public override string ToString()
        {
            //return _year + "/" + _month + "/" + _day;
            return $"{_year}/{_month:00}/{_day:00}"; //interpolacion de string
        }
    }
}
