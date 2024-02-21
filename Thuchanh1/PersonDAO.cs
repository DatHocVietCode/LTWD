using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;

namespace Thuchanh1
{
    internal class PersonDAO
    {
        public static DataTable Add(object person)
        {
            if (typeof(Person) == typeof(GiaoVien)) 
            {
                string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi, Cmnd, DoB) VALUES" +
                 " ('{0}', '{1}', '{2}', '{3}')"
                 , ((GiaoVien)person).Fullname, ((GiaoVien)person).Address, ((GiaoVien)person).Cmnd, ((GiaoVien)person).Dob);
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            else
            {
                string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, DoB) VALUES" +
                    " ('{0}', '{1}', '{2}', '{3}')"
                    , ((HocSinh)person).Fullname, ((HocSinh)person).Address, ((HocSinh)person).Cmnd, ((HocSinh)person).Dob);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
        }
        public static DataTable Edit(object person)
        {
            if (typeof(Person) == typeof(GiaoVien))
            {
                string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', Diachi = '{1}', DoB = '{2}'" +
                     " WHERE Cmnd = '{3}'", ((GiaoVien)person).Fullname, ((GiaoVien)person).Address, ((GiaoVien)person).Dob, ((GiaoVien)person).Cmnd);
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            else
            {
                string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi = '{1}', DoB = '{2}'" +
                     " WHERE Cmnd = '{3}'", ((HocSinh)person).Fullname, ((HocSinh)person).Address, ((HocSinh)person).Dob, ((HocSinh)person).Cmnd);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
           
        }
        public static DataTable Delete(object person)
        {
            if (typeof(Person) == typeof(GiaoVien))
            {
                string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", ((GiaoVien)person).Cmnd);
                return DBConnection.Process(sqlStr, "GiaoVien");
              
            }
            else
            {
                string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", ((HocSinh)person).Cmnd);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
        }

    }
}