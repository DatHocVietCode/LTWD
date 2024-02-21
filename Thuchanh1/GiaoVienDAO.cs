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
        /*  public static DataTable AddGiaoVien(GiaoVien giaovien)
          {
              string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi, Cmnd, DoB) VALUES" +
                      " ('{0}', '{1}', '{2}', '{3}')"
                      , giaovien.Fullname, giaovien.Address, giaovien.Cmnd, giaovien.Dob);
              return DBConnection.Process(sqlStr, "GiaoVien");

          }
          public static DataTable EditGiaoVien(GiaoVien giaovien)
          {
              string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', Diachi = '{1}', DoB = '{2}'" +
                      " WHERE Cmnd = '{3}'", giaovien.Fullname, giaovien.Address, giaovien.Dob, giaovien.Cmnd);
              return DBConnection.Process(sqlStr, "GiaoVien");
          }
          public static DataTable DeleteGiaoVien(GiaoVien giaovien)
          {
              string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", giaovien.Cmnd);
              return DBConnection.Process(sqlStr, "GiaoVien");
          }*/
    }
}
