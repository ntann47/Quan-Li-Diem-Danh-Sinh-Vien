using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }
        public TaiKhoan KiemTraTaiKhoan(string tentaikhoan,string matkhau)
        {
           
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = @TENTK AND MATKHAU = @MK";
            object[] parameter = new object[] { tentaikhoan.Trim(),matkhau.Trim() };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                string tentk = dt.Rows[0][0].ToString().Trim();
                string tennguoidung = dt.Rows[0][1].ToString().Trim();
                string mk = dt.Rows[0][2].ToString().Trim();
                string maphanquyen = dt.Rows[0][3].ToString().Trim();
                TaiKhoan tk = new TaiKhoan(tentk, tennguoidung, mk, maphanquyen);
                return tk;

            }    
            else
                 return null;
        }
        public TaiKhoan KiemTraTenTaiKhoan(string tentaikhoan)
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = @TENTAIKHOAN";
            object[] parameter = new object[] { tentaikhoan.Trim() };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                string tentk = dt.Rows[0][0].ToString().Trim();
                string tennguoidung = dt.Rows[0][1].ToString().Trim();
                string mk = dt.Rows[0][2].ToString().Trim();
                string maphanquyen = dt.Rows[0][3].ToString().Trim();
                TaiKhoan tk = new TaiKhoan(tentk, tennguoidung, mk, maphanquyen);
                return tk;
            }
            else
                return null;
        }
        public TaiKhoan KiemTraTenNguoiDung(string tenngdung)
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE TENNGUOIDUNG = @TENNGUOIDUNG";
            object[] parameter = new object[] { tenngdung.Trim() };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                string tentk = dt.Rows[0][0].ToString().Trim();
                string tennguoidung = dt.Rows[0][1].ToString().Trim();
                string mk = dt.Rows[0][2].ToString().Trim();
                string maphanquyen = dt.Rows[0][3].ToString().Trim();
                TaiKhoan tk = new TaiKhoan(tentk, tennguoidung, mk, maphanquyen);
                return tk;
            }
            else
                return null;
        }
        public TaiKhoan LayThongTinTaiKhoan_GV(string tentaikhoan)
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = @TENTK";
            object[] parameter = new object[] { tentaikhoan.Trim() };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                string tentk = dt.Rows[0][0].ToString().Trim();
                string tennguoidung = dt.Rows[0][1].ToString().Trim();
                string mk = dt.Rows[0][2].ToString().Trim();
                string maphanquyen = dt.Rows[0][3].ToString().Trim();
                TaiKhoan tk = new TaiKhoan(tentk, tennguoidung, mk, maphanquyen);
                return tk;

            }
            else
                return null;
        }
        public int Insert_TaiKhoan(TaiKhoan tk)
        {
            string query = "INSERT INTO TAIKHOAN VALUES( @TENTAIKHOAN , @TENNGUOIDUNG , @MATKHAU , @MAPHANQUYEN )";
            object[] parameter = new object[] { tk.Tentaikhoan,tk.Tennguoidung,tk.Matkhau,tk.Maphanquyen };
            try{
                DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
        public int Update_TaiKhoan(TaiKhoan tk)
        {
            int rows=-1;
            string query = "UPDATE TAIKHOAN SET TENNGUOIDUNG = @TENNGUOIDUNG , MATKHAU = @MATKHAU , MAPHANQUYEN = @MAPHANQUYEN WHERE TENTAIKHOAN = @TENTAIKHOAN";
            object[] parameter = new object[] { tk.Tennguoidung, tk.Matkhau, tk.Maphanquyen, tk.Tentaikhoan };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;

        }
        public int Delete_TaiKhoan(TaiKhoan tk)
        {
            int rows = -1;
            string query = "DELETE FROM TAIKHOAN WHERE TENTAIKHOAN = @TENTAIKHOAN";
            object[] parameter = new object[] { tk.Tentaikhoan.Trim() };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public DataTable Load_DS_TaiKhoan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;

        }
        public DataTable Load_QuyenTruyCap()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM QUYENTRUYCAP";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

  
    }
}
