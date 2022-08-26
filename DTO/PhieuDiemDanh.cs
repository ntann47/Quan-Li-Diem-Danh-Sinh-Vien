using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDiemDanh
    {
        int mapdd, idlopmh, tuanthu, sosinhvienvang;
        DateTime ngaydiemdanh;

        public int Mapdd { get => mapdd; set => mapdd = value; }
        public int Idlopmh { get => idlopmh; set => idlopmh = value; }
        public int Tuanthu { get => tuanthu; set => tuanthu = value; }
        public int Sosinhvienvang { get => sosinhvienvang; set => sosinhvienvang = value; }
        public DateTime Ngaydiemdanh { get => ngaydiemdanh; set => ngaydiemdanh = value; }
        public PhieuDiemDanh(int ma, int id, int tuan, DateTime ngay, int vang)
        {
            this.mapdd = ma;
            this.idlopmh = id;
            this.tuanthu = tuan;
            this.ngaydiemdanh = ngay;
            this.sosinhvienvang = vang;  
        }
    }
}
