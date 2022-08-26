using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;

namespace DiemDanhSinhVien
{
    public partial class fr_ThongTinTaiKhoan : Form
    {

        private TaiKhoan taikhoandangdangnhap;

        public TaiKhoan Taikhoandangdangnhap { get => taikhoandangdangnhap; set => taikhoandangdangnhap = value; }
        public fr_ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void fr_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            taikhoandangdangnhap = fr_DangNhap.Taikhoandangdangnhap;
            TaiKhoan tk_giangVien = TaiKhoanBUS.Instance.LayThongTinTaiKhoan_GV(taikhoandangdangnhap.Tentaikhoan);
            txtTenTK.ReadOnly = txtTenNgDung.ReadOnly = txtMaPQ.ReadOnly = true;
            txtTenTK.Text = tk_giangVien.Tentaikhoan.Trim();
            txtTenNgDung.Text = tk_giangVien.Tennguoidung.Trim();
            txtMaPQ.Text = tk_giangVien.Maphanquyen.Trim();

        }
    }
}
