using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class GiangVienBUS
    {
        private static GiangVienBUS instance;

        public static GiangVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiangVienBUS();
                return instance;
            }
        }

        public DataTable Load_DanhSach_GiangVien()
        {
            return GiangVienDAO.Instance.Load_DanhSach_GiangVien();
        }
        public DataTable Load_DSLop_GV(string magv)
        {
            return GiangVienDAO.Instance.Load_DSLop_GV(magv);
        }
        public DataTable Load_DSCBMH_GV(string magv)
        {
            return GiangVienDAO.Instance.Load_DSCBMH_GV(magv);
        }
        public DataTable Load_DSLopDiemDanh_GV(string magv, string tenmh)
        {
            return GiangVienDAO.Instance.Load_DSLopDiemDanh_GV(magv, tenmh);
        }
        public GiangVien LayThongTin_GV(string magv)
        {
            return GiangVienDAO.Instance.LayThongTin_GV(magv);
        }
        public int Insert_GiangVien(GiangVien gv)
        {
            if (GiangVienDAO.Instance.Insert_GiangVien(gv) == 1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Update_GiangVien(GiangVien gv)
        {
            if (GiangVienDAO.Instance.Update_GiangVien(gv) != -1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Delete_GiangVien(GiangVien gv)
        {
            if (GiangVienDAO.Instance.Delete_GiangVien(gv) != -1)
            {

                return 1;
            }
            else
                return -1;
        }
        
    }
}
