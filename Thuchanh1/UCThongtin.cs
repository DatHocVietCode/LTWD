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
            mtxt_phone.Mask = "000-0000-000";
            cb_gioitinh.SelectedItem = "Unknown";
        }
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
    
        private void gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txtFullName.Clear();
            txtIdentifyNum.Clear();
            cb_gioitinh.SelectedItem = "Unknown";
            txtAddress.Clear();
            txt_email.Clear();
            mtxt_phone.Clear();
            txt_Diem.Clear();
            MessageBox.Show("All textbox cleared!", "Notification");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             
        }
    }
}
