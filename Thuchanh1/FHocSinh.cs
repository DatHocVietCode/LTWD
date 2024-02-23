using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;
namespace Thuchanh1
{
    public partial class FHocSinh : Form
    {
     
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(DBConnection.DBLoad("HocSinh"));
          
        }
        private void UpdateDataGridView(DataTable dataTable)
        {
            gv1.DataSource = dataTable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text,dtpDoB.Value, float.Parse(txt_diem.Text));
            HocSinhDAO.Add(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value, float.Parse(txt_diem.Text));
            HocSinhDAO.Delete(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value, float.Parse(txt_diem.Text));
            //HocSinhDAO.Edit(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }
        private void gv1_CellClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FGiaoVien form = new FGiaoVien();
            form.Show();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txtFullName.Clear();
            txtIdentifyNum.Clear();
            txt_gioitinh.Clear();
            txtAddress.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            MessageBox.Show("All textbox cleared!", "Notifycation");
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            FLoc fLoc = new FLoc();
            fLoc.ShowDialog();
            string option = fLoc.Return_Option();
            //MessageBox.Show(option);

        }
    }
}
