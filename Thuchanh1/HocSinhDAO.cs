
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thuchanh1
{

    internal class HocSinhDAO : PersonDAO
    {
        
        public static bool Check_input(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8)
        {
            return Check_state_1(t1,t2,t3,t4,t5,t6,t7) && double.TryParse(t8, out double temp);
        }
        public static DataTable AddHocSinh(HocSinh_class hocsinh)
           {
                string sqlStr = string.Empty;
                if ((!Check_Information(hocsinh)))
                {
                    sqlStr = "select * from HocSinh";
                    return DBConnection.Process(sqlStr, "HocSinh");
                }

                sqlStr = string.Format("INSERT INTO HocSinh(ID, Cmnd, Ten, Sex, DoB, Diachi, Email, Phone, Diem) VALUES" +
                   " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                 , hocsinh.ID1, hocsinh.Cmnd, hocsinh.Fullname, hocsinh.Gioitinh,
                 hocsinh.Dob, hocsinh.Address, hocsinh.Email, hocsinh.Phone, hocsinh.Diem1);
                return DBConnection.Process(sqlStr, "HocSinh");
           }
           public static DataTable EditHocSinh(HocSinh_class hocsinh)
           {
            string sqlStr = string.Format("UPDATE HocSinh SET CMND = '{1}', Ten = '{2}', Sex = '{3}', DoB = '{4}', DiaChi = '{5}', Email = '{6}', Phone = '{7}', Diem = '{8}'" +
                " WHERE ID = '{0}'", hocsinh.ID1, hocsinh.Cmnd, hocsinh.Fullname,
                hocsinh.Gioitinh, hocsinh.Dob
                , hocsinh.Address, hocsinh.Email, hocsinh.Phone, hocsinh.Diem1);
            return DBConnection.Process(sqlStr, "HocSinh");
           }
      
        public static DataTable LocHocSinh(string option)
        {
            throw new NotImplementedException();
        }
    }
}