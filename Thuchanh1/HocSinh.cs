using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
    class HocSinh : Person
    {
        public HocSinh()
        {
        }

        public HocSinh(string iD, string phone, string email, string gioitinh, string fullname, string address, string cmnd, DateTime dob) : base(iD, phone, email, gioitinh, fullname, address, cmnd, dob)
        {
        }
    }
}
