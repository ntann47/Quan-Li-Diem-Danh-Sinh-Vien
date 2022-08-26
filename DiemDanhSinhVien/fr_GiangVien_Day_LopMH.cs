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
    public partial class fr_GiangVien_Day_LopMH : Form
    {
        MonHoc_LopMonHoc mh_lmh;
        public fr_GiangVien_Day_LopMH()
        {
            InitializeComponent();
            dGrVwMonHoc_LopMH.AllowUserToAddRows  = false;
            dGrVwMonHoc_LopMH.ReadOnly = true;
        }

        private void GiangVien_Day_LopMH_Load(object sender, EventArgs e)
        {
            Load_CbDSMonHoc();
           txtHtenGv.ReadOnly = txtKhoa.ReadOnly = true;
            btnDangKy.Enabled = false;

        }
        private void Load_CbDSMonHoc()
        {
            cbDSMonHoc.DataSource = MonHocBUS.Instance.Load_DanhSach_MonHoc();
            cbDSMonHoc.DisplayMember = "TENMH";
            cbDSMonHoc.ValueMember = "MAMH";

        }

        private void dGrVwMonHoc_LopMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwMonHoc_LopMH.Rows[e.RowIndex];
                txtIDLopMH.Text = dgvRow.Cells[0].Value.ToString();
                int idlopmh = Int32.Parse(dgvRow.Cells[0].Value.ToString());
                txtMaLopMH.Text = dgvRow.Cells[1].Value.ToString();
                string malopmh = dgvRow.Cells[1].Value.ToString();
                txtMaMH.Text = dgvRow.Cells[2].Value.ToString();
                string mamh = dgvRow.Cells[2].Value.ToString();
                txtMaGiangVien.Text = dgvRow.Cells[3].Value.ToString();
                string magv = dgvRow.Cells[3].Value.ToString();
                int hocky = Int32.Parse(dgvRow.Cells[4].Value.ToString());
                string namhoc = dgvRow.Cells[5].Value.ToString();
                int sobuoi = Int32.Parse(dgvRow.Cells[6].Value.ToString());
                DateTime ngaybd = DateTime.Parse(dgvRow.Cells[7].Value.ToString());
                DateTime ngaykt = DateTime.Parse(dgvRow.Cells[8].Value.ToString());
                int siso = Int32.Parse(dgvRow.Cells[9].Value.ToString());
                string maph = dgvRow.Cells[10].Value.ToString();
                string maca = dgvRow.Cells[11].Value.ToString();
                string trangthai = dgvRow.Cells[12].Value.ToString();
                mh_lmh = new MonHoc_LopMonHoc(idlopmh, malopmh, mamh, magv, hocky, namhoc, sobuoi, ngaybd, ngaykt, siso, maph, maca, trangthai);
            }
        }

        private void cbDSMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGrVwMonHoc_LopMH.DataSource = MonHoc_LopMonHocBUS.Instance.Load_DSLopMonHocTheoMaMonHoc(cbDSMonHoc.SelectedValue.ToString());

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
                capNhat_GridView_MonHoc_LopMH(x);
            }
        }

        private void btnTimSv_Click(object sender, EventArgs e)
        {
            string ma = txtMaGv.Text.Trim();
            if (GiangVienBUS.Instance.LayThongTin_GV(ma) == null)
            {
                MessageBox.Show("Không tìm thấy thông tin Giảng Viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                GiangVien gv = GiangVienBUS.Instance.LayThongTin_GV(ma);
                txtMaGv.Text = gv.Magiangvien.Trim();
                txtHtenGv.Text = gv.Hotengv.Trim();
                txtKhoa.Text = gv.Makhoa.Trim();
                btnDangKy.Enabled = true;
                
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtMaGiangVien.Text.Equals(""))
            {
                mh_lmh = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(int.Parse(txtIDLopMH.Text.Trim()));
                if (MonHoc_LopMonHocBUS.Instance.Update_GV_MonHoc_LopMonHoc(mh_lmh, txtMaGv.Text.Trim()) == 1)
                {
                    MonHoc_LopMonHoc x = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(mh_lmh.Idlopmh);
                    capNhat_GridView_MonHoc_LopMH(x);
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
            else
            {
                DialogResult r = MessageBox.Show("Lớp đã có Giảng Viên dạy. Bạn có muốn đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
                {
                    mh_lmh = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(int.Parse(txtIDLopMH.Text.Trim()));
                    if (MonHoc_LopMonHocBUS.Instance.Update_GV_MonHoc_LopMonHoc(mh_lmh, txtMaGv.Text.Trim()) == 1)
                    {
                        MonHoc_LopMonHoc x = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(mh_lmh.Idlopmh);
                        txtMaGiangVien.Text = x.Magiangvien;
                        capNhat_GridView_MonHoc_LopMH(x);
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }    
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaGiangVien.Text.Equals("-")|| txtMaGiangVien.Text.Equals("") || txtMaGiangVien.Text.Equals(txtMaGv.Text)==false)
            {
                    MessageBox.Show("Chưa đăng ký hoặc lớp không phải của Giảng Viên này. Không thể hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn hỷ đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    mh_lmh = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(int.Parse(txtIDLopMH.Text.Trim()));
                    string magv = "-";
                    if (MonHoc_LopMonHocBUS.Instance.Update_GV_MonHoc_LopMonHoc(mh_lmh, magv) == 1)
                    {
                        MonHoc_LopMonHoc x = MonHoc_LopMonHocBUS.Instance.LayThongTin_MonHoc_LopMH(mh_lmh.Idlopmh);
                        txtMaGiangVien.Text = x.Magiangvien;
                        capNhat_GridView_MonHoc_LopMH(x);
                        MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xử lí với CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        private void capNhat_GridView_MonHoc_LopMH(MonHoc_LopMonHoc x)
        {
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
        }
    }
}
