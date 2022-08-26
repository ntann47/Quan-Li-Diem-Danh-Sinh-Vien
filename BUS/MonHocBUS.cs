using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class MonHocBUS
    {
        private static MonHocBUS instance;

        public static MonHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonHocBUS();
                return instance;
            }
        }
        public DataTable Load_DanhSach_MonHoc()
        {

            return MonHocDAO.Instance.Load_DanhSach_MonHoc();
        }

        public int Insert_MonHoc(MonHoc mh)
        {

            if (MonHocDAO.Instance.Insert_MonHoc(mh) == 1)
            {

                return 1;
            }
            else
                return -1;
        }
        public int Delete_MonHoc(MonHoc mh)
        {
            if (MonHocDAO.Instance.Delete_MonHoc(mh) != -1)
            {

                return 1;
            }
            else
                return -1;

        }
        public int Update_MonHoc(MonHoc mh)
        {
            if (MonHocDAO.Instance.Update_MonHoc(mh) != -1)
            {

                return 1;
            }
            else
                return -1;

        }
        public MonHoc timMonHoc(string mamh)
        {
            return MonHocDAO.Instance.timMonHoc(mamh);
        }
    }
}
