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

namespace DiemDanhSinhVien
{
    public partial class fr_Main : Form
    {
        private TaiKhoan taikhoandangdangnhap;

        public TaiKhoan Taikhoandangdangnhap { get => taikhoandangdangnhap; set => taikhoandangdangnhap = value; }

        public fr_Main()
        {
            InitializeComponent();
            taikhoandangdangnhap = fr_DangNhap.Taikhoandangdangnhap;
            if (taikhoandangdangnhap.Maphanquyen.Equals("QTV") == false)
                quảnTrịViênToolStripMenuItem.Enabled = false;
            else if (taikhoandangdangnhap.Maphanquyen.Equals("GV") == false)
                giảngViênToolStripMenuItem.Enabled = false;


        }
        private void fr_Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form frm = kiemtratontai(typeof(fr_ThongTinTaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_ThongTinTaiKhoan fr = new fr_ThongTinTaiKhoan();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }

        private void giảngViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_GiangVien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_GiangVien fr = new fr_GiangVien();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_SinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_SinhVien fr = new fr_SinhVien();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }


        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_LopDangDay));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_LopDangDay fr = new fr_LopDangDay();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void điểmDanhSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_DiemDanhSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_DiemDanhSinhVien fr = new fr_DiemDanhSinhVien();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_ThongTinTaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_ThongTinTaiKhoan fr = new fr_ThongTinTaiKhoan();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r==DialogResult.OK)
            {
                this.Hide();
                fr_DangNhap fr = new fr_DangNhap();
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }    
        }

        private void sinhViênHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_SinhVien_Hoc_LopMH));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_SinhVien_Hoc_LopMH fr = new fr_SinhVien_Hoc_LopMH();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void lớpMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_MonHoc_LopMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_MonHoc_LopMonHoc fr = new fr_MonHoc_LopMonHoc();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TaiKhoan fr = new fr_TaiKhoan();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void lớpMônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_MonHoc_LopMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_MonHoc_LopMonHoc fr = new fr_MonHoc_LopMonHoc();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void giảngViênDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_GiangVien_Day_LopMH));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_GiangVien_Day_LopMH fr = new fr_GiangVien_Day_LopMH();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DoiMatKhau fr = new fr_DoiMatKhau();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_MonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_MonHoc fr = new fr_MonHoc();
                fr.MdiParent = this;
                fr.StartPosition = FormStartPosition.CenterScreen;
                fr.Show();
            }
        }
    }
}
