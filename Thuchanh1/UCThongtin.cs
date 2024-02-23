using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh1
{
    public partial class UCThongtin : UserControl
    {
        public UCThongtin()
        {
            InitializeComponent();
        }

       /* private void gv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gv1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_ID.Text = row.Cells[0].Value.ToString();
                txtIdentifyNum.Text = row.Cells[1].Value.ToString();
                txtFullName.Text = row.Cells[2].Value.ToString();
                txt_gioitinh.Text = row.Cells[3].Value.ToString();
                dtpDoB.Value = (DateTime)(row.Cells[4].Value);
                txtAddress.Text = row.Cells[5].Value.ToString();
                txt_email.Text = row.Cells[6].Value.ToString();
                txt_phone.Text = row.Cells[7].Value.ToString();
                //MessageBox.Show(e,row);
                //if)
                    txt_Diem.Text = row.Cells[8].Value.ToString();
            }
        }*/

        private void lbl_Diem_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void UCThongtin_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(DBConnection.DBLoad("HocSinh", ""));
            lbl_Diem.Visible = true;
            txt_Diem.Visible = true;
        }
        private void UpdateDataGridView(DataTable dataTable)
        {
            gv1.DataSource = dataTable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text,
             txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value, float.Parse(txt_Diem.Text));
            HocSinhDAO.Add(hocsinh);
            UCThongtin_Load(this, EventArgs.Empty);*/
        }

        private void gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Diem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
