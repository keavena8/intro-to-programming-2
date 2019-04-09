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
            return  Company  + Country;
        }
        public override string ToString()
        {
            return "Company: " + Company.ToString() + "\nCountry: " + Country.ToString();
        }
    }

    class laptop : computer
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
        public laptop (string com, string c, string ln,string lc) : base(com, c)
        {
            _lapname = ln;
            _lapcolour = lc;
        }
        public override string Format()
        {
            return  Company  + Country  + lapname + lapcolour;
        }
        public override string ToString()
        {
            return base.ToString() + "\nLapTop Name: " + lapname + "\nLaptop Colour: " + lapcolour;
        }

    }
    class desktop : computer
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
        public desktop (string com, string c, string dn, string dc) : base(com,c)
        {
            _deskname = dn;
            _deskcolour = dc;
        }
        public override string Format()
        {
            return Company + Country + deskname + deskcolour;
        }
        public override string ToString()
        {
            return base.ToString() + "\nDesktop Name: " + deskname + "\nDesktop Colour: " + deskcolour; 
        }
    }
    
}
