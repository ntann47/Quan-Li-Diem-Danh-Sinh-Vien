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
    public partial class fr_MonHoc_LopMonHoc : Form
    {
        public fr_MonHoc_LopMonHoc()
        {
            InitializeComponent();
            dGrVwMH_LMH.AllowUserToAddRows = false;
            dGrVwMH_LMH.ReadOnly = true;
        }

        private void fr_MonHoc_LopMonHoc_Load(object sender, EventArgs e)
        {
            tSbtnXoa.Enabled = tSbtnLuu.Enabled = false;
            txtMaLopMH.Enabled = txtMaMH.Enabled = txtMaGV.Enabled = cbHocKy.Enabled = txtNamHoc.Enabled = txtSoBuoi.Enabled = dtpNgayBD.Enabled = dtpNgayKT.Enabled = txtSiSo.Enabled = txtPhongHoc.Enabled = cbCaHoc.Enabled = cbTrangThai.Enabled = false;
            dGrVwMH_LMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSMH_LMH();
            Load_CBHocKy();
            Load_CBCaHoc();
            Load_CBTrangThai();

        }
        private void Load_CBCaHoc()
        {
            cbCaHoc.DataSource = CaHocBUS.Instance.Load_CaHoc();
            cbCaHoc.ValueMember = "MACAHOC";
            cbCaHoc.DisplayMember = "MACAHOC";
        }
        private void Load_CBHocKy()
        {
            string[] hocky = { "1", "2", "3" };
            cbHocKy.Items.AddRange(hocky);
        }
        private void Load_CBTrangThai()
        {
            string[] trangthai = { "MỞ LỚP", "ĐÃ BẮT ĐẦU", "ĐÃ KẾT THÚC" };
            cbTrangThai.Items.AddRange(trangthai);
        }

        private void dGrVwMH_LMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDLopMH.ReadOnly = true;
            txtIDLopMH.Enabled = txtMaLopMH.Enabled = txtMaMH.Enabled = txtMaGV.Enabled = cbHocKy.Enabled = txtNamHoc.Enabled = txtSoBuoi.Enabled = dtpNgayBD.Enabled = dtpNgayKT.Enabled = txtSiSo.Enabled = txtPhongHoc.Enabled = cbCaHoc.Enabled = cbTrangThai.Enabled = true;
            tSbtnXoa.Enabled = tSbtnLuu.Enabled = true;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwMH_LMH.Rows[e.RowIndex];
                txtIDLopMH.Text = dgvRow.Cells[0].Value.ToString();
                txtMaLopMH.Text = dgvRow.Cells[1].Value.ToString();
                txtMaMH.Text = dgvRow.Cells[2].Value.ToString();
                txtMaGV.Text = dgvRow.Cells[3].Value.ToString();
                cbHocKy.SelectedItem = dgvRow.Cells[4].Value.ToString();
                txtNamHoc.Text = dgvRow.Cells[5].Value.ToString();
                txtSoBuoi.Text = dgvRow.Cells[6].Value.ToString();
                dtpNgayBD.Value = DateTime.Parse(dgvRow.Cells[7].Value.ToString());
                dtpNgayKT.Value = DateTime.Parse(dgvRow.Cells[8].Value.ToString());
                txtSiSo.Text = dgvRow.Cells[9].Value.ToString();
                txtPhongHoc.Text = dgvRow.Cells[10].Value.ToString();
                cbCaHoc.SelectedValue = dgvRow.Cells[11].Value.ToString();
                cbTrangThai.SelectedItem = dgvRow.Cells[12].Value.ToString();
                tSbtnXoa.Enabled = tSbtnMoi.Enabled = tSbtnLuu.Enabled = true;

            }
        }
        private void Clear()
        {
            DateTime dt = DateTime.Now;
            txtIDLopMH.Clear();
            txtIDLopMH.Focus();
            txtMaLopMH.Clear();
            txtMaMH.Clear();
            txtMaGV.Clear();
            cbHocKy.SelectedIndex = 0;
            txtNamHoc.Clear();
            txtSoBuoi.Clear();
            dtpNgayBD.Value = dt;
            dtpNgayKT.Value = dt;
            txtSiSo.Clear();
            txtPhongHoc.Clear();
            cbCaHoc.SelectedIndex = 0;
            cbTrangThai.SelectedItem = "MỞ LỚP";
        }
        private void tSbtnMoi_Click(object sender, EventArgs e)
        {
            txtIDLopMH.ReadOnly =  tSbtnMoi.Enabled = false;
            tSbtnLuu.Enabled = tSbtnXoa.Enabled = txtIDLopMH.Enabled = txtMaLopMH.Enabled = txtMaMH.Enabled = txtMaGV.Enabled = cbHocKy.Enabled = txtNamHoc.Enabled = txtSoBuoi.Enabled = dtpNgayBD.Enabled = dtpNgayKT.Enabled = txtSiSo.Enabled = txtPhongHoc.Enabled = cbCaHoc.Enabled = cbTrangThai.Enabled = true;
            Clear();
            cbTrangThai.Enabled = false;
        }
        private int KiemTraTextBoxRong()
        {
            int dem = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    if (ctrl.Text.Equals(""))
                        if (ctrl == txtMaGV) continue;
                        else
                            dem++;
            }
            return dem;
        }
        private void tSbtnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTextBoxRong() != 0)
            {
                MessageBox.Show("Dữ liệu chưa đủ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int idlopmh = Int32.Parse(txtIDLopMH.Text.Trim());
                string malopmh = txtMaLopMH.Text.Trim();
                string mamh = txtMaMH.Text.Trim();
                int hocky = Int32.Parse(cbHocKy.SelectedItem.ToString());
                string namhoc = txtNamHoc.Text.Trim();
                int sobuoi = Int32.Parse(txtSoBuoi.Text.Trim());
                DateTime ngaybd = dtpNgayBD.Value;
                DateTime ngaykt = dtpNgayKT.Value;
                int siso = Int32.Parse(txtSiSo.Text.Trim());
                string maph = txtPhongHoc.Text.Trim();
                string maca = cbCaHoc.SelectedValue.ToString();
                string trangthai = cbTrangThai.SelectedItem.ToString();
                MonHoc_LopMonHoc x = new MonHoc_LopMonHoc(idlopmh, malopmh, mamh, hocky, namhoc, sobuoi, ngaybd, ngaykt, siso, maph, maca, trangthai);
                if (tSbtnMoi.Enabled == false)
                {

                    if (MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(x.Idlopmh) != null)
                    {
                        MessageBox.Show("ID Lớp Môn Học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(x.Idlopmh) == null)
                    {
                        if (MonHoc_LopMonHocBUS.Instance.Insert_MonHoc_LopMonHoc(x) == 1)
                        {
                            dGrVwMH_LMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSMH_LMH();
                            Clear();
                            cbTrangThai.Enabled = true;
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
                    string magv = txtMaGV.Text.Trim();
                    if (magv.Equals(""))
                        magv = "-";
                    MonHoc_LopMonHoc mh_update = new MonHoc_LopMonHoc(idlopmh, malopmh, mamh,magv, hocky, namhoc, sobuoi, ngaybd, ngaykt, siso, maph, maca, trangthai);

                    if (MonHoc_LopMonHocBUS.Instance.Update_MonHoc_LopMonHoc(mh_update) != -1)
                    {
                        dGrVwMH_LMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSMH_LMH();
                        Clear();
                        MessageBox.Show("Cập nhật hành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
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
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                int idlopmh = Int32.Parse(txtIDLopMH.Text.Trim());
                string malopmh = txtMaLopMH.Text.Trim();
                string mamh = txtMaMH.Text.Trim();
                int hocky = Int32.Parse(cbHocKy.SelectedItem.ToString());
                string namhoc = txtNamHoc.Text.Trim();
                int sobuoi = Int32.Parse(txtSoBuoi.Text.Trim());
                DateTime ngaybd = dtpNgayBD.Value;
                DateTime ngaykt = dtpNgayKT.Value;
                int siso = Int32.Parse(txtSiSo.Text.Trim());
                string maph = txtPhongHoc.Text.Trim();
                string maca = cbCaHoc.SelectedValue.ToString();
                string trangthai = cbTrangThai.SelectedItem.ToString();
                MonHoc_LopMonHoc x = new MonHoc_LopMonHoc(idlopmh, malopmh, mamh, hocky, namhoc, sobuoi, ngaybd, ngaykt, siso, maph, maca, trangthai);
                if (SinhVien_Hoc_LopMonHocBUS.Instance.KiemTraKhoaNgoai_MonHoc_LopMonHoc(x) == 1 || PhieuDiemDanhBUS.Instance.KiemTraKhoaNgoai_MonHoc_LopMonHoc(x) == 1)
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (MonHoc_LopMonHocBUS.Instance.Delete_MonHoc_LopMonHoc(x) != -1)
                    {
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGrVwMH_LMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSMH_LMH();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIDLopMH.Text.Trim());
            if (MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(id) == null)
            {
                MessageBox.Show("Không tìm thấy thông tin Lớp Môn Học có ID này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MonHoc_LopMonHoc x = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(id);
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
                dGrVwMH_LMH.DataSource = dt_mh_lmh;

            }
        }
    }
}
