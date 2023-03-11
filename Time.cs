using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2Bai1
{
    class Time
    {
        //field
        private int hour;
        private int minute;
        private int second;

        //properties
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                if (value > 0 && value < 59)
                {
                    this.hour = value;
                }
                else
                {
                    throw new Exception("No input validation needed");
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                if (value > 0 && value < 59)
                {
                    this.minute = value;
                }
                else
                {
                    throw new Exception("No input validation needed");
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if (value > 0 && value < 59)
                {
                    this.second = value;
                }
                else
                {
                    throw new Exception("No input validation needed");
                }
            }
        }
        //Constructor
        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            if (hour >= 0 && hour <= 59)
            {
                this.hour = hour;
            }
            else
            {
                throw new Exception("No input validation needed");
            }
            if (minute >= 0 && minute <= 59)
            {
                this.minute = minute;
            }
            else
            {
                throw new Exception("No input validation needed");
            }
            if (second >= 0 && second <= 59)
            {
                this.second = second;
            }
            else
            {
                throw new Exception("No input validation needed");
            }
        }
        public void setTime(Time t)
        {
            this.hour = t.hour;
            this.minute = t.minute;
            this.second = t.second;
        }
        //method
        public string toString()
        {
            string result;
            return result = ($"{this.hour:00}:{this.minute:00}:{this.second:00}");
        }
        public Time nextSecond()
        {

            Time timeMoi = new Time();
            int tongGiay = this.hour * 3600 + this.minute * 60 + (this.second + 1);
            timeMoi.hour = tongGiay / 3600 == 24 ? 0 : (tongGiay / 3600) % 24;
            timeMoi.minute = (tongGiay % 3600 / 60);
            timeMoi.second = tongGiay % 60;
            return timeMoi;
        }

        public Time nextSecond1(int k)
        {

            Time timeMoi = new Time();
            int tongGiay = this.hour * 3600 + this.minute * 60 + (this.second + k);
            timeMoi.hour = tongGiay / 3600 == 24 ? 0 : (tongGiay / 3600) % 24;


            timeMoi.minute = (tongGiay % 3600 / 60);
            timeMoi.second = (tongGiay % 60);
            return timeMoi;

        }
        public Time previousSecond()
        {

            Time timeMoi = new Time();
            int gio = this.hour == 0 ? 24 : hour;
            int tongGiay = (gio * 3600) + (this.minute * 60) + (this.second - 1);

            timeMoi.hour = tongGiay / 3600 == 24 ? 0 : (tongGiay / 3600) % 24;
            timeMoi.minute = (tongGiay % 3600 / 60);
            timeMoi.second = tongGiay % 3600 % 60;
            return timeMoi;
        }
        public Time previousSecond1(int k)
        {
            int gio = this.hour == 0 ? 24 : hour;
            Time timeMoi = new Time();
            int tongGiay = gio * 3600 + this.minute * 60 + (this.second - k);
            timeMoi.hour = tongGiay / 3600 == 24 ? 0 : (tongGiay / 3600) % 24;
            timeMoi.minute = (tongGiay % 3600 / 60);
            timeMoi.second = tongGiay % 3600 % 60;
            return timeMoi;
        }

    }
}
