
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
        /*   public static DataTable AddHocSinh(HocSinh hocsinh)
           {
               string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, DoB) VALUES" +
                       " ('{0}', '{1}', '{2}', '{3}')"
                       , hocsinh.Fullname, hocsinh.Address, hocsinh.Cmnd, hocsinh.Dob);
               return DBConnection.Process(sqlStr, "HocSinh");
           }
           public static DataTable EditHocSinh(HocSinh hocsinh)
           {
               string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi = '{1}', DoB = '{2}'" +
                       " WHERE Cmnd = '{3}'", hocsinh.Fullname, hocsinh.Address, hocsinh.Dob, hocsinh.Cmnd);
               return DBConnection.Process(sqlStr, "HocSinh");
           }
           public static DataTable DeleteHocSinh(HocSinh hocsinh)
           {
               string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", hocsinh.Cmnd);
               return DBConnection.Process(sqlStr, "HocSinh");
           }*/
    }
}