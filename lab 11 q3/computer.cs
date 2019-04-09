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
        public virtual string Format()
        {
            return "Company: " + Company + "\nCountry: " + Country;
        }
        public override string ToString()
        {
            return Company.ToString() + Country.ToString();
        }
    }

        class Laptop : computer
        {
            private string _lapname;
            private string _lapcolour;
            public string lapname
            {
                get
                {
                    return _lapname;
                }
                set
                {
                    _lapname = value;
                }
            }
            public string lapcolour
            {
                get
                {
                    return _lapcolour;
                }
                set
                {
                    _lapcolour = value;
                }
            }
            public Laptop(string com, string c, string ln, string lc) : base(com, c)
            {
                _lapname = ln;
                _lapcolour = lc;
            }
            public virtual string FormatLaptop()
            {
                return "Company: " + Company + "\nCountry: " + Country + "\nLaptop Name: " + lapname + "\nLaptop Colour: " + lapcolour;
            }
            public override string ToString()
            {
                return Company.ToString() + Country.ToString() + lapname.ToString() + lapcolour.ToString();
            }


        }
        class Desktop : computer
        {
            private string _deskname;
            private string _deskcolour;
            public string deskname
            {
                get
                {
                    return _deskname;
                }
                set
                {
                    _deskname = value;
                }
            }
            public string deskcolour
            {
                get
                {
                    return _deskcolour;
                }
                set
                {
                    _deskcolour = value;
                }
            }
            public Desktop(string com, string c, string dn, string dc) : base(com, c)
            {
                _deskname = dn;
                _deskcolour = dc;
            }
            public virtual string FormatDesk()
            {
                return "Company: " + Company + "\nCountry: " + Country + "\nDesktop Name: " + deskname + "\nDesktop Colour: " + deskcolour;
            }
            public override string ToString()
            {
                return Company.ToString() + Country.ToString() + deskname.ToString() + deskcolour.ToString();
            }
        }
    }
