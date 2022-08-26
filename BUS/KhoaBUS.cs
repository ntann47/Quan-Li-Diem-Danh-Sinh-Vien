using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class KhoaBUS
    {
        private static KhoaBUS instance;

        public static KhoaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoaBUS();
                return instance;
            }
        }
        public DataTable Load_Khoa()
        {
            
            return KhoaDAO.Instance.Load_Khoa();
        }
    }
}
