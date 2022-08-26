using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LichSuVangBUS
    {
        private static LichSuVangBUS instance;

        public static LichSuVangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichSuVangBUS();
                return instance;
            }
        }
        public DataTable LayDS_LichSuVang_PDD(int mapdd)
        {
            return LichSuVangDAO.Instance.LayDS_LichSuVang_PDD(mapdd);
        }
        public int Insert_LichSuVang(LichSuVang lsv)
        {
           
            if (LichSuVangDAO.Instance.Insert_LichSuVang(lsv) == 1)
            {
                return 1;
            }
            else
                return -1;
        }
        public int KiemTraKhoaNgoai_SinhVien(SinhVien sv)
        {
            
            return LichSuVangDAO.Instance.KiemTraKhoaNgoai_SinhVien(sv);
        }
    }
}
