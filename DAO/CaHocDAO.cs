using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CaHocDAO
    {
        private static CaHocDAO instance;

        public static CaHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaHocDAO();
                return instance;
            }
        }
        public DataTable Load_CaHoc()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CAHOC";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }
    }
}
