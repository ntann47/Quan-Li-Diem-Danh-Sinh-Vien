
namespace DiemDanhSinhVien
{
    partial class fr_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_SinhVien));
            this.dGrVwSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimGV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnMoi = new System.Windows.Forms.ToolStripButton();
            this.tSbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tSbtnLuu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrVwSinhVien
            // 
            this.dGrVwSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwSinhVien.Location = new System.Drawing.Point(2, 205);
            this.dGrVwSinhVien.Name = "dGrVwSinhVien";
            this.dGrVwSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwSinhVien.Size = new System.Drawing.Size(796, 243);
            this.dGrVwSinhVien.TabIndex = 3;
            this.dGrVwSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwSinhVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.dtpNgSinh);
            this.groupBox1.Controls.Add(this.cbMaLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTimGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTenSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên: ";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DisplayMember = "Nam,Nữ";
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(75, 104);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Location = new System.Drawing.Point(431, 26);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgSinh.TabIndex = 13;
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(431, 65);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(137, 21);
            this.cbMaLop.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lớp:";
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
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(75, 65);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(180, 20);
            this.txtHoTenSV.TabIndex = 3;
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
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(75, 26);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnMoi,
            this.tSbtnXoa,
            this.tSbtnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            // tSbtnLuu
            // 
            this.tSbtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnLuu.Image")));
            this.tSbtnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnLuu.Name = "tSbtnLuu";
            this.tSbtnLuu.Size = new System.Drawing.Size(47, 22);
            this.tSbtnLuu.Text = "Lưu";
            this.tSbtnLuu.Click += new System.EventHandler(this.tSbtnLuu_Click);
            // 
            // fr_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGrVwSinhVien);
            this.Name = "fr_SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Sinh Viên";
            this.Load += new System.EventHandler(this.fr_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrVwSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnMoi;
        private System.Windows.Forms.ToolStripButton tSbtnXoa;
        private System.Windows.Forms.ToolStripButton tSbtnLuu;
    }
}