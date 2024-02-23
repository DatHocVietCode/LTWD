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
            this.btnGiangVien.Location = new System.Drawing.Point(649, 397);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(101, 23);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "GiangVien";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(503, 397);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 67;
            this.btn_loc.Text = "Loc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // ucThongtin1
            // 
            this.ucThongtin1.Location = new System.Drawing.Point(13, 12);
            this.ucThongtin1.Name = "ucThongtin1";
            this.ucThongtin1.Size = new System.Drawing.Size(803, 423);
            this.ucThongtin1.TabIndex = 68;
            this.ucThongtin1.Load += new System.EventHandler(this.ucThongtin1_Load);
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
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

