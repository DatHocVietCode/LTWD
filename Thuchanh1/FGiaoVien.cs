using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh1
{
    public partial class FGiaoVien : Form
    {
        /*SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.QlyHS);*/
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(DBConnection.DBLoad("GiaoVien",""));
            ucThongtin1.lbl_Diem.Visible = false;
            ucThongtin1.txt_Diem.Visible = false;
            ucThongtin1.btnAdd.Click += BtnAdd_Click;
            ucThongtin1.btnEdit.Click += BtnEdit_Click;
            ucThongtin1.btnDelete.Click += BtnDelete_Click;
            ucThongtin1.gv1.CellClick += Gv1_CellClick;
            ucThongtin1.btn_reload.Click += Btn_reload_Click;
        }
        private void Gv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.ucThongtin1.gv1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                ucThongtin1.txt_ID.Text = row.Cells[0].Value.ToString();
                ucThongtin1.txtIdentifyNum.Text = row.Cells[1].Value.ToString();
                ucThongtin1.txtFullName.Text = row.Cells[2].Value.ToString();
                ucThongtin1.txt_gioitinh.Text = row.Cells[3].Value.ToString();
                ucThongtin1.dtpDoB.Value = (DateTime)(row.Cells[4].Value);
                ucThongtin1.txtAddress.Text = row.Cells[5].Value.ToString();
                ucThongtin1.txt_email.Text = row.Cells[6].Value.ToString();
                ucThongtin1.txt_phone.Text = row.Cells[7].Value.ToString();
                //ucThongtin1.txt_Diem.Text = row.Cells[8].Value.ToString();
            }
        }
        private void Btn_reload_Click(object sender, EventArgs e)
        {
            ucThongtin1.txt_ID.Clear();
            ucThongtin1.txtFullName.Clear();
            ucThongtin1.txtIdentifyNum.Clear();
            ucThongtin1.txt_gioitinh.Clear();
            ucThongtin1.txtAddress.Clear();
            ucThongtin1.txt_email.Clear();
            ucThongtin1.txt_phone.Clear();
            ucThongtin1.txt_Diem.Clear();
            MessageBox.Show("All textbox cleared!", "Notifycation");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value);
            GiaoVienDAO.Delete(giaoVien);
            Form2_Load(this, EventArgs.Empty);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value);
            GiaoVienDAO.Edit(giaoVien);
            Form2_Load(this, EventArgs.Empty);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value);
            GiaoVienDAO.Add(giaoVien);
            Form2_Load(this, EventArgs.Empty);
        }

        private void UpdateDataGridView(DataTable dataTable)
        {
            ucThongtin1.gv1.DataSource = dataTable;
        }
 /*       private void btnAdd_Click(object sender, EventArgs e)
        {

            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.   txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text,    ucThongtin1.    dtpDoB.Value);
            GiaoVienDAO.Add(giaoVien);
            Form2_Load(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value);
            GiaoVienDAO.Delete(giaoVien);
            Form2_Load(this, EventArgs.Empty);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GiaoVien_class giaoVien = new GiaoVien_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, ucThongtin1.  txt_email.Text, ucThongtin1.txt_gioitinh.Text, ucThongtin1.txtFullName.Text, ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value);
            GiaoVienDAO.Edit(giaoVien);
            Form2_Load(this, EventArgs.Empty);

        }*/

      /*  private void gv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gv1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtFullName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtIdentifyNum.Text = row.Cells[2].Value.ToString();
                dtpDoB.Value = (DateTime)row.Cells[3].Value;
            }
        }*/

        private void lblIdentifyNum_Click(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            ucThongtin1.txt_ID.Clear();
            ucThongtin1.txtFullName.Clear();
            ucThongtin1.txtIdentifyNum.Clear();
            ucThongtin1.txt_gioitinh.Clear();
            ucThongtin1.txtAddress.Clear();
            ucThongtin1.txt_email.Clear();
            ucThongtin1.txt_phone.Clear();
            MessageBox.Show("All textbox cleared!", "Notifycation");
        }

        private void ucThongtin1_Load(object sender, EventArgs e)
        {

        }
    }
}
