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
    public partial class fr_reportDSDDSV : Form
    {
        
        public fr_reportDSDDSV()
        {
            InitializeComponent();
        }

        private void fr_reportDSDDSV_Load(object sender, EventArgs e)
        {
            MonHoc_LopMonHoc mh_lmh = fr_DiemDanhSinhVien.Monhoc_lopmonhoc;
            DataTable dt_DSDDSV = SinhVienBUS.Instance.Lay_DSDDSV_LopMonHoc(mh_lmh.Idlopmh);
            reportDSDDSV rpt = new reportDSDDSV();
            rpt.SetDataSource(dt_DSDDSV);
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "123");
            crystalReportViewer1.Refresh();
        }
    }
}
