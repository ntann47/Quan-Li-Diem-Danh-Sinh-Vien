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
    public partial class fr_GiangVien : Form
    {
        public fr_GiangVien()
        {
            InitializeComponent();
            dGrVwGiangVien.AllowUserToAddRows = false;
            dGrVwGiangVien.ReadOnly = true;
        }

        private void fr_GiangVien_Load(object sender, EventArgs e)
        {
            Load_CbKhoa();
            dGrVwGiangVien.DataSource = BUS.GiangVienBUS.Instance.Load_DanhSach_GiangVien();
            txtHtenGV.Enabled = txtTrinhDo.Enabled = rBtnNam.Enabled = rBtnNu.Enabled = cbMaKhoa.Enabled =dtpNgSinh.Enabled =tSbtnXoa.Enabled = tSbtnLuu.Enabled = false;
        }
        private void Load_CbKhoa()
        {
            cbMaKhoa.DataSource = KhoaBUS.Instance.Load_Khoa();
            cbMaKhoa.DisplayMember = "TENKHOA";
            cbMaKhoa.ValueMember = "MAKHOA";

        }

        private void tSbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string gioitinh;
                if (rBtnNam.Checked)
                    gioitinh = "Nam";
                else gioitinh = "Nữ";
                DateTime ngsinh = DateTime.Parse(dtpNgSinh.Value.ToString());
                GiangVien x = new GiangVien(txtMaGV.Text.Trim(), txtHtenGV.Text.Trim(), gioitinh, ngsinh, txtTrinhDo.Text.Trim(), cbMaKhoa.SelectedValue.ToString());
                if (MonHoc_LopMonHocBUS.Instance.KiemTraKhoaNgoai_GiangVien(x) == 1)
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (GiangVienBUS.Instance.Delete_GiangVien(x) != -1)
                    {
                        dGrVwGiangVien.DataSource = GiangVienBUS.Instance.Load_DanhSach_GiangVien();
                        Clear();
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dGrVwGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.ReadOnly = true;
            txtMaGV.Enabled = dtpNgSinh.Enabled = txtHtenGV.Enabled = txtTrinhDo.Enabled = cbMaKhoa.Enabled = rBtnNam.Enabled = rBtnNu.Enabled = true;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwGiangVien.Rows[e.RowIndex];
                txtMaGV.Text = dgvRow.Cells[0].Value.ToString();
                txtHtenGV.Text = dgvRow.Cells[1].Value.ToString();
                if (dgvRow.Cells[2].Value.ToString().Equals("Nam") || dgvRow.Cells[2].Value.ToString().Equals("NAM"))
                    rBtnNam.Checked = true;
                else rBtnNu.Checked = true;
                dtpNgSinh.Value = DateTime.Parse(dgvRow.Cells[3].Value.ToString());
                txtTrinhDo.Text = dgvRow.Cells[4].Value.ToString();
                cbMaKhoa.SelectedValue = dgvRow.Cells[5].Value.ToString();
                tSbtnXoa.Enabled = tSbtnMoi.Enabled = tSbtnLuu.Enabled = true;
            }
        }

        private void tSbtnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text.Equals("") || txtHtenGV.Text.Equals("")||txtTrinhDo.Text.Equals(""))
            {
                MessageBox.Show("Dữ liệu chưa đủ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string gioitinh;
                if (rBtnNam.Checked)
                    gioitinh = "Nam";
                else gioitinh = "Nữ";
                DateTime ngsinh = DateTime.Parse(dtpNgSinh.Value.ToString());
                GiangVien x = new GiangVien(txtMaGV.Text.Trim(), txtHtenGV.Text.Trim(), gioitinh, ngsinh, txtTrinhDo.Text.Trim(), cbMaKhoa.SelectedValue.ToString());
                if (tSbtnMoi.Enabled == false)
                {

                    if (GiangVienBUS.Instance.LayThongTin_GV(x.Magiangvien) != null)
                    {

                        MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (GiangVienBUS.Instance.Insert_GiangVien(x) == 1)
                        {
                            dGrVwGiangVien.DataSource = GiangVienBUS.Instance.Load_DanhSach_GiangVien();
                            Clear();
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
                    if (GiangVienBUS.Instance.Update_GiangVien(x) == 1)
                    {
                        dGrVwGiangVien.DataSource = GiangVienBUS.Instance.Load_DanhSach_GiangVien();
                        Clear();
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Clear()
        {
            tSbtnXoa.Enabled = tSbtnLuu.Enabled = false;
            DateTime dt = DateTime.Now;
            txtMaGV.Clear();
            txtHtenGV.Clear();
            txtTrinhDo.Clear();
            rBtnNam.Checked = true;
            dtpNgSinh.Value = dt;
            cbMaKhoa.SelectedIndex = 0;
        }

        private void tSbtnMoi_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaGV.ReadOnly = false;
            tSbtnMoi.Enabled = false;
            tSbtnLuu.Enabled = true;
            txtMaGV.Enabled = txtHtenGV.Enabled = txtTrinhDo.Enabled = rBtnNam.Enabled = rBtnNu.Enabled = cbMaKhoa.Enabled = dtpNgSinh.Enabled = true;
        }

        private void btnTimGV_Click(object sender, EventArgs e)
        {
            string ma = txtMaGV.Text.Trim();
            if(GiangVienBUS.Instance.LayThongTin_GV(ma)==null)
            {
                MessageBox.Show("Không tìm thấy thông tin Giảng Viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                GiangVien gv = GiangVienBUS.Instance.LayThongTin_GV(ma);
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã GV");
                dt.Columns.Add("Họ Tên GV");
                dt.Columns.Add("Giới Tính");
                dt.Columns.Add("Ngày Sinh");
                dt.Columns.Add("Trình Độ");
                dt.Columns.Add("Mã Khoa");
                DataRow dr = dt.NewRow();
                dr["Mã GV"] = gv.Magiangvien;
                dr["Họ Tên GV"] = gv.Hotengv;
                dr["Giới Tính"] = gv.Gioitinh;
                dr["Ngày Sinh"] = gv.Ngaysinh;
                dr["Trình Độ"] = gv.Trinhdo;
                dr["Mã Khoa"] = gv.Makhoa;
                dt.Rows.Add(dr);
                dGrVwGiangVien.DataSource = dt;          
            }    
        }
    }
}
