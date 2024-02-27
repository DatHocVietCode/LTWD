namespace Thuchanh1
{
    partial class FLoc
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
            this.rb1_8 = new System.Windows.Forms.RadioButton();
            this.rb2_8_5 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.rb4_koloc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb1_8
            // 
            this.rb1_8.AutoSize = true;
            this.rb1_8.Location = new System.Drawing.Point(147, 59);
            this.rb1_8.Name = "rb1_8";
            this.rb1_8.Size = new System.Drawing.Size(125, 20);
            this.rb1_8.TabIndex = 0;
            this.rb1_8.TabStop = true;
            this.rb1_8.Text = " Diem >= 8 (Giỏi)";
            this.rb1_8.UseVisualStyleBackColor = true;
            // 
            // rb2_8_5
            // 
            this.rb2_8_5.AutoSize = true;
            this.rb2_8_5.Location = new System.Drawing.Point(147, 111);
            this.rb2_8_5.Name = "rb2_8_5";
            this.rb2_8_5.Size = new System.Drawing.Size(141, 20);
            this.rb2_8_5.TabIndex = 1;
            this.rb2_8_5.TabStop = true;
            this.rb2_8_5.Text = " 5 <= Diem <8 (Khá)";
            this.rb2_8_5.UseVisualStyleBackColor = true;
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(147, 163);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(118, 20);
            this.rb_5.TabIndex = 2;
            this.rb_5.TabStop = true;
            this.rb_5.Text = " Diem < 5 (Yếu)";
            this.rb_5.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(116, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(164, 16);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Chon thang diem muon loc";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(299, 237);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(82, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // rb4_koloc
            // 
            this.rb4_koloc.AutoSize = true;
            this.rb4_koloc.Location = new System.Drawing.Point(147, 206);
            this.rb4_koloc.Name = "rb4_koloc";
            this.rb4_koloc.Size = new System.Drawing.Size(165, 20);
            this.rb4_koloc.TabIndex = 5;
            this.rb4_koloc.TabStop = true;
            this.rb4_koloc.Text = "Khong loc (Giữ nguyên)";
            this.rb4_koloc.UseVisualStyleBackColor = true;
            // 
            // FLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 272);
            this.Controls.Add(this.rb4_koloc);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.rb_5);
            this.Controls.Add(this.rb2_8_5);
            this.Controls.Add(this.rb1_8);
            this.Name = "FLoc";
            this.Text = "FLoc";
            this.Load += new System.EventHandler(this.FLoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1_8;
        private System.Windows.Forms.RadioButton rb2_8_5;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.RadioButton rb4_koloc;
    }
}