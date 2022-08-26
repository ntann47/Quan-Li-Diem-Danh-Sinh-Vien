using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienDAO();
                return instance;
            }
        }
        public DataTable Load_DanhSach_SinhVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SINHVIEN";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }
        public DataTable Lay_DSDDSV_LopMonHoc(int idlopmh)
        {
            DataTable ds_DSSV = new DataTable();
            string query = "EXEC dbo.LAY_DSSINHVIEN_LOPMONHOC @IDLOPMH";
            object[] parameter = new object[] { idlopmh };
            ds_DSSV = DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_DSSV;
        }
        /*public int Insert_SinhVien(SinhVien sv)
        {
            string query = "EXEC dbo.INSERT_SINHVIEN @MASV , @HOTENSV , @GIOITINH , @NGAYSINH , @LOPNIENCHE";
            object[] parameter = new object[] { sv.Masv,sv.Hotensv,sv.Gioitinh,sv.Ngaysinh,sv.Lopnienche };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }*/
       /* public int Update_SinhVien(SinhVien sv)
        {
            int rows = -1;
            string query = "EXEC dbo.UPDATE_SINHVIEN @MASV , @HOTENSV , @GIOITINH , @NGAYSINH , @LOPNIENCHE";
            object[] parameter = new object[] { sv.Masv, sv.Hotensv, sv.Gioitinh, sv.Ngaysinh, sv.Lopnienche };
            try
            {
               rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return rows;
        }*/
        /*public int Delete_SinhVien(SinhVien sv)
        {
            string query = "DELETE FROM SINHVIEN WHERE MASV = @MASV )";
            object[] parameter = new object[] { sv.Masv };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }*/
        public SinhVien LayThongTin_SV(string masv)
        {

            DataTable dt_Sv = new DataTable();
            string query = "SELECT * FROM SINHVIEN WHERE MASV = @MASV";
            object[] parameter = new object[] { masv.Trim() };
            dt_Sv = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt_Sv.Rows.Count != 0)
            {

                string ma = dt_Sv.Rows[0][0].ToString().Trim();
                string ten = dt_Sv.Rows[0][1].ToString().Trim();
                string gioitinh = dt_Sv.Rows[0][2].ToString().Trim();
                string ngsinh = dt_Sv.Rows[0][3].ToString().Trim();
                DateTime dt_ngsinh = DateTime.Parse(ngsinh);
                string lopnienche = dt_Sv.Rows[0][4].ToString().Trim();
                SinhVien sv = new SinhVien(ma, ten, gioitinh, dt_ngsinh, lopnienche);
                return sv;
            }
            return null;
        }
        public int Insert_SinhVien(SinhVien sv)
        {
            
            int rows = -1;
            string query = "EXEC dbo.INSERT_SINHVIEN @MASV , @HOTENSV , @GIOITINH , @NGAYSINH , @LOPNIENCHE";
            object[] parameter = new object[] { sv.Masv, sv.Hotensv, sv.Gioitinh, sv.Ngaysinh, sv.Lopnienche };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Update_SinhVien(SinhVien sv)
        {
            int rows = -1;
            string query = "EXEC dbo.UPDATE_SINHVIEN @MASV , @HOTENSV , @GIOITINH , @NGAYSINH , @LOPNIENCHE";
            object[] parameter = new object[] { sv.Masv, sv.Hotensv, sv.Gioitinh, sv.Ngaysinh, sv.Lopnienche };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Delete_SinhVien(SinhVien sv)
        {
            int rows = -1;
            string query = "DELETE FROM SINHVIEN WHERE MASV = @MASV";
            object[] parameter = new object[] { sv.Masv };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        
    }
}
