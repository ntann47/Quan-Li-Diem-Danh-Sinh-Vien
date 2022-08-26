
namespace DiemDanhSinhVien
{
    partial class fr_MonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_MonHoc));
            this.dGrVwMonHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongSoTiet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnMoi = new System.Windows.Forms.ToolStripButton();
            this.tSbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tSbtnLuu = new System.Windows.Forms.ToolStripButton();
            this.txtSoTietTH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTietLT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrVwMonHoc
            // 
            this.dGrVwMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwMonHoc.Location = new System.Drawing.Point(12, 188);
            this.dGrVwMonHoc.Name = "dGrVwMonHoc";
            this.dGrVwMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwMonHoc.Size = new System.Drawing.Size(649, 262);
            this.dGrVwMonHoc.TabIndex = 5;
            this.dGrVwMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrVwMonHoc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTietTH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoTietLT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTongSoTiet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học: ";
            // 
            // txtTongSoTiet
            // 
            this.txtTongSoTiet.Location = new System.Drawing.Point(75, 109);
            this.txtTongSoTiet.Name = "txtTongSoTiet";
            this.txtTongSoTiet.Size = new System.Drawing.Size(180, 20);
            this.txtTongSoTiet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số tiết";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(75, 65);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(180, 20);
            this.txtTenMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên MH:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(75, 26);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(180, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnMoi,
            this.tSbtnXoa,
            this.tSbtnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 3;
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
            // txtSoTietTH
            // 
            this.txtSoTietTH.Location = new System.Drawing.Point(443, 65);
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Size = new System.Drawing.Size(180, 20);
            this.txtSoTietTH.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số tiết TH:";
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.Location = new System.Drawing.Point(443, 26);
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Size = new System.Drawing.Size(180, 20);
            this.txtSoTietLT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số tiết LT:";
            // 
            // fr_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 444);
            this.Controls.Add(this.dGrVwMonHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fr_MonHoc";
            this.Text = "fr_MonHoc";
            this.Load += new System.EventHandler(this.fr_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrVwMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTietTH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTietLT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSoTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnMoi;
        private System.Windows.Forms.ToolStripButton tSbtnXoa;
        private System.Windows.Forms.ToolStripButton tSbtnLuu;
    }
}