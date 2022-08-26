using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_LopMonHoc
    {
		int idlopmh, hocky, sobuoihoc, siso;
		string malopmh, mamh, magiangvien, namhoc, maphonghoc, macahoc, trangthai;
		DateTime ngaybatdau, ngayketthuc;

        public int Idlopmh { get => idlopmh; set => idlopmh = value; }
        public int Hocky { get => hocky; set => hocky = value; }
        public int Sobuoihoc { get => sobuoihoc; set => sobuoihoc = value; }
        public int Siso { get => siso; set => siso = value; }
        public string Malopmh { get => malopmh; set => malopmh = value; }
        public string Mamh { get => mamh; set => mamh = value; }
        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public string Namhoc { get => namhoc; set => namhoc = value; }
        public string Maphonghoc { get => maphonghoc; set => maphonghoc = value; }
        public string Macahoc { get => macahoc; set => macahoc = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public MonHoc_LopMonHoc(int idlopmh, string malopmh, string mamh, string magv, int hocky, string namhoc, int sobuoihoc, DateTime ngaybatdau, DateTime ngayketthuc, int siso, string maphonghoc, string macahoc, string trangthai )
        {
            this.idlopmh = idlopmh;
            this.malopmh = malopmh;
            this.mamh = mamh; 
            this.magiangvien = magv;
            this.hocky = hocky;
            this.namhoc = namhoc;
            this.sobuoihoc = sobuoihoc;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.siso = siso;
            this.maphonghoc = maphonghoc;
            this.macahoc = macahoc;
            this.trangthai = trangthai;
        }
        public MonHoc_LopMonHoc(int idlopmh, string malopmh, string mamh, int hocky, string namhoc, int sobuoihoc, DateTime ngaybatdau, DateTime ngayketthuc, int siso, string maphonghoc, string macahoc,string trangthai)
        {
            this.idlopmh = idlopmh;
            this.malopmh = malopmh;
            this.mamh = mamh;
            this.hocky = hocky;
            this.namhoc = namhoc;
            this.sobuoihoc = sobuoihoc;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.siso = siso;
            this.maphonghoc = maphonghoc;
            this.macahoc = macahoc;
            this.trangthai = trangthai;
        }
       
    }
}
