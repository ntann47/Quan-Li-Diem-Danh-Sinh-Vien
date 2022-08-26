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
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        public DataTable Load_DS_TaiKhoan()
        {
            return TaiKhoanDAO.Instance.Load_DS_TaiKhoan();
        }
        public TaiKhoan LayThongTinTaiKhoan_GV(string tentaikhoan)
        {
            return TaiKhoanDAO.Instance.LayThongTinTaiKhoan_GV(tentaikhoan);
        }
        public DataTable Load_QuyenTruyCap()
        {
            return TaiKhoanDAO.Instance.Load_QuyenTruyCap();
        }
        public int KiemTraTenTaiKhoan(string tentaikhoan)
        {


            if (TaiKhoanDAO.Instance.KiemTraTenTaiKhoan(tentaikhoan) != null)
            {

                return 1;
            }
            else
                return -1;
        }
        public int KiemTraTenNguoiDung(string tenngdung)
        {

            if (TaiKhoanDAO.Instance.KiemTraTenNguoiDung(tenngdung) != null)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Insert_TaiKhoan(TaiKhoan tk)
        {

            if (TaiKhoanDAO.Instance.Insert_TaiKhoan(tk) == 1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Update_TaiKhoan(TaiKhoan tk)
        {
            if (TaiKhoanDAO.Instance.Update_TaiKhoan(tk) != -1)
                return 1;
            else
                return -1;

        }
        public int Delete_TaiKhoan(TaiKhoan tk)
        {
            if (TaiKhoanDAO.Instance.Delete_TaiKhoan(tk) != -1)
                return 1;
            else
                return -1;
        }
        public int KiemTraKhoaNgoai_GiangVien(TaiKhoan tk)
        {
            return GiangVienDAO.Instance.KiemTraKhoaNgoai_GiangVien(tk);
        }
    }
}
