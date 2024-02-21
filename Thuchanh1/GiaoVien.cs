using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
    class GiaoVien : Person
    {
        public GiaoVien()
        {
        }

        public GiaoVien(string fullname, string address, string cmnd, DateTime dob) : base(fullname, address, cmnd, dob)
        {
        }
    }
}
