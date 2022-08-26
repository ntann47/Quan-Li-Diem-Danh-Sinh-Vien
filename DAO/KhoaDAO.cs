using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhoaDAO
    {
        private static KhoaDAO instance;

        public static KhoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoaDAO();
                return instance;
            }
        }
        public DataTable Load_Khoa()
        {
            DataTable dt_Khoa = new DataTable();
            string query = "SELECT * FROM KHOA";
            dt_Khoa = DataProvider.Instance.ExcuteQuery(query);
            return dt_Khoa;
        }
        public int Insert_Khoa(Khoa k)
        {
            string query = "INSERT INTO KHOA VALUES( @MAKHOA , @TENKHOA )";
            object[] parameter = new object[] { k.Makhoa, k.Tenkhoa };
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
        public int Delete_Khoa(Khoa k)
        {
            string query = "DELETE FROM KHOA WHERE MAKHOA = @MAKHOA )";
            object[] parameter = new object[] { k.Makhoa };
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
