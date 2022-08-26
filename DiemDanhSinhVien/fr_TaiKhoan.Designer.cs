
namespace DiemDanhSinhVien
{
    partial class fr_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_TaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaPQ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTenND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dGrVwTaiKhoan = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnMoi = new System.Windows.Forms.ToolStripButton();
            this.tSbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tSbtnLuu = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwTaiKhoan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaPQ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txTenND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 170);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản:";
            // 
            // cbMaPQ
            // 
            this.cbMaPQ.FormattingEnabled = true;
            this.cbMaPQ.Items.AddRange(new object[] {
            ""});
            this.cbMaPQ.Location = new System.Drawing.Point(453, 88);
            this.cbMaPQ.Name = "cbMaPQ";
            this.cbMaPQ.Size = new System.Drawing.Size(121, 21);
            this.cbMaPQ.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(122, 46);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(180, 20);
            this.txtTenTK.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Người Dùng:";
            // 
            // txTenND
            // 
            this.txTenND.Location = new System.Drawing.Point(122, 82);
            this.txTenND.Name = "txTenND";
            this.txTenND.Size = new System.Drawing.Size(180, 20);
            this.txTenND.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã Phân Quyền:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(453, 46);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(200, 20);
            this.txtMK.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mật Khẩu:";
            // 
            // dGrVwTaiKhoan
            // 
            this.dGrVwTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwTaiKhoan.Location = new System.Drawing.Point(12, 253);
            this.dGrVwTaiKhoan.Name = "dGrVwTaiKhoan";
            this.dGrVwTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwTaiKhoan.Size = new System.Drawing.Size(676, 234);
            this.dGrVwTaiKhoan.TabIndex = 34;
            this.dGrVwTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwTaiKhoan_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnMoi,
            this.tSbtnXoa,
            this.tSbtnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 35;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(224, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // fr_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dGrVwTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Name = "fr_TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_TaiKhoan";
            this.Load += new System.EventHandler(this.fr_TaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwTaiKhoan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTenND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGrVwTaiKhoan;
        private System.Windows.Forms.ComboBox cbMaPQ;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnMoi;
        private System.Windows.Forms.ToolStripButton tSbtnXoa;
        private System.Windows.Forms.ToolStripButton tSbtnLuu;
        private System.Windows.Forms.Label label3;
    }
}