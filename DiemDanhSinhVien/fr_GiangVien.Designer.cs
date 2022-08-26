
namespace DiemDanhSinhVien
{
    partial class fr_GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_GiangVien));
            this.tSbtnMoi = new System.Windows.Forms.ToolStripButton();
            this.tSbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnLuu = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnNu = new System.Windows.Forms.RadioButton();
            this.rBtnNam = new System.Windows.Forms.RadioButton();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimGV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHtenGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dGrVwGiangVien = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tSbtnMoi
            // 
            this.tSbtnMoi.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnMoi.Image")));
            this.tSbtnMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnMoi.Name = "tSbtnMoi";
            this.tSbtnMoi.Size = new System.Drawing.Size(48, 22);
            this.tSbtnMoi.Text = "Mới";
            this.tSbtnMoi.Click += new System.EventHandler(this.tSbtnMoi_Click);
            // 
            // tSbtnXoa
            // 
            this.tSbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnXoa.Image")));
            this.tSbtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnXoa.Name = "tSbtnXoa";
            this.tSbtnXoa.Size = new System.Drawing.Size(47, 22);
            this.tSbtnXoa.Text = "Xóa";
            this.tSbtnXoa.Click += new System.EventHandler(this.tSbtnXoa_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnMoi,
            this.tSbtnXoa,
            this.tSbtnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtnLuu
            // 
            this.tSbtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnLuu.Image")));
            this.tSbtnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnLuu.Name = "tSbtnLuu";
            this.tSbtnLuu.Size = new System.Drawing.Size(47, 22);
            this.tSbtnLuu.Text = "Lưu";
            this.tSbtnLuu.Click += new System.EventHandler(this.tSbtnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnNu);
            this.groupBox1.Controls.Add(this.rBtnNam);
            this.groupBox1.Controls.Add(this.dtpNgSinh);
            this.groupBox1.Controls.Add(this.cbMaKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTimGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHtenGV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giảng Viên: ";
            // 
            // rBtnNu
            // 
            this.rBtnNu.AutoSize = true;
            this.rBtnNu.Location = new System.Drawing.Point(145, 104);
            this.rBtnNu.Name = "rBtnNu";
            this.rBtnNu.Size = new System.Drawing.Size(39, 17);
            this.rBtnNu.TabIndex = 15;
            this.rBtnNu.TabStop = true;
            this.rBtnNu.Text = "Nữ";
            this.rBtnNu.UseVisualStyleBackColor = true;
            // 
            // rBtnNam
            // 
            this.rBtnNam.AutoSize = true;
            this.rBtnNam.Location = new System.Drawing.Point(75, 105);
            this.rBtnNam.Name = "rBtnNam";
            this.rBtnNam.Size = new System.Drawing.Size(47, 17);
            this.rBtnNam.TabIndex = 14;
            this.rBtnNam.TabStop = true;
            this.rBtnNam.Text = "Nam";
            this.rBtnNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Location = new System.Drawing.Point(431, 26);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgSinh.TabIndex = 13;
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(431, 104);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(137, 21);
            this.cbMaKhoa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Khoa:";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(431, 65);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(137, 20);
            this.txtTrinhDo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trình Độ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Sinh:";
            // 
            // btnTimGV
            // 
            this.btnTimGV.Location = new System.Drawing.Point(261, 24);
            this.btnTimGV.Name = "btnTimGV";
            this.btnTimGV.Size = new System.Drawing.Size(75, 23);
            this.btnTimGV.TabIndex = 6;
            this.btnTimGV.Text = "Tìm Kiếm";
            this.btnTimGV.UseVisualStyleBackColor = true;
            this.btnTimGV.Click += new System.EventHandler(this.btnTimGV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính:";
            // 
            // txtHtenGV
            // 
            this.txtHtenGV.Location = new System.Drawing.Point(75, 65);
            this.txtHtenGV.Name = "txtHtenGV";
            this.txtHtenGV.Size = new System.Drawing.Size(180, 20);
            this.txtHtenGV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(75, 26);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(180, 20);
            this.txtMaGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV:";
            // 
            // dGrVwGiangVien
            // 
            this.dGrVwGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwGiangVien.Location = new System.Drawing.Point(12, 183);
            this.dGrVwGiangVien.Name = "dGrVwGiangVien";
            this.dGrVwGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwGiangVien.Size = new System.Drawing.Size(649, 262);
            this.dGrVwGiangVien.TabIndex = 2;
            this.dGrVwGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwGiangVien_CellClick);
            // 
            // fr_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 453);
            this.Controls.Add(this.dGrVwGiangVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fr_GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Giảng Viên";
            this.Load += new System.EventHandler(this.fr_GiangVien_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tSbtnMoi;
        private System.Windows.Forms.ToolStripButton tSbtnXoa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGrVwGiangVien;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHtenGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnNu;
        private System.Windows.Forms.RadioButton rBtnNam;
    }
}