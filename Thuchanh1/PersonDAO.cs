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
            if (s.Length !=10 || s[0]!='0')
            {
                System.Windows.Forms.MessageBox.Show("Your phone number is invalid", "Notice");
                return false;
            }
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                    continue;
                else
                {
                    System.Windows.Forms.MessageBox.Show("Your phone number is invalid", "Notice");
                    return false;
                }  
            }
            return true;
        }
        public static bool Check_Email(string s)
        {
            if (s.Contains("@gmail.com"))
            {
                return true;
            }
            System.Windows.Forms.MessageBox.Show("Your email is invalid!", "Notice");
            return false;
        }
        public static bool Check_DoB(DateTime dt)
        {
            var age = DateTime.Now - dt;
            var age_res = age.TotalDays / 365.25;
            if (age_res <= 18)
            {
                System.Windows.Forms.MessageBox.Show("Your age is under 18!", "Notice");
                return false;
            }
            return true;
        }
        public static bool Check_Name(string name)
        {
            if (name == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Your name can not be empty!", "Notice");
                return false;
            }
               
            return true;
        }
        public static bool check_Sex(string sex)
        {
            if (sex == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Your sex can not be empty!", "Notice");
                return false;
            }
            return true;
        }
        public static bool Check_Address(string address)
        {
            if (address == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Your address can not be empty!", "Notice");
                return false;
            }
            return true;
        }
        public static bool Check_CMND(string CMND)
        {
           /* if (!Check_phone(CMND))
            {
                //System.Windows.Forms.MessageBox.Show("Your CMND may contain white spaces or not a character!\nPlease check it carefully", "Warning!!!");

                return false;
            }*/
            if (CMND==string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Your CMND is invalid!", "Warning!!!");
                return false; }
            return true;
        }
        public static bool Check_Diem(double diem)
        {
            if (diem < 0 || diem >10)
            {
                System.Windows.Forms.MessageBox.Show("Your score is invalid!","Notice");
                return false;
            }
            return true;
        }
        public static bool Check_ID(string ID, string role)
        {
            if (ID == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Your ID can not be empty!", "Warning!!!");
                return false;
            }
            Person_InformationDataContext dataContext = new Person_InformationDataContext();
            if (role == "GiaoVien")
            {
                var lst_person = (from s in dataContext.GiaoViens
                                  select s).ToList();
                foreach (var s in lst_person)
                {
                    //System.Windows.Forms.MessageBox.Show(s.ID);
                    if (s.ID == ID)
                    {
                        System.Windows.Forms.MessageBox.Show("The ID has already exist! Please change to another ID!", "Notice");
                        return false;
                    }
                }

            }
            else
            {
                var lst_person = (from s in dataContext.HocSinhs
                                  select s).ToList();
                foreach (var s in lst_person)
                {
                   /* System.Windows.Forms.MessageBox.Show(s.ID);
                    System.Windows.Forms.MessageBox.Show(ID);*/
                    if (s.ID == ID)
                    {
                        System.Windows.Forms.MessageBox.Show("The ID has already exist! Please change to another ID!", "Notice");
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool Check_Information(GiaoVien_class giaoVien)
        {
            /* if (giaoVien.ID1 == string.Empty)
             {
                 System.Windows.Forms.MessageBox.Show("Your ID can not be empty!", "Warning!!!");
                 return false;
             }
             Person_InformationDataContext dataContext = new Person_InformationDataContext();
             var lst_person = (from s in dataContext.GiaoViens
                               select s).ToList();
             foreach (var s in lst_person)
             {
                 if (s.ID == giaoVien.ID1)
                 {
                     System.Windows.Forms.MessageBox.Show("The ID has already exist! Please change to another ID!", "Notice");
                     return false;
                 }
             }
             return true;*/
            return (Check_ID(giaoVien.ID1,"GiaoVien") && (Check_CMND(giaoVien.Cmnd)) &&
                (Check_Name(giaoVien.Fullname)) && (check_Sex(giaoVien.Gioitinh)) && (Check_DoB(giaoVien.Dob)) && 
                (Check_Address(giaoVien.Address)) && (Check_Email(giaoVien.Email)) && (Check_phone(giaoVien.Phone)));
        }
      
        public static bool Check_Information(HocSinh_class hocSinh_)
        {
            /* if (hocSinh_.ID1 == string.Empty)
             {
                 System.Windows.Forms.MessageBox.Show("Your ID can not be empty!", "Warning!!!");
                 return false;
             }
             Person_InformationDataContext person_InformationDataContext = new Person_InformationDataContext();
             var lst_person = (from s in person_InformationDataContext.HocSinhs
                               select s).ToList();
             foreach (var s in lst_person)
             {
                 if (s.ID == hocSinh_.ID1)
                 {
                     System.Windows.Forms.MessageBox.Show("The ID has already exist! Please change to another ID!", "Notice");
                     return false;
                 }
             }
             return true;*/
            return (Check_ID(hocSinh_.ID1, "HocSinh") && (Check_CMND(hocSinh_.Cmnd)) &&
                (Check_Name(hocSinh_.Fullname)) && (check_Sex(hocSinh_.Gioitinh)) && (Check_DoB(hocSinh_.Dob)) &&
                (Check_Address(hocSinh_.Address)) && (Check_Email(hocSinh_.Email)) && (Check_phone(hocSinh_.Phone)) && Check_Diem(hocSinh_.Diem1));
        }
        
        public static DataTable Add(object person)
        {
            if (person.GetType() == typeof(GiaoVien_class)) 
            {
                string sqlStr = string.Empty;
                if (!Check_Information((GiaoVien_class)person))
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
                if ((!Check_Information((HocSinh_class)person)))
                {
                    sqlStr = "select * from HocSinh";
                    return DBConnection.Process(sqlStr, "HocSinh");
                }
                sqlStr = string.Format("INSERT INTO HocSinh(ID, Cmnd, Ten, Sex, DoB, Diachi, Email, Phone, Diem) VALUES" +
                   " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                 , ((HocSinh_class)person).ID1, ((HocSinh_class)person).Cmnd, ((HocSinh_class)person).Fullname, ((HocSinh_class)person).Gioitinh,
                 ((HocSinh_class)person).Dob, ((HocSinh_class)person).Address, ((HocSinh_class)person).Email, ((HocSinh_class)person).Phone, ((HocSinh_class)person).Diem1);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
        }
        public static DataTable Edit(object person)
        {
            if (person.GetType() == typeof(GiaoVien))
            {
                string sqlStr = string.Format("UPDATE GiaoVien SET CMND = '{1}', Ten = '{2}', Sex = '{3}', DoB = '{4}', DiaChi = '{5}', Email = '{6}', Phone = '{7}'" +
                     " WHERE ID = '{0}'", ((GiaoVien_class)person).ID1, ((GiaoVien_class)person).Cmnd, ((GiaoVien_class)person).Fullname,
                     ((GiaoVien_class)person).Gioitinh, ((GiaoVien_class)person).Dob
                     , ((GiaoVien_class)person).Address, ((GiaoVien_class)person).Email, ((GiaoVien_class)person).Phone);
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            else
            {
                string sqlStr = string.Format("UPDATE HocSinh SET CMND = '{1}', Ten = '{2}', Sex = '{3}', DoB = '{4}', DiaChi = '{5}', Email = '{6}', Phone = '{7}', Diem = '{8}'" +
                     " WHERE ID = '{0}'", ((HocSinh_class)person).ID1, ((HocSinh_class)person).Cmnd, ((HocSinh_class)person).Fullname,
                     ((HocSinh_class)person).Gioitinh, ((HocSinh_class)person).Dob
                     , ((HocSinh_class)person).Address, ((HocSinh_class)person).Email, ((HocSinh_class)person).Phone, ((HocSinh_class)person).Diem1);
                return DBConnection.Process(sqlStr, "HocSinh");
            }

        }
        public static DataTable Delete(object person)
        {
            if (person.GetType() == typeof(GiaoVien))
            {
                string sqlStr = string.Format("DELETE FROM GiaoVien WHERE ID = '{0}'", ((GiaoVien_class)person).ID1);
                return DBConnection.Process(sqlStr, "GiaoVien");
              
            }
            else
            {
                string sqlStr = string.Format("DELETE FROM HocSinh WHERE ID = '{0}'", ((HocSinh_class)person).ID1);
                return DBConnection.Process(sqlStr, "HocSinh");
            }
        }

    }
}