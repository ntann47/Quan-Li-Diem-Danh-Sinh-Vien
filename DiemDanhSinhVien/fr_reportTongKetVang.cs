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
    public partial class fr_reportTongKetVang : Form
    {
        public fr_reportTongKetVang()
        {
            InitializeComponent();
        }

        private void fr_reportTongKetVang_Load(object sender, EventArgs e)
        {
            MonHoc_LopMonHoc mh_lmh = fr_DiemDanhSinhVien.Monhoc_lopmonhoc;
            DataTable dt = MonHoc_LopMonHocBUS.Instance.TongKetVang_LopMonHoc(mh_lmh);
            reportTongKetVang rpt = new reportTongKetVang();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "123");
            crystalReportViewer1.Refresh();
        }
    }
}
