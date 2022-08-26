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
    public class SinhVienBUS
    {
        private static SinhVienBUS instance;

        public static SinhVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienBUS();
                return instance;
            }
        }
        public SinhVien LayThongTin_SV(string masv)
        {
            return SinhVienDAO.Instance.LayThongTin_SV(masv);
        }
        public DataTable Load_DanhSach_SinhVien()
        {
           
            return SinhVienDAO.Instance.Load_DanhSach_SinhVien();
        }
        public DataTable Lay_DSDDSV_LopMonHoc(int idlopmh)
        {
            return SinhVienDAO.Instance.Lay_DSDDSV_LopMonHoc(idlopmh);
        }
        public int Insert_SinhVien(SinhVien sv)
        {
            if (SinhVienDAO.Instance.Insert_SinhVien(sv) == 1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Update_SinhVien(SinhVien sv)
        {
            if (SinhVienDAO.Instance.Update_SinhVien(sv) != -1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Delete_SinhVien(SinhVien sv)
        {
            if (SinhVienDAO.Instance.Delete_SinhVien(sv)!=-1)
            {     

                return 1;
            }
            else
                return -1;
        }
    }
}
