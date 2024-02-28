using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh1
{
    internal class GiaoVienDAO : PersonDAO
    {
        public static bool Check_input_giaovien(string t1, string t2, string t3, string t4, string t5, string t6, string t7)
        {
           
            return Check_state_1(t1,t2,t3,t4,t5,t6,t7);
        }
        public static DataTable AddGiaoVien(GiaoVien_class giaovien)
        {
            string sqlStr = string.Empty;
            if (!(Check_Information(giaovien) && Check_ID(giaovien.ID1,"GiaoVien")))
            {
                sqlStr = "select * from GiaoVien";
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            sqlStr = string.Format("INSERT INTO GiaoVien(ID, Cmnd, Ten, Sex, DoB, Diachi, Email, Phone) VALUES" +
             " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
             , giaovien.ID1, giaovien.Cmnd, giaovien.Fullname, giaovien.Gioitinh,
             giaovien.Dob, giaovien.Address, giaovien.Email, giaovien.Phone);
            return DBConnection.Process(sqlStr, "GiaoVien");

        }
        public static DataTable EditGiaoVien(GiaoVien_class giaovien)
        {
            string sqlStr = string.Empty;
            if (!Check_Information(giaovien))
            {
                sqlStr = "select * from GiaoVien";
                return DBConnection.Process(sqlStr, "GiaoVien");
            }
            sqlStr = string.Format("UPDATE GiaoVien SET CMND = '{1}', Ten = '{2}', Sex = '{3}', DoB = '{4}', DiaChi = '{5}', Email = '{6}', Phone = '{7}'" +
                     " WHERE ID = '{0}'", giaovien.ID1, giaovien.Cmnd, giaovien.Fullname,
                     giaovien.Gioitinh, giaovien.Dob
                     , giaovien.Address, giaovien.Email, giaovien.Phone);
            return DBConnection.Process(sqlStr, "GiaoVien");
        }
    }
}
