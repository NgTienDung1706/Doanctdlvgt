namespace Abcd
{
    partial class FormNhapThongTinHoaQua
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
            this.Ten = new System.Windows.Forms.TextBox();
            this.Loai = new System.Windows.Forms.TextBox();
            this.Gia = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.HanSuDung = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(142, 61);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(100, 22);
            this.Ten.TabIndex = 0;
            // 
            // Loai
            // 
            this.Loai.Location = new System.Drawing.Point(391, 60);
            this.Loai.Name = "Loai";
            this.Loai.Size = new System.Drawing.Size(100, 22);
            this.Loai.TabIndex = 1;
            // 
            // Gia
            // 
            this.Gia.Location = new System.Drawing.Point(624, 60);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(100, 22);
            this.Gia.TabIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(250, 181);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(100, 22);
            this.SoLuong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "HSD";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(356, 277);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(115, 23);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // HanSuDung
            // 
            this.HanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HanSuDung.Location = new System.Drawing.Point(487, 180);
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Size = new System.Drawing.Size(115, 22);
            this.HanSuDung.TabIndex = 11;
            // 
            // FormNhapThongTinHoaQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 397);
            this.Controls.Add(this.HanSuDung);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.Loai);
            this.Controls.Add(this.Ten);
            this.Name = "FormNhapThongTinHoaQua";
            this.Text = "Thêm mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.TextBox Loai;
        private System.Windows.Forms.TextBox Gia;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DateTimePicker HanSuDung;
    }
}