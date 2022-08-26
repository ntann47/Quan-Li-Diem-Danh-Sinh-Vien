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
    public partial class fr_DiemDanh : Form
    {
        MonHoc_LopMonHoc mh_lopmh;
        PhieuDiemDanh phieudiemdanh;
        DataTable dt_DSVang = new DataTable();

        public MonHoc_LopMonHoc Mh_lopmh { get => mh_lopmh; set => mh_lopmh = value; }

        public fr_DiemDanh(MonHoc_LopMonHoc mh_lopmh,PhieuDiemDanh pdd)
        {
            InitializeComponent();
            dGrVwDSDDSV.ReadOnly = dGrVwDSVang.ReadOnly = true;
        }

        private void fr_DiemDanh_Load(object sender, EventArgs e)
        {
            MonHoc_LopMonHoc mh_lmh = fr_DiemDanhSinhVien.Monhoc_lopmonhoc;
            txtMaMH.Text = mh_lmh.Mamh;
            phieudiemdanh = fr_DiemDanhSinhVien.Phieudiemdanh;
            txtTuanThu.Text = phieudiemdanh.Tuanthu.ToString().Trim();
            txtSiSo.Text = (MonHoc_LopMonHocBUS.Instance.LaySiSo_LopMonHoc(mh_lmh).ToString());          // Ẩn dòng cuối cùng Trên dataGrd
          dGrVwDSDDSV.AllowUserToAddRows = false;
            dGrVwDSDDSV.DataSource = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(mh_lmh.Idlopmh);
            btnVang.Enabled = btnHuyVang.Enabled = false;
            dt_DSVang.Columns.Add("Mã SV");
            dt_DSVang.Columns.Add("Họ Tên");
            dt_DSVang.Columns.Add("Giới Tính");
            dt_DSVang.Columns.Add("Ngày Sinh");
            dt_DSVang.Columns.Add("Lớp Niên Chế");
            dt_DSVang.Columns.Add("Lí Do Vắng");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_DSVang.Columns[0];
            dt_DSVang.PrimaryKey = key;
            dGrVwDSVang.DataSource = dt_DSVang;
        }

        private void dGrVwDSDDSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwDSDDSV.Rows[e.RowIndex];
                txtMaSv.Text = dgvRow.Cells[0].Value.ToString();
                txtHten.Text = dgvRow.Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvRow.Cells[2].Value.ToString();
                txtNgSinh.Text = dgvRow.Cells[3].Value.ToString();
                txtLopNienChe.Text = dgvRow.Cells[4].Value.ToString();
                btnVang.Enabled = true;
                btnHuyVang.Enabled = true;
            }
        }

        private void btnVang_Click(object sender, EventArgs e)
        {
            if (txtLiDoVang.Text.Equals(""))
            {
                DialogResult r = MessageBox.Show("Lí do vắng đang trống. Bạn có muốn tiếp tục không?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    Them_SinhVienVang();
                }
                else
                {
                    return;
                }
            }
            else
                Them_SinhVienVang();
            
        }
        private void Them_SinhVienVang()
        {
            if (dt_DSVang.Rows.Find(txtMaSv.Text.Trim()) == null)
            {
                DataRow dr = dt_DSVang.NewRow();
                dr["Mã SV"] = txtMaSv.Text.Trim();
                dr["Họ Tên"] = txtHten.Text.Trim();
                dr["Giới Tính"] = txtGioiTinh.Text.Trim();
                dr["Ngày Sinh"] = txtNgSinh.Text.Trim();
                dr["Lớp Niên Chế"] = txtLopNienChe.Text.Trim();
                dr["Lí Do Vắng"] = txtLiDoVang.Text.Trim();
                dt_DSVang.Rows.Add(dr);
                dGrVwDSVang.DataSource = dt_DSVang;
            }
            else
                MessageBox.Show("Sinh viên này đã nằm trong danh sách vắng!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dGrVwDSVang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLiDoVang.Clear();
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGrVwDSVang.Rows[e.RowIndex];
                txtMaSv.Text = dgvRow.Cells[0].Value.ToString();
                txtHten.Text = dgvRow.Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvRow.Cells[2].Value.ToString();
                txtNgSinh.Text = dgvRow.Cells[3].Value.ToString();
                txtLopNienChe.Text = dgvRow.Cells[4].Value.ToString();
                btnVang.Enabled = false; 
                btnHuyVang.Enabled = true;
            }
        }

        private void btnHuyVang_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_DSVang.Rows.Find(txtMaSv.Text.Trim());
            if ( dr != null)
            {
                dr.Delete();
                dGrVwDSVang.DataSource = dt_DSVang;
            }
            else
                MessageBox.Show("Sinh viên này không nằm trong danh sách vắng!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sosvvang = dt_DSVang.Rows.Count;
            try
            {
                List<LichSuVang> lstLsv = new List<LichSuVang>();    
                PhieuDiemDanh pdd = new PhieuDiemDanh(phieudiemdanh.Mapdd, phieudiemdanh.Idlopmh, phieudiemdanh.Tuanthu, phieudiemdanh.Ngaydiemdanh, sosvvang);
                string result = "Số sinh viên vắng: " + sosvvang+"\nBạn có muốn xác nhận Lưu không?";
                for (int i = 0; i < dt_DSVang.Rows.Count; i++)
                {
                    DataRow dr = dt_DSVang.Rows[i];
                    int mapdd = pdd.Mapdd;
                    int id = i + 1;
                    string masv = dr["Mã SV"].ToString();
                    string hotensv = dr["Họ Tên"].ToString();
                    string gioitinh = dr["Giới Tính"].ToString();
                    string ngaysinh = dr["Ngày Sinh"].ToString();
                    string lopnienche = dr["Lớp Niên Chế"].ToString();
                    string lydovang = dr["Lí Do Vắng"].ToString();
                    if (lydovang.Equals(""))
                        lydovang = "KHÔNG RÕ";
                    LichSuVang lsv = new LichSuVang(mapdd, id, masv, hotensv, gioitinh, ngaysinh, lopnienche, lydovang);
                    lstLsv.Add(lsv);
         
                }
                DialogResult r = MessageBox.Show(result, "Xác Nhận Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    try
                    {
                        int thempdd = BUS.PhieuDiemDanhBUS.Instance.Insert_PhieuDiemDanh(pdd);
                        int kq = 0;
                        foreach (LichSuVang lsv in lstLsv)
                        {
                            int themlichsuvang = BUS.LichSuVangBUS.Instance.Insert_LichSuVang(lsv);
                            if (themlichsuvang != 1)
                            {
                                kq = -1;
                                break;
                            }
                        }
                        if (kq == -1)
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm Phiếu Điểm Danh hoặc Lịch Sử Vắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm Phiếu Điểm Danh hoặc Lịch Sử Vắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXemDSDDSV_Click(object sender, EventArgs e)
        {
            
           

                fr_reportDSDDSV fr = new fr_reportDSDDSV();
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.ShowDialog();
                
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
