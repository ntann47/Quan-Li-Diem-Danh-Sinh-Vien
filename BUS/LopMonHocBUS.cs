using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class LopMonHocBUS
    {
        private static LopMonHocBUS instance;

        public static LopMonHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopMonHocBUS();
                return instance;
            }
        }
        public DataTable Load_DanhSach_LopNienChe()
        {
            return LopMonHocDAO.Instance.Load_DanhSach_LopNienChe();
        }
    }
}
