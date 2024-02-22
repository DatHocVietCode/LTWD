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
    
            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text,dtpDoB.Value);
            HocSinhDAO.Add(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value);
            HocSinhDAO.Delete(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            HocSinh_class hocsinh = new HocSinh_class(txt_ID.Text, txt_phone.Text, txt_email.Text, txt_gioitinh.Text, txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value);
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
                txtFullName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtIdentifyNum.Text = row.Cells[2].Value.ToString();
                dtpDoB.Value = (DateTime)row.Cells[3].Value;
            }
        }
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FGiaoVien form = new FGiaoVien();
            form.Show();
        }
    }
}
