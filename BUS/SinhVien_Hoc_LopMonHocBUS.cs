using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SinhVien_Hoc_LopMonHocBUS
    {
        private static SinhVien_Hoc_LopMonHocBUS instance;
        public static SinhVien_Hoc_LopMonHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVien_Hoc_LopMonHocBUS();
                return instance;
            }
        }
        public int Insert_SinhVien_Hoc_LopMonHoc(SinhVien_Hoc_LopMonHoc shl)
        {
            if (SinhVien_Hoc_LopMonHocDAO.Instance.Insert_SinhVien_Hoc_LopMonHoc(shl) != -1)
                return 1;
            else
                return -1;

        }
        public int Delete_SinhVien_Hoc_LopMonHoc(SinhVien_Hoc_LopMonHoc shl)
        {
            if (SinhVien_Hoc_LopMonHocDAO.Instance.Delete_SinhVien_Hoc_LopMonHoc(shl) != -1)
                return 1;
            else
                return -1;
        }
        public int KiemTraKhoaNgoai_SinhVien(SinhVien sv)
        {
            
            return SinhVien_Hoc_LopMonHocDAO.Instance.KiemTraKhoaNgoai_SinhVien(sv);
        }
        public int KiemTraKhoaNgoai_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {
            
            return SinhVien_Hoc_LopMonHocDAO.Instance.KiemTraKhoaNgoai_MonHoc_LopMonHoc(mh_lmh);
        }
    }
}
