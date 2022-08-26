
namespace DiemDanhSinhVien
{
    partial class fr_DiemDanhSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DiemDanhSinhVien));
            this.dGrVwLopDangDay = new System.Windows.Forms.DataGridView();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnTongKetDD = new System.Windows.Forms.Button();
            this.dateTimePickerNgayDD = new System.Windows.Forms.DateTimePicker();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.btnXemLSDD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDLopMH = new System.Windows.Forms.TextBox();
            this.txtMaPDD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwLopDangDay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrVwLopDangDay
            // 
            this.dGrVwLopDangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwLopDangDay.Location = new System.Drawing.Point(6, 19);
            this.dGrVwLopDangDay.Name = "dGrVwLopDangDay";
            this.dGrVwLopDangDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwLopDangDay.Size = new System.Drawing.Size(903, 281);
            this.dGrVwLopDangDay.TabIndex = 1;
            this.dGrVwLopDangDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwLopDangDay_CellClick);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(645, 19);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(146, 21);
            this.cbMonHoc.TabIndex = 2;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Môn Học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGrVwLopDangDay);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lớp Môn Học:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(369, 19);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(137, 20);
            this.txtTenGV.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(138, 19);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(133, 20);
            this.txtMaGV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã GV:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnKetThuc);
            this.groupBox2.Controls.Add(this.btnTongKetDD);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayDD);
            this.groupBox2.Controls.Add(this.btnDiemDanh);
            this.groupBox2.Controls.Add(this.btnXemLSDD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIDLopMH);
            this.groupBox2.Controls.Add(this.txtMaPDD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Điểm Danh:";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.Red;
            this.btnKetThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.Image")));
            this.btnKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetThuc.Location = new System.Drawing.Point(750, 85);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(144, 34);
            this.btnKetThuc.TabIndex = 28;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click_1);
            // 
            // btnTongKetDD
            // 
            this.btnTongKetDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongKetDD.ForeColor = System.Drawing.Color.Blue;
            this.btnTongKetDD.Location = new System.Drawing.Point(570, 82);
            this.btnTongKetDD.Name = "btnTongKetDD";
            this.btnTongKetDD.Size = new System.Drawing.Size(136, 34);
            this.btnTongKetDD.TabIndex = 27;
            this.btnTongKetDD.Text = "Tổng Kết Điểm Danh";
            this.btnTongKetDD.UseVisualStyleBackColor = true;
            this.btnTongKetDD.Click += new System.EventHandler(this.btnTongKetDD_Click);
            // 
            // dateTimePickerNgayDD
            // 
            this.dateTimePickerNgayDD.Location = new System.Drawing.Point(118, 82);
            this.dateTimePickerNgayDD.Name = "dateTimePickerNgayDD";
            this.dateTimePickerNgayDD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayDD.TabIndex = 22;
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.ForeColor = System.Drawing.Color.Blue;
            this.btnDiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemDanh.Image")));
            this.btnDiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.Location = new System.Drawing.Point(750, 24);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(144, 34);
            this.btnDiemDanh.TabIndex = 21;
            this.btnDiemDanh.Text = "Điểm Danh";
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // btnXemLSDD
            // 
            this.btnXemLSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLSDD.ForeColor = System.Drawing.Color.Blue;
            this.btnXemLSDD.Location = new System.Drawing.Point(570, 24);
            this.btnXemLSDD.Name = "btnXemLSDD";
            this.btnXemLSDD.Size = new System.Drawing.Size(136, 34);
            this.btnXemLSDD.TabIndex = 20;
            this.btnXemLSDD.Text = "Lịch Sử Điểm Danh";
            this.btnXemLSDD.UseVisualStyleBackColor = true;
            this.btnXemLSDD.Click += new System.EventHandler(this.btnXemLSDD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày Điểm Danh:";
            // 
            // txtIDLopMH
            // 
            this.txtIDLopMH.Location = new System.Drawing.Point(396, 32);
            this.txtIDLopMH.Name = "txtIDLopMH";
            this.txtIDLopMH.Size = new System.Drawing.Size(137, 20);
            this.txtIDLopMH.TabIndex = 11;
            // 
            // txtMaPDD
            // 
            this.txtMaPDD.Location = new System.Drawing.Point(118, 32);
            this.txtMaPDD.Name = "txtMaPDD";
            this.txtMaPDD.Size = new System.Drawing.Size(200, 20);
            this.txtMaPDD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IDLOPMH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã PĐD:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenGV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaGV);
            this.groupBox3.Controls.Add(this.cbMonHoc);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 53);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giảng Viên:";
            // 
            // fr_DiemDanhSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fr_DiemDanhSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiemDanhSinhVien";
            this.Load += new System.EventHandler(this.fr_DiemDanhSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwLopDangDay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrVwLopDangDay;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDLopMH;
        private System.Windows.Forms.TextBox txtMaPDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXemLSDD;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDD;
        private System.Windows.Forms.Button btnTongKetDD;
        private System.Windows.Forms.Button btnKetThuc;
    }
}