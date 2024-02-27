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
using System.CodeDom;
namespace Thuchanh1
{
    public partial class FHocSinh : Form
    {
     
        public FHocSinh()
        {
            InitializeComponent();
            ucThongtin1.btnAdd.Click += BtnAdd_Click;
            ucThongtin1.btnEdit.Click += BtnEdit_Click;
            ucThongtin1.btnDelete.Click += BtnDelete_Click;
            ucThongtin1.gv1.CellClick += Gv1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(DBConnection.DBLoad("HocSinh", ""));
            ucThongtin1.lbl_Diem.Visible = true;
            ucThongtin1.txt_Diem.Visible = true;

         
        }
        private void Gv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    //gets a collection that contains all the rows
                    DataGridViewRow row = this.ucThongtin1.gv1.Rows[e.RowIndex];
                    if (row.Cells[0].Value.ToString() == "")
                    {
                        return;
                    }
                    //populate the textbox from specific value of the coordinates of column and row.
                    ucThongtin1.txt_ID.Text = row.Cells[0].Value.ToString();
                    ucThongtin1.txtIdentifyNum.Text = row.Cells[1].Value.ToString();
                    ucThongtin1.txtFullName.Text = row.Cells[2].Value.ToString();
                    ucThongtin1.cb_gioitinh.SelectedItem = row.Cells[3].Value.ToString().Trim();
                    ucThongtin1.dtpDoB.Value = (DateTime)(row.Cells[4].Value);
                    ucThongtin1.txtAddress.Text = row.Cells[5].Value.ToString();
                    ucThongtin1.txt_email.Text = row.Cells[6].Value.ToString();
                    ucThongtin1.txt_phone.Text = row.Cells[7].Value.ToString();
                    ucThongtin1.txt_Diem.Text = row.Cells[8].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                    
                }
              
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string ID = ucThongtin1.txt_ID.Text;
            PersonDAO.Delete(ID, "HocSinh");
            Form1_Load(this, EventArgs.Empty);
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!HocSinhDAO.Check_input(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text,
                        ucThongtin1.txt_email.Text, ucThongtin1.cb_gioitinh.SelectedItem.ToString(), ucThongtin1.txtFullName.Text,
                        ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.txt_Diem.Text))
            {
                MessageBox.Show("You can not let the input empty or your score is invalid!", "Notification");
                return;
            }
            HocSinh_class hocsinh = new HocSinh_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, 
                        ucThongtin1.txt_email.Text, ucThongtin1.cb_gioitinh.SelectedItem.ToString(), ucThongtin1.txtFullName.Text,
                        ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value, 
                        float.Parse(ucThongtin1.txt_Diem.Text));
            HocSinhDAO.EditHocSinh(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!HocSinhDAO.Check_input(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text,
                       ucThongtin1.txt_email.Text, ucThongtin1.cb_gioitinh.SelectedItem.ToString(), ucThongtin1.txtFullName.Text,
                       ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.txt_Diem.Text))
            {
                MessageBox.Show("You can not let the input empty or your score is invalid!", "Notification");
                return;
            }
            HocSinh_class hocsinh = new HocSinh_class(ucThongtin1.txt_ID.Text, ucThongtin1.txt_phone.Text, 
                        ucThongtin1.txt_email.Text, ucThongtin1.cb_gioitinh.SelectedItem.ToString(), ucThongtin1.txtFullName.Text,
                        ucThongtin1.txtAddress.Text, ucThongtin1.txtIdentifyNum.Text, ucThongtin1.dtpDoB.Value, 
                        float.Parse(ucThongtin1.txt_Diem.Text));
            HocSinhDAO.AddHocSinh(hocsinh);
            Form1_Load(this, EventArgs.Empty);
        }
        private void UpdateDataGridView(DataTable dataTable)
        {
            ucThongtin1.gv1.DataSource = dataTable;
        }
        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FGiaoVien form = new FGiaoVien();
            form.Show();
        }
        private void btn_loc_Click(object sender, EventArgs e)
        {
            FLoc fLoc = new FLoc();
            fLoc.ShowDialog();
            string option = fLoc.Return_Option();
            UpdateDataGridView(DBConnection.DBLoad("HocSinh",option));

        }
        private void ucThongtin1_Load(object sender, EventArgs e)
        {

        }
    }
}
