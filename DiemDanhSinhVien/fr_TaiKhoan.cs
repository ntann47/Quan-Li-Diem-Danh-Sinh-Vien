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
    public partial class fr_TaiKhoan : Form
    {
        public fr_TaiKhoan()
        {
            InitializeComponent();
            dGrVwTaiKhoan.AllowUserToAddRows = false;
            dGrVwTaiKhoan.ReadOnly = true;
        }

        private void fr_TaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenTK.Enabled = txTenND.Enabled = txtMK.Enabled = cbMaPQ.Enabled = false;
            tSbtnXoa.Enabled = tSbtnLuu.Enabled = false;
            dGrVwTaiKhoan.DataSource = TaiKhoanBUS.Instance.Load_DS_TaiKhoan();
            cbMaPQ.DataSource = TaiKhoanBUS.Instance.Load_QuyenTruyCap();
            cbMaPQ.DisplayMember = "MAPHANQUYEN";
            cbMaPQ.ValueMember = "MAPHANQUYEN";
        }

        private void tSbtnMoi_Click(object sender, EventArgs e)
        {
            txtTenTK.ReadOnly = false;
            txtTenTK.Enabled = txTenND.Enabled = txtMK.Enabled = cbMaPQ.Enabled = true;
            txtTenTK.Clear();
            txTenND.Clear();
            txtMK.Clear();
            tSbtnMoi.Enabled = false;
            tSbtnLuu.Enabled = true;
            cbMaPQ.SelectedItem = null;
        }
        

        private void dGrVwTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTK.ReadOnly = true;
            txtTenTK.Enabled = txTenND.Enabled = txtMK.Enabled = cbMaPQ.Enabled = true;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwTaiKhoan.Rows[e.RowIndex];
                txtTenTK.Text = dgvRow.Cells[0].Value.ToString();
                txTenND.Text = dgvRow.Cells[1].Value.ToString();
                txtMK.Text = dgvRow.Cells[2].Value.ToString();
                cbMaPQ.SelectedValue = dgvRow.Cells[3].Value.ToString();
                tSbtnXoa.Enabled = tSbtnMoi.Enabled = tSbtnLuu.Enabled = true;
                
            }
        }

        private void tSbtnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Equals("")||txTenND.Text.Equals("")||txtMK.Text.Equals(""))
            {
                MessageBox.Show("Dữ liệu chưa đủ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
           else
            {
                TaiKhoan x = new TaiKhoan(txtTenTK.Text.Trim(), txTenND.Text.Trim(), txtMK.Text.Trim(), cbMaPQ.SelectedValue.ToString());
                if (tSbtnMoi.Enabled == false)
                {
    
                    if (TaiKhoanBUS.Instance.KiemTraTenTaiKhoan(x.Tentaikhoan) == 1)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (TaiKhoanBUS.Instance.KiemTraTenNguoiDung(x.Tennguoidung) == 1)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (TaiKhoanBUS.Instance.Insert_TaiKhoan(x) == 1)
                        {
                            MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dGrVwTaiKhoan.DataSource = TaiKhoanBUS.Instance.Load_DS_TaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (TaiKhoanBUS.Instance.Update_TaiKhoan(x) != -1)
                    {
                        MessageBox.Show("Cập nhật hành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGrVwTaiKhoan.DataSource = TaiKhoanBUS.Instance.Load_DS_TaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
            }    
        }

        private void tSbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                TaiKhoan x = new TaiKhoan(txtTenTK.Text.Trim(), txTenND.Text.Trim(), txtMK.Text.Trim(), cbMaPQ.SelectedValue.ToString());
                if (TaiKhoanBUS.Instance.KiemTraKhoaNgoai_GiangVien(x) != 0)
                {
                    MessageBox.Show("Tài Khoản đang được sử dụng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (TaiKhoanBUS.Instance.Delete_TaiKhoan(x) != -1)
                    {
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGrVwTaiKhoan.DataSource = TaiKhoanBUS.Instance.Load_DS_TaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
 
    }
}
