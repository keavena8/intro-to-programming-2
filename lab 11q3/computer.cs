using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class computer
    {
        private string _company;
        private string _country;
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public computer(string com, string c)
        {
            _company = com;
            _country = c;
        }
        public string Format()
        {
            return "Company: " + Company + "\nCountry: " + Country;
        }
        public override string ToString()
        {
            return Company.ToString() + Country.ToString();
        }

        class laptop : computer
        {
            private lapname;
            private lapcolour;
            public 
        

        }
    }
}
