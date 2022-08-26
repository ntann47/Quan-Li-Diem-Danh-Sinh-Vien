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
    public partial class fr_LopDangDay : Form
    {
        private TaiKhoan taikhoandangdangnhap = fr_DangNhap.Taikhoandangdangnhap;

        GiangVien gv;
        public fr_LopDangDay()
        {
            InitializeComponent();
            dGrVwLopDangDay.ReadOnly = true;
        }

        private void fr_LopDangDay_Load(object sender, EventArgs e)
        {
            txtHoTenGV.ReadOnly = txtMaGV.ReadOnly = txtNgSinh.ReadOnly = txtTrinhDo.ReadOnly = txtMaKhoa.ReadOnly = true;
            gv = GiangVienBUS.Instance.LayThongTin_GV(taikhoandangdangnhap.Tentaikhoan);
            txtMaGV.Text = gv.Magiangvien;
            txtHoTenGV.Text = gv.Hotengv;
            if (gv.Gioitinh.Equals("Nam")|| gv.Gioitinh.Equals("NAM"))
                rBtnNam.Checked = true;
            else
                rBtnNu.Checked = true;
            txtNgSinh.Text = gv.Ngaysinh.ToString();
            txtTrinhDo.Text = gv.Trinhdo;
            txtMaKhoa.Text = gv.Makhoa;
            dGrVwLopDangDay.DataSource = GiangVienBUS.Instance.Load_DSLop_GV(taikhoandangdangnhap.Tentaikhoan);
        }
    }
}
