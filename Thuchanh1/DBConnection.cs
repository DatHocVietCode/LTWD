using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Thuchanh1
{
    internal class DBConnection
    {
        public static DataTable DBLoad(string DBName, string option)
        {
            string condition = string.Empty;
            switch (option)
            {
                case "Option 1":
                    condition = " where Diem>=8";
                    break;
                case "Option 2":
                    condition = " where Diem>=5 and Diem<8";
                    break;
                case "Option 3":
                    condition = " where Diem<5";
                    break;
                default:
                    break;
            }
            DataTable dtSinhVien = new DataTable();
            try
            {
                SQLConnection.conn.Open();
                string sqlStr = string.Format("select * from " + DBName + condition);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, SQLConnection.conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

                SQLConnection.conn.Close();
            }
            return dtSinhVien;
        }
        public static DataTable Process(string command, string DBName)
        {
            try
            {
                // Ket noi
                SQLConnection.conn.Open();
                SqlCommand cmd = new SqlCommand(command, SQLConnection.conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Process done!", "Notice");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors occur during process!" + ex, "Warning");
            }
            finally
            {
                SQLConnection.conn.Close();

            }
            return DBLoad(DBName,"");
        }
    }
}
