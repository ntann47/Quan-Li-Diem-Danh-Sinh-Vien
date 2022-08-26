using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        string mamh, tenmh;
        int tongsotiet, sotietlt, sotietth;

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int Tongsotiet { get => tongsotiet; set => tongsotiet = value; }
        public int Sotietlt { get => sotietlt; set => sotietlt = value; }
        public int Sotietth { get => sotietth; set => sotietth = value; }
        public MonHoc(string mamh, string tenmh, int tongsotiet, int sotietlt, int sotietth)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.tongsotiet = tongsotiet;
            this.sotietlt = sotietlt;
            this.sotietth = sotietth;
        }
    }
}
