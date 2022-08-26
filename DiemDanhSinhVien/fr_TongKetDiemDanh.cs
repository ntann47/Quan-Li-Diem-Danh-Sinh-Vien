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
    public partial class fr_TongKetDiemDanh : Form
    {
        MonHoc_LopMonHoc mh_lopmh;
        public fr_TongKetDiemDanh(MonHoc_LopMonHoc mh_lopmh)
        {
            InitializeComponent();
        }

        private void fr_TongKetDiemDanh_Load(object sender, EventArgs e)
        {
            MonHoc_LopMonHoc mh_lmh = fr_DiemDanhSinhVien.Monhoc_lopmonhoc;
            txtIDLopMH.ReadOnly = txtMaMH.ReadOnly = txtMaLopMH.ReadOnly = true;
            txtIDLopMH.Text = mh_lmh.Idlopmh.ToString();
            txtMaMH.Text = mh_lmh.Mamh;
            txtMaLopMH.Text = mh_lmh.Malopmh;
            // Ẩn dòng cuối cùng Trên dataGrd
            dGrVwDSSVVang.AllowUserToAddRows = false;
            dGrVwDSSVVang.DataSource = MonHoc_LopMonHocBUS.Instance.TongKetVang_LopMonHoc(mh_lmh);
        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {
            fr_reportTongKetVang fr = new fr_reportTongKetVang();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.ShowDialog();

        }
    }
}
