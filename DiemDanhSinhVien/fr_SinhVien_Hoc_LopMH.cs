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
    public partial class fr_SinhVien_Hoc_LopMH : Form
    {
        List<SinhVien> lstSv = new List<SinhVien>();
        public fr_SinhVien_Hoc_LopMH()
        {
            InitializeComponent();

            dGrVwMonHoc_LopMH.AllowUserToAddRows = dGrVwDSSV.AllowUserToDeleteRows = false;
            dGrVwDSSV.ReadOnly = true;
            dGrVwMonHoc_LopMH.ReadOnly = true;
        }

        private void fr_SinhVien_Hoc_LopMH_Load(object sender, EventArgs e)
        {
            Load_CbDSMonHoc();
            btnDangKy.Enabled = btnHuyDangKy.Enabled = false;
        }
        private void Load_CbDSMonHoc()
        {
            cbDSMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
            cbDSMonHoc.DisplayMember = "TENMH";
            cbDSMonHoc.ValueMember = "MAMH";

        }

        private void cbDSMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            dGrVwMonHoc_LopMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSLopMonHocTheoMaMonHoc(cbDSMonHoc.SelectedValue.ToString());
        }

        private void dGrVwMonHoc_LopMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwMonHoc_LopMH.Rows[e.RowIndex];
                txtIDLopMH.Text = dgvRow.Cells[0].Value.ToString();
                txtMaLopMH.Text = dgvRow.Cells[1].Value.ToString();
                txtMaMH.Text = dgvRow.Cells[2].Value.ToString();
                txtMaGiangVien.Text = dgvRow.Cells[3].Value.ToString();
                DataTable dt_DSSV = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(Int32.Parse(dgvRow.Cells[0].Value.ToString()));
                dGrVwDSSV.DataSource = dt_DSSV;
                LayDS_SinhVien(dt_DSSV);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSv_Click(object sender, EventArgs e)
        {
            string ma = txtMaSv.Text.Trim();
            if (SinhVienBUS.Instance.LayThongTin_SV(ma) == null)
            {
                MessageBox.Show("Không tìm thấy thông tin Sinh Viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SinhVien sv = SinhVienBUS.Instance.LayThongTin_SV(ma);
                txtMaSv.Text = sv.Masv.Trim();
                txtHtenSv.Text = sv.Hotensv.Trim();
                btnDangKy.Enabled = btnHuyDangKy.Enabled = true;
            }
        }
        private void LayDS_SinhVien(DataTable dt_SV)
        {
            lstSv.Clear();
            for (int i = 0; i < dt_SV.Rows.Count; i++)
            {
                DataRow dr = dt_SV.Rows[i];
                string masv = dr["MASV"].ToString();
                string hotensv = dr["HOTENSV"].ToString();
                string gioitinh = dr["GIOITINH"].ToString();
                string ngaysinh = dr["NGAYSINH"].ToString();
                DateTime ngsinh = DateTime.Parse(ngaysinh);
                string lopnienche = dr["LOPNIENCHE"].ToString();
                SinhVien x = new SinhVien(masv, hotensv, gioitinh, ngsinh, lopnienche);
                lstSv.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaLopMH.Clear();
            txtMaMH.Clear();
            txtMaGiangVien.Clear();
            int id = Int32.Parse(txtIDLopMH.Text.Trim());
            if (MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(id) == null)
            {
                MessageBox.Show("Không tìm thấy thông tin Lớp Môn Học có ID này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MonHoc_LopMonHoc x = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(id);
                txtIDLopMH.Text = x.Idlopmh.ToString();
                txtMaLopMH.Text = x.Malopmh;
                txtMaMH.Text = x.Mamh;
                txtMaGiangVien.Text = x.Magiangvien;
                DataTable dt_mh_lmh = new DataTable();
                dt_mh_lmh.Columns.Add("ID Lớp MH");
                dt_mh_lmh.Columns.Add("Mã Lớp MH");
                dt_mh_lmh.Columns.Add("Mã MH");
                dt_mh_lmh.Columns.Add("Mã Giảng Viên");
                dt_mh_lmh.Columns.Add("Học Kỳ");
                dt_mh_lmh.Columns.Add("Năm Học");
                dt_mh_lmh.Columns.Add("Số Buổi Học");
                dt_mh_lmh.Columns.Add("Ngày Bắt Đầu");
                dt_mh_lmh.Columns.Add("Ngày Kết Thúc");
                dt_mh_lmh.Columns.Add("Sĩ Số");
                dt_mh_lmh.Columns.Add("Mã Phòng Học");
                dt_mh_lmh.Columns.Add("Mã Ca Học");
                dt_mh_lmh.Columns.Add("Trạng Thái");
                DataRow dr = dt_mh_lmh.NewRow();
                dr["ID Lớp MH"] = x.Idlopmh;
                dr["Mã Lớp MH"] = x.Malopmh;
                dr["Mã MH"] = x.Mamh;
                dr["Mã Giảng Viên"] = x.Magiangvien;
                dr["Học Kỳ"] = x.Hocky;
                dr["Năm Học"] = x.Namhoc;
                dr["Số Buổi Học"] = x.Sobuoihoc;
                dr["Ngày Bắt Đầu"] = x.Ngaybatdau;
                dr["Ngày Kết Thúc"] = x.Ngayketthuc;
                dr["Sĩ Số"] = x.Siso;
                dr["Mã Phòng Học"] = x.Maphonghoc;
                dr["Mã Ca Học"] = x.Macahoc;
                dr["Trạng Thái"] = x.Trangthai;
                dt_mh_lmh.Rows.Add(dr);
                dGrVwMonHoc_LopMH.DataSource = dt_mh_lmh;
                DataTable dt_DSSV = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(Int32.Parse(txtIDLopMH.Text.Trim()));
                dGrVwDSSV.DataSource = dt_DSSV;
                LayDS_SinhVien(dt_DSSV);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            SinhVien x = SinhVienBUS.Instance.LayThongTin_SV(txtMaSv.Text.Trim());

            if (KiemTraSinhVien(lstSv, x) == 0)
            {
                SinhVien_Hoc_LopMonHoc shl = new SinhVien_Hoc_LopMonHoc(Int32.Parse(txtIDLopMH.Text.Trim()), txtMaSv.Text.Trim(), dtpNgayDK.Value);
                if (SinhVien_Hoc_LopMonHocBUS.Instance.Insert_SinhVien_Hoc_LopMonHoc(shl) == 1)
                {
                    DataTable dt_DSSV = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(Int32.Parse(txtIDLopMH.Text.Trim()));
                    dGrVwDSSV.DataSource = dt_DSSV;
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGrVwDSSV.DataSource = dt_DSSV;
                    LayDS_SinhVien(dt_DSSV);
                }
             }
            else
            {
                MessageBox.Show("Sinh Viên này đã tham gia lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private int KiemTraSinhVien(List<SinhVien> lst, SinhVien x)
        {
            foreach (SinhVien sv in lstSv)
            {
                if (x.Masv.Equals(sv.Masv))
                {
                         return 1;
                }
            }
            return 0;
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn huỷ đăng ký không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                SinhVien x = SinhVienBUS.Instance.LayThongTin_SV(txtMaSv.Text.Trim());
                if (KiemTraSinhVien(lstSv, x) == 1)
                {
                    SinhVien_Hoc_LopMonHoc shl = new SinhVien_Hoc_LopMonHoc(Int32.Parse(txtIDLopMH.Text.Trim()), txtMaSv.Text.Trim(), dtpNgayDK.Value);
                    if (SinhVien_Hoc_LopMonHocBUS.Instance.Delete_SinhVien_Hoc_LopMonHoc(shl) == 1)
                    {
                        DataTable dt_DSSV = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(Int32.Parse(txtIDLopMH.Text.Trim()));
                        dGrVwDSSV.DataSource = dt_DSSV;
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGrVwDSSV.DataSource = dt_DSSV;
                        LayDS_SinhVien(dt_DSSV);
                    }
                }
                else
                {
                    MessageBox.Show("Sinh Viên này chưa tham gia lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }    
        }
    }
}