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
using BUS;

namespace DiemDanhSinhVien
{
    public partial class fr_DiemDanhSinhVien : Form
    {
        private TaiKhoan taikhoandangdangnhap = fr_DangNhap.Taikhoandangdangnhap;
        static GiangVien giangVien;
        static MonHoc_LopMonHoc monhoc_lopmonhoc;
        static PhieuDiemDanh phieudiemdanh;
        public static MonHoc_LopMonHoc Monhoc_lopmonhoc { get => monhoc_lopmonhoc; set => monhoc_lopmonhoc = value; }
        public static PhieuDiemDanh Phieudiemdanh { get => phieudiemdanh; set => phieudiemdanh = value; }
        public fr_DiemDanhSinhVien()
        {
            InitializeComponent();
            dGrVwLopDangDay.ReadOnly = true;
            giangVien = GiangVienBUS.Instance.LayThongTin_GV(taikhoandangdangnhap.Tentaikhoan);
        }
        public void fr_DiemDanhSinhVien_Load(object sender, EventArgs e)
        {
            txtMaGV.Text = giangVien.Magiangvien;
            txtTenGV.Text = giangVien.Hotengv;
            txtMaGV.ReadOnly = txtTenGV.ReadOnly = true;
            Load_CBDSMH_GV();
            dGrVwLopDangDay.ReadOnly = true;
            // Ẩn dòng cuối cùng Trên dataGrd
            dGrVwLopDangDay.AllowUserToAddRows = false;
            btnXemLSDD.Enabled = btnDiemDanh.Enabled = btnTongKetDD.Enabled = false;
            txtMaPDD.Text = (BUS.PhieuDiemDanhBUS.Instance.TruyCap_MaPDDCuoiCung() + 1).ToString();
        }
        private void Load_CBDSMH_GV()
        {
            DataTable ds_MH = BUS.GiangVienBUS.Instance.Load_DSCBMH_GV(giangVien.Magiangvien);
            if (ds_MH.Rows.Count != 0)
            {
                for (int i = 0; i < ds_MH.Rows.Count; i++)
                {
                    cbMonHoc.Items.Add(ds_MH.Rows[i][0].ToString().Trim());
                }
            }
            else
                cbMonHoc.Items.Add("No Data");
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXemLSDD.Enabled =btnTongKetDD.Enabled = btnDiemDanh.Enabled = false;
            txtIDLopMH.Clear();
            string magv = giangVien.Magiangvien;
            string tenmh = cbMonHoc.SelectedItem.ToString();
            dGrVwLopDangDay.DataSource = BUS.GiangVienBUS.Instance.Load_DSLopDiemDanh_GV(magv, tenmh);

        }

        private void btnXemLSDD_Click(object sender, EventArgs e)
        {
            if(Monhoc_lopmonhoc!=null)
            {
                fr_LichSuDiemDanh fr = new fr_LichSuDiemDanh(Monhoc_lopmonhoc);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.ShowDialog();
            }
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            if (Monhoc_lopmonhoc != null)
            {
                if(PhieuDiemDanhBUS.Instance.KiemTra_LichSuDiemDanh(phieudiemdanh.Idlopmh,phieudiemdanh.Tuanthu)!=0)
                {
                    MessageBox.Show("Lớp học này đã được Điểm Danh. Vui lòng chọn lớp khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fr_DiemDanh fr = new fr_DiemDanh(Monhoc_lopmonhoc, Phieudiemdanh);
                    fr.StartPosition = FormStartPosition.CenterScreen;
                    fr.ShowDialog();
                }    
            }
        }

        private void dGrVwLopDangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                int mapdd;
                if (BUS.PhieuDiemDanhBUS.Instance.TruyCap_MaPDDCuoiCung() == -1)
                {
                    mapdd = 1;
                }
                else
                {
                    mapdd = BUS.PhieuDiemDanhBUS.Instance.TruyCap_MaPDDCuoiCung() + 1;
                }
                txtMaPDD.Text = mapdd.ToString();
                DataGridViewRow dgvRow = dGrVwLopDangDay.Rows[e.RowIndex];
                int idlopmh = Int32.Parse(dgvRow.Cells[0].Value.ToString());
                Monhoc_lopmonhoc = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(idlopmh);
                btnXemLSDD.Enabled = btnTongKetDD.Enabled = btnDiemDanh.Enabled = true;
                txtIDLopMH.Text  = Monhoc_lopmonhoc.Idlopmh.ToString();
                int tuanthu = PhieuDiemDanhBUS.Instance.TruyCap_TuanHocCuoiCung(Monhoc_lopmonhoc.Idlopmh)+1;
                phieudiemdanh = new PhieuDiemDanh(mapdd, idlopmh, tuanthu, dateTimePickerNgayDD.Value, 0);
            } 
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void btnTongKetDD_Click(object sender, EventArgs e)
        {
            if (Monhoc_lopmonhoc != null)
            {
                fr_TongKetDiemDanh fr = new fr_TongKetDiemDanh(Monhoc_lopmonhoc);
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.ShowDialog();
            }
        }

        private void btnKetThuc_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn kết thúc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
