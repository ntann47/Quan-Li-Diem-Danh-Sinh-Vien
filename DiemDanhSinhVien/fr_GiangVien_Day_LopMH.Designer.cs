
namespace DiemDanhSinhVien
{
    partial class fr_GiangVien_Day_LopMH
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
            this.cbDSMonHoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIDLopMH = new System.Windows.Forms.TextBox();
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLopMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGrVwMonHoc_LopMH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtHtenGv = new System.Windows.Forms.TextBox();
            this.btnTimSv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwMonHoc_LopMH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDSMonHoc
            // 
            this.cbDSMonHoc.FormattingEnabled = true;
            this.cbDSMonHoc.Location = new System.Drawing.Point(107, 251);
            this.cbDSMonHoc.Name = "cbDSMonHoc";
            this.cbDSMonHoc.Size = new System.Drawing.Size(178, 21);
            this.cbDSMonHoc.TabIndex = 56;
            this.cbDSMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbDSMonHoc_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Chọn Môn Học:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(350, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "MÔN HỌC - LỚP MÔN HỌC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIDLopMH);
            this.groupBox3.Controls.Add(this.txtMaGiangVien);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaMH);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMaLopMH);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 198);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp Môn Học:";
            // 
            // txtIDLopMH
            // 
            this.txtIDLopMH.Location = new System.Drawing.Point(95, 27);
            this.txtIDLopMH.Name = "txtIDLopMH";
            this.txtIDLopMH.Size = new System.Drawing.Size(180, 20);
            this.txtIDLopMH.TabIndex = 14;
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Location = new System.Drawing.Point(95, 153);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(180, 20);
            this.txtMaGiangVien.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 45;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã GV:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(95, 111);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(180, 20);
            this.txtMaMH.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IDLOPMH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã MH:";
            // 
            // txtMaLopMH
            // 
            this.txtMaLopMH.Location = new System.Drawing.Point(95, 66);
            this.txtMaLopMH.Name = "txtMaLopMH";
            this.txtMaLopMH.Size = new System.Drawing.Size(180, 20);
            this.txtMaLopMH.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Lớp MH:";
            // 
            // dGrVwMonHoc_LopMH
            // 
            this.dGrVwMonHoc_LopMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwMonHoc_LopMH.Location = new System.Drawing.Point(12, 282);
            this.dGrVwMonHoc_LopMH.Name = "dGrVwMonHoc_LopMH";
            this.dGrVwMonHoc_LopMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwMonHoc_LopMH.Size = new System.Drawing.Size(873, 296);
            this.dGrVwMonHoc_LopMH.TabIndex = 52;
            this.dGrVwMonHoc_LopMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwMonHoc_LopMH_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKhoa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDangKy);
            this.groupBox2.Controls.Add(this.txtHtenGv);
            this.groupBox2.Controls.Add(this.btnTimSv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaGv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 198);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảng Viên:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(99, 107);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(200, 20);
            this.txtKhoa.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Khoa:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(164, 143);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(89, 26);
            this.btnDangKy.TabIndex = 47;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtHtenGv
            // 
            this.txtHtenGv.Location = new System.Drawing.Point(99, 69);
            this.txtHtenGv.Name = "txtHtenGv";
            this.txtHtenGv.Size = new System.Drawing.Size(200, 20);
            this.txtHtenGv.TabIndex = 27;
            // 
            // btnTimSv
            // 
            this.btnTimSv.Location = new System.Drawing.Point(316, 27);
            this.btnTimSv.Name = "btnTimSv";
            this.btnTimSv.Size = new System.Drawing.Size(75, 26);
            this.btnTimSv.TabIndex = 46;
            this.btnTimSv.Text = "Tìm";
            this.btnTimSv.UseVisualStyleBackColor = true;
            this.btnTimSv.Click += new System.EventHandler(this.btnTimSv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã GV:";
            // 
            // txtMaGv
            // 
            this.txtMaGv.Location = new System.Drawing.Point(99, 30);
            this.txtMaGv.Name = "txtMaGv";
            this.txtMaGv.Size = new System.Drawing.Size(200, 20);
            this.txtMaGv.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Họ Tên GV:";
            // 
            // fr_GiangVien_Day_LopMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbDSMonHoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dGrVwMonHoc_LopMH);
            this.Name = "fr_GiangVien_Day_LopMH";
            this.Text = "GiangVien_Day_LopMonHoc";
            this.Load += new System.EventHandler(this.GiangVien_Day_LopMH_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwMonHoc_LopMH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDSMonHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIDLopMH;
        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLopMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGrVwMonHoc_LopMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtHtenGv;
        private System.Windows.Forms.Button btnTimSv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGv;
        private System.Windows.Forms.Label label6;
    }
}