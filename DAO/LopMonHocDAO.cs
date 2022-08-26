using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopMonHocDAO
    {
        private static LopMonHocDAO instance;

        public static LopMonHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopMonHocDAO();
                return instance;
            }
        }
        public DataTable Load_DanhSach_LopNienChe()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LOPMONHOC";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }
        public int Insert_LopMonHoc(LopMonHoc lmh)
        {
            string query = "INSERT INTO MONHOC VALUES( @MALOPMH , @TENLOPMH , @MAKHOA , @KHOA  )";
            object[] parameter = new object[] { lmh.Malopmh, lmh.Tenlopmh, lmh.Makhoa, lmh.Khoa };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
        public int Delete_LopMonHoc(LopMonHoc mh)
        {
            string query = "DELETE FROM MONHOC WHERE MALOPMH = @MALOPMH )";
            object[] parameter = new object[] { mh.Malopmh };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameter);
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
    }
}
