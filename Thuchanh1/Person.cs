using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
     class Person 
    {
        string fullname = string.Empty;
        string address = string.Empty;
        string cmnd = string.Empty;
        DateTime dob = DateTime.MinValue;

        public Person()
        {
        }

        public Person(string fullname, string address, string cmnd, DateTime dob)
        {
            this.fullname = fullname;
            this.address = address;
            this.cmnd = cmnd;
            this.dob = dob;
        }

        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Dob { get => dob; set => dob = value; }


    }
}
