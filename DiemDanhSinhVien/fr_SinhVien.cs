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
    public partial class fr_SinhVien : Form
    {
        public fr_SinhVien()
        {
            InitializeComponent();
            dGrVwSinhVien.AllowUserToAddRows = false;
            dGrVwSinhVien.ReadOnly = true;
        }

        private void fr_SinhVien_Load(object sender, EventArgs e)
        {
            tSbtnXoa.Enabled  = tSbtnLuu.Enabled = false;
            txtHoTenSV.Enabled = dtpNgSinh.Enabled = cbGioiTinh.Enabled = cbMaLop.Enabled = false;
            dGrVwSinhVien.DataSource = SinhVienBUS.Instance.Load_DanhSach_SinhVien();
            cbMaLop.DataSource = LopMonHocBUS.Instance.Load_DanhSach_LopNienChe();
            cbMaLop.DisplayMember = "MALOPMH";
            cbMaLop.ValueMember = "MALOPMH";
        }
        private void Load_CbGioiTinh()
        {
            string[] gt = { "Nam", "Nữ" };
            cbGioiTinh.Items.AddRange(gt);

        }
        private void dGrVwSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.ReadOnly = true;
            txtHoTenSV.Enabled = dtpNgSinh.Enabled = cbGioiTinh.Enabled = cbMaLop.Enabled = true;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = dgvRow.Cells[0].Value.ToString();
                txtHoTenSV.Text = dgvRow.Cells[1].Value.ToString();
                cbGioiTinh.SelectedItem = dgvRow.Cells[2].Value.ToString();
                dtpNgSinh.Value = DateTime.Parse(dgvRow.Cells[3].Value.ToString());
                cbMaLop.SelectedValue = dgvRow.Cells[4].Value.ToString();
                tSbtnXoa.Enabled = tSbtnMoi.Enabled = tSbtnLuu.Enabled = true;
            }
        }
        private void Clear()
        {
            tSbtnXoa.Enabled = tSbtnLuu.Enabled = false;
            DateTime dt = DateTime.Now;
            txtMaSV.Clear();
            txtMaSV.Focus();
            txtHoTenSV.Clear();
            cbGioiTinh.SelectedIndex = 0;
            dtpNgSinh.Value = dt;
            cbMaLop.SelectedIndex = 0;
        }    
        private void tSbtnMoi_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaSV.ReadOnly = tSbtnMoi.Enabled = false;
            tSbtnLuu.Enabled = txtHoTenSV.Enabled = txtMaSV.Enabled = dtpNgSinh.Enabled = cbGioiTinh.Enabled = cbMaLop.Enabled = true;

        }

        private void tSbtnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Equals("") || txtHoTenSV.Text.Equals(""))
            {
                MessageBox.Show("Dữ liệu chưa đủ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime ngsinh = DateTime.Parse(dtpNgSinh.Value.ToString());
                SinhVien x = new SinhVien(txtMaSV.Text.Trim(), txtHoTenSV.Text.Trim(), cbGioiTinh.SelectedItem.ToString().Trim(),ngsinh,cbMaLop.SelectedValue.ToString());
                if (tSbtnMoi.Enabled == false)
                {

                    if (SinhVienBUS.Instance.LayThongTin_SV(x.Masv) !=null)
                    {

                        MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (SinhVienBUS.Instance.Insert_SinhVien(x) == 1)
                        {
                            dGrVwSinhVien.DataSource = SinhVienBUS.Instance.Load_DanhSach_SinhVien();
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
                    if (SinhVienBUS.Instance.Update_SinhVien(x) != -1)
                    {
                        dGrVwSinhVien.DataSource = SinhVienBUS.Instance.Load_DanhSach_SinhVien();
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

        private void tSbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                 DateTime ngsinh = DateTime.Parse(dtpNgSinh.Value.ToString());
                SinhVien x = new SinhVien(txtMaSV.Text.Trim(), txtHoTenSV.Text.Trim(), cbGioiTinh.SelectedItem.ToString().Trim(), ngsinh, cbMaLop.SelectedValue.ToString());
                if (SinhVien_Hoc_LopMonHocBUS.Instance.KiemTraKhoaNgoai_SinhVien(x) == 1||LichSuVangBUS.Instance.KiemTraKhoaNgoai_SinhVien(x)==1)
                {
                    MessageBox.Show("Dữ liệu đang được sử dụng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (SinhVienBUS.Instance.Delete_SinhVien(x) != -1)
                    {
                        dGrVwSinhVien.DataSource = SinhVienBUS.Instance.Load_DanhSach_SinhVien();
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

        private void btnTimGV_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (SinhVienBUS.Instance.LayThongTin_SV(ma) == null)
            {
                MessageBox.Show("Không tìm thấy thông tin Sinh Viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tSbtnMoi.Enabled == false)
                    tSbtnMoi.Enabled = true;
            }
            else
            {
                SinhVien sv = SinhVienBUS.Instance.LayThongTin_SV(ma);
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã SV");
                dt.Columns.Add("Họ Tên SV");
                dt.Columns.Add("Giới Tính");
                dt.Columns.Add("Ngày Sinh");
                dt.Columns.Add("Lớp Niên Chế");
                DataRow dr = dt.NewRow();
                dr["Mã SV"] = sv.Masv;
                dr["Họ Tên SV"] = sv.Hotensv;
                dr["Giới Tính"] = sv.Gioitinh;
                dr["Ngày Sinh"] = sv.Ngaysinh;
                dr["Lớp Niên Chế"] = sv.Lopnienche;
                dt.Rows.Add(dr);
                dGrVwSinhVien.DataSource = dt;

            }
        }
    }
}
