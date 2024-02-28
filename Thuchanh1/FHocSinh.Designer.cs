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
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.btn_loc = new System.Windows.Forms.Button();
            this.ucThongtin1 = new Thuchanh1.UCThongtin();
            this.SuspendLayout();
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Location = new System.Drawing.Point(704, 386);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(111, 38);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "Giáo Viên";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(606, 356);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(81, 29);
            this.btn_loc.TabIndex = 67;
            this.btn_loc.Text = "Phân loại";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // ucThongtin1
            // 
            this.ucThongtin1.Location = new System.Drawing.Point(12, 1);
            this.ucThongtin1.Name = "ucThongtin1";
            this.ucThongtin1.Size = new System.Drawing.Size(803, 423);
            this.ucThongtin1.TabIndex = 68;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 433);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.btnGiangVien);
            this.Controls.Add(this.ucThongtin1);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocsinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.Button btn_loc;
        private UCThongtin ucThongtin1;
    }
}

