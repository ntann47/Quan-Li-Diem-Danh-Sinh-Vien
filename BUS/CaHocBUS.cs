using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class CaHocBUS
    {
        private static CaHocBUS instance;

        public static CaHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaHocBUS();
                return instance;
            }
        }
        public DataTable Load_CaHoc()
        {
            return CaHocDAO.Instance.Load_CaHoc();
        }

    }
}
