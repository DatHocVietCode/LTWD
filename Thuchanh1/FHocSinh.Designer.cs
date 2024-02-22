namespace Thuchanh1
{
    partial class FHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.txtIdentifyNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblIdentifyNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_loc = new System.Windows.Forms.Button();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.lbl_diem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv1
            // 
            this.gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv1.Location = new System.Drawing.Point(435, 98);
            this.gv1.Name = "gv1";
            this.gv1.RowHeadersWidth = 51;
            this.gv1.RowTemplate.Height = 24;
            this.gv1.Size = new System.Drawing.Size(353, 242);
            this.gv1.TabIndex = 8;
            this.gv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(211, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(370, 397);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sua";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Location = new System.Drawing.Point(671, 397);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(101, 23);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "GiangVien";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(201, 150);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(100, 22);
            this.txt_gioitinh.TabIndex = 48;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(59, 156);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(54, 16);
            this.lbl_sex.TabIndex = 47;
            this.lbl_sex.Text = "Gioi tinh";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(201, 307);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_phone.TabIndex = 46;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(201, 267);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 45;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(201, 30);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 44;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(59, 310);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(46, 16);
            this.lbl_Phone.TabIndex = 43;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(59, 270);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 42;
            this.lbl_email.Text = "Email";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(59, 30);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 16);
            this.lbl_ID.TabIndex = 41;
            this.lbl_ID.Text = "ID";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(183, 188);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(200, 22);
            this.dtpDoB.TabIndex = 40;
            // 
            // txtIdentifyNum
            // 
            this.txtIdentifyNum.Location = new System.Drawing.Point(201, 68);
            this.txtIdentifyNum.Name = "txtIdentifyNum";
            this.txtIdentifyNum.Size = new System.Drawing.Size(100, 22);
            this.txtIdentifyNum.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(201, 225);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 38;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(201, 106);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 37;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(31, 193);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(132, 16);
            this.lblDoB.TabIndex = 36;
            this.lblDoB.Text = "Ngay thang nam sinh";
            // 
            // lblIdentifyNum
            // 
            this.lblIdentifyNum.AutoSize = true;
            this.lblIdentifyNum.Location = new System.Drawing.Point(59, 74);
            this.lblIdentifyNum.Name = "lblIdentifyNum";
            this.lblIdentifyNum.Size = new System.Drawing.Size(47, 16);
            this.lblIdentifyNum.TabIndex = 35;
            this.lblIdentifyNum.Text = "CMND";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(59, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 16);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Dia chi";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 16);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Ho va Ten";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(713, 29);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(75, 23);
            this.btn_reload.TabIndex = 66;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(517, 397);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 67;
            this.btn_loc.Text = "Loc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(201, 351);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(100, 22);
            this.txt_diem.TabIndex = 69;
            // 
            // lbl_diem
            // 
            this.lbl_diem.AutoSize = true;
            this.lbl_diem.Location = new System.Drawing.Point(59, 354);
            this.lbl_diem.Name = "lbl_diem";
            this.lbl_diem.Size = new System.Drawing.Size(39, 16);
            this.lbl_diem.TabIndex = 68;
            this.lbl_diem.Text = "Diem";
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_diem);
            this.Controls.Add(this.lbl_diem);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.txtIdentifyNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblIdentifyNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGiangVien);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gv1);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocsinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gv1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox txtIdentifyNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblIdentifyNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label lbl_diem;
    }
}

