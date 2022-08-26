using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaHoc
    {
        string macahoc,giobatdau,gioketthuc, buoihoc;

        public string Macahoc { get => macahoc; set => macahoc = value; }
        public string Giobatdau { get => giobatdau; set => giobatdau = value; }
        public string Gioketthuc { get => gioketthuc; set => gioketthuc = value; }
        public string Buoihoc { get => buoihoc; set => buoihoc = value; }
        public CaHoc (string maca, string giobd,string giokt,string buoihoc)
        {
            this.macahoc = maca;
            this.giobatdau = giobd;
            this.gioketthuc = giokt;
            this.buoihoc = buoihoc;
        }
    }
}
