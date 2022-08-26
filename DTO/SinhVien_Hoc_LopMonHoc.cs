using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien_Hoc_LopMonHoc
    {
        int idlopmh;
        string masv;
        DateTime ngaydangky; 

        public int Idlopmh { get => idlopmh; set => idlopmh = value; }
        public string Masv { get => masv; set => masv = value; }
        public DateTime Ngaydangky { get => ngaydangky; set => ngaydangky = value; }

        public SinhVien_Hoc_LopMonHoc(int idlopmh,string masv, DateTime ngaydk)
        {
            this.idlopmh = idlopmh;
            this.masv = masv;
            this.ngaydangky = ngaydk;
        }
    }
}
