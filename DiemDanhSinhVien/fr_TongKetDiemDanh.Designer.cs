
namespace DiemDanhSinhVien
{
    partial class fr_TongKetDiemDanh
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
            this.dGrVwDSSVVang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLopMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtIDLopMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwDSSVVang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrVwDSSVVang
            // 
            this.dGrVwDSSVVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrVwDSSVVang.Location = new System.Drawing.Point(12, 226);
            this.dGrVwDSSVVang.Name = "dGrVwDSSVVang";
            this.dGrVwDSSVVang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrVwDSSVVang.Size = new System.Drawing.Size(664, 338);
            this.dGrVwDSSVVang.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(210, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "DANH SÁCH SINH VIÊN VẮNG";
            // 
            // txtMaLopMH
            // 
            this.txtMaLopMH.Location = new System.Drawing.Point(542, 45);
            this.txtMaLopMH.Name = "txtMaLopMH";
            this.txtMaLopMH.Size = new System.Drawing.Size(112, 20);
            this.txtMaLopMH.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã Lớp - MH:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(295, 45);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(137, 20);
            this.txtMaMH.TabIndex = 21;
            // 
            // txtIDLopMH
            // 
            this.txtIDLopMH.Location = new System.Drawing.Point(76, 45);
            this.txtIDLopMH.Name = "txtIDLopMH";
            this.txtIDLopMH.Size = new System.Drawing.Size(133, 20);
            this.txtIDLopMH.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "IDLOP - MH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã  MH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(239, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "TỔNG KẾT ĐIỂM DANH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaLopMH);
            this.groupBox1.Controls.Add(this.txtIDLopMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnXemIn
            // 
            this.btnXemIn.Location = new System.Drawing.Point(601, 181);
            this.btnXemIn.Name = "btnXemIn";
            this.btnXemIn.Size = new System.Drawing.Size(75, 23);
            this.btnXemIn.TabIndex = 28;
            this.btnXemIn.Text = "Xem In";
            this.btnXemIn.UseVisualStyleBackColor = true;
            this.btnXemIn.Click += new System.EventHandler(this.btnXemIn_Click);
            // 
            // fr_TongKetDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 583);
            this.Controls.Add(this.btnXemIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGrVwDSSVVang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "fr_TongKetDiemDanh";
            this.Text = "fr_TongKetDiemDanh";
            this.Load += new System.EventHandler(this.fr_TongKetDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrVwDSSVVang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrVwDSSVVang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLopMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtIDLopMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemIn;
    }
}