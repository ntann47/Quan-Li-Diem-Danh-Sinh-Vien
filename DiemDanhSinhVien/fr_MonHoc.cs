using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DiemDanhSinhVien
{
    public partial class fr_MonHoc : Form
    {
        public fr_MonHoc()
        {
            InitializeComponent();
            dGrVwMonHoc.AllowUserToAddRows = false;
            dGrVwMonHoc.ReadOnly = true;
        }

        private void fr_MonHoc_Load(object sender, EventArgs e)
        {
            dGrVwMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
            tSbtnLuu.Enabled = tSbtnXoa.Enabled = txtMaMH.Enabled = txtTenMH.Enabled = txtTongSoTiet.Enabled = txtSoTietLT.Enabled = txtSoTietTH.Enabled = false;
        }

        private void tSbtnMoi_Click(object sender, EventArgs e)
        {
            tSbtnXoa.Enabled = tSbtnMoi.Enabled = false;
            tSbtnLuu.Enabled = txtMaMH.Enabled = txtTenMH.Enabled = txtTongSoTiet.Enabled = txtSoTietLT.Enabled = txtSoTietTH.Enabled = true;
            Clear();
            txtMaMH.Focus();
        }

        private void tSbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                MonHoc x = new MonHoc(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), Int32.Parse(txtTongSoTiet.Text.Trim()), Int32.Parse(txtSoTietLT.Text.Trim()), Int32.Parse(txtSoTietTH.Text.Trim()));
                if (MonHoc_LopMonHocBUS.Instance.KiemTraKhoaNgoai_MonHoc(x) == 1)
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (MonHocBUS.Instance.Delete_MonHoc(x) != -1)
                    {
                        dGrVwMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
                        Clear();
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Clear()
        {
            txtMaMH.Text = txtTenMH.Text = txtTongSoTiet.Text = txtSoTietLT.Text = txtSoTietTH.Text = "";
        }

        private void tSbtnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Equals("") || txtTenMH.Text.Equals(""))
            {
                MessageBox.Show("Dữ liệu chưa đủ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MonHoc x = new MonHoc(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), Int32.Parse(txtTongSoTiet.Text.Trim()), Int32.Parse(txtSoTietLT.Text.Trim()), Int32.Parse(txtSoTietTH.Text.Trim()));
                if (tSbtnMoi.Enabled == false)
                {

                    if (MonHocBUS.Instance.timMonHoc(x.Mamh)!=null)
                    {

                        MessageBox.Show("Mã môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                    else
                    {
                        if (MonHocBUS.Instance.Insert_MonHoc(x) == 1)
                        {
                            dGrVwMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
                            Clear();
                            MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }    

                }
                else
                {
                    if (MonHocBUS.Instance.Update_MonHoc(x) != -1)
                    {
                        dGrVwMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
                        Clear();
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
            }
        }

        private void dGrVwMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenMH.Enabled = txtTongSoTiet.Enabled = txtSoTietLT.Enabled = txtSoTietTH.Enabled = true;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwMonHoc.Rows[e.RowIndex];
                txtMaMH.Text = dgvRow.Cells[0].Value.ToString();
                txtTenMH.Text = dgvRow.Cells[1].Value.ToString();
                txtTongSoTiet.Text = dgvRow.Cells[2].Value.ToString();
                txtSoTietLT.Text = dgvRow.Cells[3].Value.ToString();
                txtSoTietTH.Text = dgvRow.Cells[4].Value.ToString();
                txtMaMH.ReadOnly = tSbtnXoa.Enabled = tSbtnMoi.Enabled = tSbtnLuu.Enabled = true;
            }
        }
    }
}
