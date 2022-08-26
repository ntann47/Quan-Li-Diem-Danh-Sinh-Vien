using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        string magiangvien, hotengv, gioitinh, trinhdo, makhoa;
        DateTime ngaysinh;

        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public string Hotengv { get => hotengv; set => hotengv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Trinhdo { get => trinhdo; set => trinhdo = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public GiangVien(string magiangvien, string hotengv, string gioitinh, DateTime ngaysinh,string trinhdo, string makhoa)
        {
            this.magiangvien = magiangvien;
            this.hotengv = hotengv;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.trinhdo = trinhdo;
            this.makhoa = makhoa;
        }
        public GiangVien()
        {
            this.magiangvien = "Chưa rõ";
            this.hotengv = "Chưa rõ";
            this.gioitinh = "Chưa rõ";
            this.ngaysinh = DateTime.Parse("1/1/1990");
            this.trinhdo = "Chưa rõ";
            this.makhoa = "Chưa rõ";
        }
    }
}
