using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class MonHoc_LopMonHocBUS
    {
        private static MonHoc_LopMonHocBUS instance;
        public static MonHoc_LopMonHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonHoc_LopMonHocBUS();
                return instance;
            }
        }
        public MonHoc_LopMonHoc LayThongTin_MonHoc_LopMH(int idlopmh)
        {
            return MonHoc_LopMonHocDAO.Instance.LayThongTin_MonHoc_LopMH(idlopmh);
        }
        public DataTable Load_DSMH_LMH()
        {
            return MonHoc_LopMonHocDAO.Instance.Load_DSMH_LMH();
        }
        public int Update_MonHoc_LopMonHoc(MonHoc_LopMonHoc x)
        {
            if (MonHoc_LopMonHocDAO.Instance.Update_MonHoc_LopMonHoc(x) != -1)
                return 1;
            else
                return -1;

        }
        public int Delete_MonHoc_LopMonHoc(MonHoc_LopMonHoc x)
        {
            if (MonHoc_LopMonHocDAO.Instance.Delete_MonHoc_LopMonHoc(x) != -1)
                return 1;
            else
                return -1;
        }
        public int Insert_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {
            if (MonHoc_LopMonHocDAO.Instance.Insert_MonHoc_LopMonHoc(mh_lmh) != -1)
                return 1;
            else
                return -1;
        }
        public DataTable Load_DSLopMonHocTheoMaMonHoc(string mamh)
        {
            return MonHoc_LopMonHocDAO.Instance.Load_DSLopMonHocTheoMaMonHoc(mamh);
        }
        public int Update_GV_MonHoc_LopMonHoc(MonHoc_LopMonHoc x, string magv)
        {
            if (MonHoc_LopMonHocDAO.Instance.Update_GV_MonHoc_LopMonHoc(x, magv) != -1)
                return 1;
            else
                return -1;
        }
        public DataTable TongKetVang_LopMonHoc(MonHoc_LopMonHoc x)
        {
            return MonHoc_LopMonHocDAO.Instance.TongKetVang_LopMonHoc(x);
        }
        public int KiemTraKhoaNgoai_GiangVien(GiangVien gv)
        {
            return MonHoc_LopMonHocDAO.Instance.KiemTraKhoaNgoai_GiangVien(gv);
        }
        public int KiemTraKhoaNgoai_MonHoc(MonHoc mh)
        {
            return MonHoc_LopMonHocDAO.Instance.KiemTraKhoaNgoai_MonHoc(mh);
        }
        public int LaySiSo_LopMonHoc(MonHoc_LopMonHoc x)
        {
            return MonHoc_LopMonHocDAO.Instance.LaySiSo_LopMonHoc(x.Idlopmh);
        }
    }
}