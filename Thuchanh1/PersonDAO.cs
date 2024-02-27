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
            if (age_res < 17)
            {
                System.Windows.Forms.MessageBox.Show("Your age is under 17!", "Notice");
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
            return (Check_ID(giaoVien.ID1,"GiaoVien") && (Check_CMND(giaoVien.Cmnd)) &&
                (Check_Name(giaoVien.Fullname)) && (check_Sex(giaoVien.Gioitinh)) && (Check_DoB(giaoVien.Dob)) && 
                (Check_Address(giaoVien.Address)) && (Check_Email(giaoVien.Email)) && (Check_phone(giaoVien.Phone)));
        }
      
        public static bool Check_Information(HocSinh_class hocSinh_)
        {
            return (Check_ID(hocSinh_.ID1, "HocSinh") && (Check_CMND(hocSinh_.Cmnd)) &&
                (Check_Name(hocSinh_.Fullname)) && (check_Sex(hocSinh_.Gioitinh)) && (Check_DoB(hocSinh_.Dob)) &&
                (Check_Address(hocSinh_.Address)) && (Check_Email(hocSinh_.Email)) && (Check_phone(hocSinh_.Phone)) 
                && Check_Diem(hocSinh_.Diem1));
        }
        public static bool Check_state_1(string t1, string t2, string t3, string t4, string t5, string t6, string t7) 
        {
          if (t1 == null || t1 == string.Empty || t2 == null || t2 == string.Empty ||
                t3 == null || t3 == string.Empty || t3 == null || t3 == string.Empty ||
                t4 == null || t4 == string.Empty || t5 == null || t5 == string.Empty ||
                t6 == null || t6 == string.Empty || t7 == null || t7 == string.Empty) 
                   return false;
          return true;
        }
        public static DataTable Delete(string ID, string role)
        {
            string sqlStr = string.Format("DELETE FROM " + role + " WHERE ID = '{0}'", ID);
            return DBConnection.Process(sqlStr, role);
        }

    }
}