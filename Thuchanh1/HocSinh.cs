using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
    class HocSinh_class : Person
    {
        public HocSinh_class()
        {
        }

        public HocSinh_class(string iD, string phone, string email, string gioitinh, string fullname, string address, string cmnd, DateTime dob) : base(iD, phone, email, gioitinh, fullname, address, cmnd, dob)
        {
        }
    }
}
