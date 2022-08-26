using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace DiemDanhSinhVien
{
    public partial class fr_DangNhap : Form
    {
        private static TaiKhoan taikhoandangdangnhap;

        public static TaiKhoan Taikhoandangdangnhap { get => taikhoandangdangnhap; set => taikhoandangdangnhap = value; }

        public fr_DangNhap()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void chkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxHienMK.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if(chkBoxHienMK.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }    
            else
                txtPass.UseSystemPasswordChar = true;*/
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendn = txtTenTK.Text;
            string pass = txtPass.Text;
            if (tendn.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (TaiKhoanDAO.Instance.KiemTraTaiKhoan(tendn, pass) != null)
                    {
                        TaiKhoan tk = TaiKhoanDAO.Instance.KiemTraTaiKhoan(tendn, pass);
                        Taikhoandangdangnhap = tk;
                        string tennguoidung = Taikhoandangdangnhap.Tennguoidung;
                        MessageBox.Show("Xin chào " + tennguoidung, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fr_Main fr = new fr_Main();
                        fr.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPass.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void fr_DangNhap_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = "1971016001";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
