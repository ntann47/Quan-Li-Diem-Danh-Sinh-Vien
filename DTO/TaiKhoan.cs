using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        string tentaikhoan, tennguoidung, matkhau, maphanquyen;

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Tennguoidung { get => tennguoidung; set => tennguoidung = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Maphanquyen { get => maphanquyen; set => maphanquyen = value; }
        public TaiKhoan(string tentaikhoan, string tennguoidung, string matkhau, string maphanquyen)
        {
            this.tentaikhoan = tentaikhoan;
            this.tennguoidung = tennguoidung;
            this.matkhau = matkhau;
            this.maphanquyen = maphanquyen;
        }
    }
}
