using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace Thuchanh1
{
    internal class PersonDAO
    {
        public static bool Check_phone(string s)
        {
            if (s.Length !=10 || s[0]!='0') return false;
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                    continue;
                else
                    return false;
            }
            return true;
        }
        public static bool Check_Email(string s)
        {
            return s.Contains("@gmail.com");
        }
        public static bool Check_DoB(DateTime dt)
        {
            var age = DateTime.Now - dt;
            var age_res = age.TotalDays / 365.25;
            if (age_res <= 18)
                return false;
            return true;
        }
        public static bool Check_Information(GiaoVien_class giaoVien)
        {
            Person_InformationDataContext dataContext = new Person_InformationDataContext();
            var lst_person = (from s in dataContext.GiaoViens
                              select s).ToList();
            foreach (var s in lst_person)
            {
                if (s.ID == giaoVien.ID1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Check_Information(HocSinh_class giaoVien)
        {
            Person_InformationDataContext dataContext = new Person_InformationDataContext();
            var lst_person = (from s in dataContext.HocSinhs
                              select s).ToList();
            foreach (var s in lst_person)
            {
                if (s.ID == giaoVien.ID1)
                {
                    return false;
                }
            }
            return true;
        }
        public static DataTable Add(object person)
        {
            if (person.GetType() == typeof(GiaoVien_class)) 
            {
                string sqlStr = string.Empty;
                if (
                !Check_Information((GiaoVien_class)person) ||
                !Check_DoB(((GiaoVien_class)person).Dob) ||
                !Check_phone(((GiaoVien_class)person).Phone) ||
                !Check_Email(((GiaoVien_class)person).Email) 
                )
                {
                    sqlStr = "select * from GiaoVien";
                    return DBConnection.Process(sqlStr, "GiaoVien");
                }

                sqlStr = string.Format("INSERT INTO GiaoVien(ID, Cmnd, Ten, Sex, DoB, Diachi, Email, Phone) VALUES" +
                 " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                 , ((GiaoVien_class)person).ID1, ((GiaoVien_class)person).Cmnd, ((GiaoVien_class)person).Fullname, ((GiaoVien_class)person).Gioitinh,
                 ((GiaoVien_class)person).Dob, ((GiaoVien_class)person).Address, ((GiaoVien_class)person).Email, ((GiaoVien_class)person).Phone);
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            else
            {

                string sqlStr = string.Empty;
                if (
                !Check_Information((HocSinh_class)person) ||
                !Check_DoB(((HocSinh_class)person).Dob) ||
                !Check_phone(((HocSinh_class)person).Phone) ||
                !Check_Email(((HocSinh_class)person).Email)
                )
                {
                    sqlStr = "select * from HocSinh";
                    return DBConnection.Process(sqlStr, "HocSinh");
                }
                sqlStr = string.Format("INSERT INTO HocSinh(ID, Cmnd, Ten, Sex, DoB, Diachi, Email, Phone) VALUES" +
                   " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                 , ((HocSinh_class)person).ID1, ((HocSinh_class)person).Cmnd, ((HocSinh_class)person).Fullname, ((HocSinh_class)person).Gioitinh,
                 ((HocSinh_class)person).Dob, ((HocSinh_class)person).Address, ((HocSinh_class)person).Email, ((HocSinh_class)person).Phone);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
        }
       /* public static DataTable Edit(object person)
        {
            if (person.GetType() == typeof(GiaoVien))
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
           
        }*/
        public static DataTable Delete(object person)
        {
            if (person.GetType() == typeof(GiaoVien))
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