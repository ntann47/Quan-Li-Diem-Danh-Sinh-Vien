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
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonHocDAO();
                return instance;
            }

        }
        public DataTable Load_DanhSach_MonHoc()
        {
            DataTable dt_DSMH = new DataTable();
            string query = "SELECT * FROM MONHOC";
            dt_DSMH = DataProvider.Instance.ExcuteQuery(query);
            return dt_DSMH;
        }
        public int Insert_MonHoc (MonHoc mh)
        {
          
            int rows = -1;
            string query = "INSERT INTO MONHOC VALUES( @MAMH , @TENMH , @TONGSOTIET , @SOTIETLT , @SOTIETTH )";
            object[] parameter = new object[] { mh.Mamh, mh.Tenmh, mh.Tongsotiet, mh.Sotietlt, mh.Sotietth };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Delete_MonHoc(MonHoc mh)
        {
            
            int rows = -1;
            string query = "DELETE FROM MONHOC WHERE MAMH = @MAMH";
            object[] parameter = new object[] { mh.Mamh };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Update_MonHoc(MonHoc mh)
        {
            int rows = -1;
            string query = "UPDATE MONHOC SET TENMH = @TENMH , TONGSOTIET = @TONG , SOTIETLT = @LT , SOTIETTH = @TH WHERE MAMH = @MA";
            object[] parameter = new object[] { mh.Tenmh,mh.Tongsotiet,mh.Sotietlt,mh.Sotietth,mh.Mamh };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public MonHoc timMonHoc(string mamh)
        {
            DataTable dt_mh = new DataTable();
            string query = "SELECT * FROM MONHOC WHERE MAMH = @MAMH";
            object[] parameter = new object[] { mamh };
            dt_mh = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt_mh.Rows.Count != 0)
            {
                string mamonhoc  = dt_mh.Rows[0][0].ToString().Trim();
                string tenmh = dt_mh.Rows[0][1].ToString().Trim();
                int tongsotiet = Int32.Parse(dt_mh.Rows[0][2].ToString().Trim());
                int sotietlt = Int32.Parse(dt_mh.Rows[0][3].ToString().Trim());
                int sotietth = Int32.Parse(dt_mh.Rows[0][4].ToString().Trim()); 
                MonHoc x = new MonHoc(mamonhoc,tenmh,tongsotiet,sotietlt,sotietth);
                return x;
            }
            return null;
        }

    }
}
