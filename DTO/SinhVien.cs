using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class SinhVien
    {
        string masv, hotensv, gioitinh, lopnienche;
        DateTime ngaysinh;

        public string Masv { get => masv; set => masv = value; }
        public string Hotensv { get => hotensv; set => hotensv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Lopnienche { get => lopnienche; set => lopnienche = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public SinhVien(string masv, string hotensv, string gioitinh,DateTime ngaysinh, string lopnienche)
        {
            this.masv=masv;
            this.hotensv = hotensv;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.lopnienche = lopnienche;   
        }
    }
}
