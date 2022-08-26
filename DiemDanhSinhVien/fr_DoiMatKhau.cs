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
using DAO;
using DTO;

namespace DiemDanhSinhVien
{
    public partial class fr_DoiMatKhau : Form
    {
        private TaiKhoan taikhoandangdangnhap = fr_DangNhap.Taikhoandangdangnhap;

        public fr_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void chkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxHienMK.Checked)
            {
                txtMKCu.UseSystemPasswordChar = txtMKMoi.UseSystemPasswordChar = txtNhapLaiMKMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKCu.UseSystemPasswordChar = txtMKMoi.UseSystemPasswordChar = txtNhapLaiMKMoi.UseSystemPasswordChar = true;
            }
        }

        private void fr_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = txtMKMoi.UseSystemPasswordChar = txtNhapLaiMKMoi.UseSystemPasswordChar = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Equals("") || txtMKMoi.Text.Equals("") || txtNhapLaiMKMoi.Text.Equals(""))
            {

            }
            else
            {
               
                if (txtMKCu.Text.Trim().Equals(taikhoandangdangnhap.Matkhau) == false)
                {
                    MessageBox.Show("Mật Khẩu cũ không khớp. Vui lòng kiểm tra lại!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                ///Kết nối với tài khoản bên SQL database
                {
                    if (txtMKMoi.Text.Trim().Equals(txtNhapLaiMKMoi.Text.Trim()) == false)
                    {
                        MessageBox.Show("Mật Khẩu xác nhận không khớp. Vui lòng kiểm tra lại!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        TaiKhoan taiKhoan_update = new TaiKhoan(taikhoandangdangnhap.Tentaikhoan, taikhoandangdangnhap.Tennguoidung, txtNhapLaiMKMoi.Text.Trim(), taikhoandangdangnhap.Maphanquyen);
                        if (TaiKhoanBUS.Instance.Update_TaiKhoan(taiKhoan_update) != -1)
                        {
                            MessageBox.Show("Cập nhật hành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
