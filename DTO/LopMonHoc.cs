using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopMonHoc
    {
        string malopmh, tenlopmh, makhoa, khoa;

        public string Malopmh { get => malopmh; set => malopmh = value; }
        public string Tenlopmh { get => tenlopmh; set => tenlopmh = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public LopMonHoc(string malopmh, string tenlopmh, string makhoa, string khoa)
        {
            this.malopmh = malopmh;
            this.tenlopmh = tenlopmh;
            this.makhoa = makhoa;
            this.khoa = khoa;
        }
    }
}
