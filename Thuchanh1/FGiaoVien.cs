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
            UpdateDataGridView(DBConnection.DBLoad("GiaoVien"));
        }
        private void UpdateDataGridView(DataTable dataTable)
        {
            gv1.DataSource = dataTable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value);
            GiaoVienDAO.Add(giaoVien);
            Form2_Load(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value);
            GiaoVienDAO.Delete(giaoVien);
            Form2_Load(this, EventArgs.Empty);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtFullName.Text, txtAddress.Text, txtIdentifyNum.Text, dtpDoB.Value);
            GiaoVienDAO.Edit(giaoVien);
            Form2_Load(this, EventArgs.Empty);

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

        private void lblIdentifyNum_Click(object sender, EventArgs e)
        {

        }
    }
}
