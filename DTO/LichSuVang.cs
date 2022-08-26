using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuVang
    {
	
		int mapdd, id;
		string masv, hotensv, gioitinh, ngaysinh, lopnienche, lydovang;

        public int Mapdd { get => mapdd; set => mapdd = value; }
        public int Id { get => id; set => id = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Hotensv { get => hotensv; set => hotensv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Lopnienche { get => lopnienche; set => lopnienche = value; }
        public string Lydovang { get => lydovang; set => lydovang = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public LichSuVang(int ma, int id, string masv, string hoten, string gioitinh,string ngaysinh, string lopnienche, string lidovang)
        {
            this.mapdd = ma;
            this.id = id;
            this.masv = masv;
            this.hotensv = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.lopnienche = lopnienche;
            this.lydovang = lidovang;
        }
        public override string ToString()
        {
            return this.masv + " - "+this.hotensv+" - "+this.lopnienche;
        }
    }
}
