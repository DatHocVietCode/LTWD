using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
     class Person 
    {
        string ID = string.Empty;
        string phone = string.Empty;
        string email = string.Empty;
        string gioitinh = string.Empty;
        string fullname = string.Empty;
        string address = string.Empty;
        string cmnd = string.Empty;
        DateTime dob = DateTime.MinValue;

        public Person()
        {
        }

        public Person(string iD, string phone, string email, string gioitinh, string fullname, string address, string cmnd, DateTime dob)
        {
            ID1 = iD;
            this.phone = phone;
            this.email = email;
            this.gioitinh = gioitinh;
            this.fullname = fullname;
            this.address = address;
            this.cmnd = cmnd;
            this.dob = dob;
        }

        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Dob { get => dob; set => dob = value; }
       
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string ID1 { get => ID; set => ID = value; }
    }
}
