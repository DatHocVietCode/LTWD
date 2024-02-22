using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
    class GiaoVien_class : Person
    {
        public GiaoVien_class()
        {
        }

        public GiaoVien_class(string iD, string phone, string email, string gioitinh, string fullname, string address, string cmnd, DateTime dob) : base(iD, phone, email, gioitinh, fullname, address, cmnd, dob)
        {
        }
    }
}
