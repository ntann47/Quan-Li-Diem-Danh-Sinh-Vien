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
    public partial class fr_LichSuDiemDanh : Form
    {
        MonHoc_LopMonHoc mh_lopmh;
        public fr_LichSuDiemDanh(MonHoc_LopMonHoc mh_lopmh)
        {
            InitializeComponent();
            dGrVwDSSVVang.ReadOnly = dGrVwLSDD.ReadOnly = true;
        }

        private void fr_LichSuDiemDanh_Load(object sender, EventArgs e)
        {
            MonHoc_LopMonHoc mh_lmh = fr_DiemDanhSinhVien.Monhoc_lopmonhoc;
            txtIDLopMH.ReadOnly = txtMaMH.ReadOnly = txtMaLopMH.ReadOnly = true;
            txtIDLopMH.Text = mh_lmh.Idlopmh.ToString();
            txtMaMH.Text = mh_lmh.Mamh;
            txtMaLopMH.Text = mh_lmh.Malopmh;
            txtSiSo.Text = (MonHoc_LopMonHocBUS.Instance.LaySiSo_LopMonHoc(mh_lmh).ToString());
            // Ẩn dòng cuối cùng Trên dataGrd
            dGrVwLSDD.AllowUserToAddRows = false;
            dGrVwLSDD.DataSource = PhieuDiemDanhBUS.Instance.LayDS_LichSuDiemDanh_LopMH(mh_lmh.Idlopmh);

        }

        private void dGrVwLSDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwLSDD.Rows[e.RowIndex];
                int mapdd = Int32.Parse(dgvRow.Cells[0].Value.ToString());
                dGrVwDSSVVang.AllowUserToAddRows = false;
                dGrVwDSSVVang.DataSource = LichSuVangBUS.Instance.LayDS_LichSuVang_PDD(mapdd);
            }
        }
    }
}
