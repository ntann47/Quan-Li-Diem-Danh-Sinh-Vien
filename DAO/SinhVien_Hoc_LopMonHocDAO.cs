using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SinhVien_Hoc_LopMonHocDAO
    {
        private static SinhVien_Hoc_LopMonHocDAO instance;

        public static SinhVien_Hoc_LopMonHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVien_Hoc_LopMonHocDAO();
                return instance;
            }
        }
        public int Insert_SinhVien_Hoc_LopMonHoc(SinhVien_Hoc_LopMonHoc shl)
        {
            int rows = -1;
            string query = "INSERT INTO SINHVIEN_HOC_LOPMONHOC VALUES( @IDLOPMH , @MASV , @NGAYDK )";
            object[] parameter = new object[] { shl.Idlopmh,shl.Masv,shl.Ngaydangky };   
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;

        }
        public int Delete_SinhVien_Hoc_LopMonHoc(SinhVien_Hoc_LopMonHoc shl)
        {
            int rows = -1;
            string query = "DELETE FROM SINHVIEN_HOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH AND MASV = @MASV";
            object[] parameter = new object[] { shl.Idlopmh, shl.Masv };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int KiemTraKhoaNgoai_SinhVien(SinhVien sv)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SINHVIEN_HOC_LOPMONHOC WHERE MASV = @MASV";
            object[] parameter = new object[] { sv.Masv };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
        public int KiemTraKhoaNgoai_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SINHVIEN_HOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH";
            object[] parameter = new object[] { mh_lmh.Idlopmh };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
