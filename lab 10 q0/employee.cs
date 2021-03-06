﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class employee
    {
        private string _empName;
        private string _gender;
        private int _hourlyRate;
        private string _nationality;
        private string _visaStatus;

        public string Name
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;

            }
            set
            {
                _gender = value;

            }
        }
        public int HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
            set
            {
                _hourlyRate = value;
            }
        }
        public string Nationality
        {
            get
            {
                return _nationality;
            }
            private set
            {
                if (_nationality == "American")
                {
                    _visaStatus = "Visa Required";
                    _visaStatus = value;
                }
            }
        }


        public employee(string e, string g, int h, string n)
        {
            _empName = e;
            _gender = g;
            _hourlyRate = h;
            _nationality = n;

        }
        public override string ToString()
        {
            return "Name: " + Name + "\nGender: " + Gender + "\nHourly Rate: " + HourlyRate + "\nNationality: " + Nationality;
        }
    }
}
