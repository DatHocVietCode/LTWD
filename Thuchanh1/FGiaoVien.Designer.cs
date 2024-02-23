namespace Thuchanh1
{
    partial class FGiaoVien
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
            this.ucThongtin1 = new Thuchanh1.UCThongtin();
            this.SuspendLayout();
            // 
            // ucThongtin1
            // 
            this.ucThongtin1.Location = new System.Drawing.Point(1, 15);
            this.ucThongtin1.Name = "ucThongtin1";
            this.ucThongtin1.Size = new System.Drawing.Size(803, 423);
            this.ucThongtin1.TabIndex = 0;
            this.ucThongtin1.Load += new System.EventHandler(this.ucThongtin1_Load);
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucThongtin1);
            this.Name = "FGiaoVien";
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongtin ucThongtin1;
    }
}